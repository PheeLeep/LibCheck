using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using SQLite;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace LibCheck.Database {
    /// <summary>
    /// A basic class containing the database functions.
    /// </summary>
    internal static class Database {

        /// <summary>
        /// Get the current connection of the SQLCipher.
        /// </summary>
        internal static bool IsConnected {
            get => _conn != null;
        }

        private static SQLiteConnection? _conn = null;
        private static readonly object _locker = new object();
        private static byte[]? protectedByte;

        /// <summary>
        /// Loads the SQLCipher database.
        /// </summary>
        /// <param name="secString">A <see cref="SecureString"/> value for encryption.</param>
        /// <exception cref="FileNotFoundException"></exception>
        internal static void Load(SecureString secString) {
            lock (_locker) {
                string dbPath = Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite");
                if (!File.Exists(dbPath))
                    throw new FileNotFoundException("Database file was not found!");
                if (IsConnected) {
                    Logger.Log(Logger.LogEnums.Warn, "Database already loaded.");
                    return;
                }
                SQLiteConnectionString connStr = new SQLiteConnectionString(dbPath, false, key: CryptComp.ConvertToString(secString));
                _conn = new SQLiteConnection(connStr);
                protectedByte = ProtectedData.Protect(Encoding.UTF8.GetBytes(CryptComp.ConvertToString(secString)),
                                                      null,
                                                      DataProtectionScope.CurrentUser);

                Logger.Log(Logger.LogEnums.Info, "Database loaded");
            }
        }

        /// <summary>
        /// Unloads the database.
        /// </summary>
        internal static void Unload() {
            lock (_locker) {
                if (IsConnected)
                    return;
                _conn?.Close();
                _conn = null;
                Logger.Log(Logger.LogEnums.Warn, "Database Unloaded.");
            }
        }

        internal static byte[] KeyHandover() {
            StackTrace stackTrace = new StackTrace();
            MethodBase? methodBase = stackTrace.GetFrame(1)?.GetMethod();

            if (!Credentials.LoggedIn) throw new InvalidOperationException("Access is denied.");
            if (protectedByte == null) throw new InvalidOperationException("Byte key not loaded.");
            if (methodBase == null) {
                CrashControl.SCRAM(new InvalidOperationException(""));
                return Array.Empty<byte>();
            }
            Logger.Log(Logger.LogEnums.Warn,
                       $"SQLCipher: Key was handover to {methodBase.Module.Name}>>{methodBase.Name}().");
            return ProtectedData.Unprotect(protectedByte, null, DataProtectionScope.CurrentUser);
        }

        internal static bool CreateTable<T>() where T : new() {
            try {
                CheckConn();
                CreateTableResult? ctr = _conn?.CreateTable<T>();
                if (!ctr.HasValue) throw new InvalidOperationException("CTR_NULL_RES");
                TableMapping? tm = _conn?.GetMapping<T>();

                Logger.Log(Logger.LogEnums.Info, $"Table {tm?.TableName} created.");
                return true;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static int Read<T>(out List<T>? res) where T : new() {
            res = new List<T>();
            try {
                CheckConn();
                res = _conn?.Query<T>($"SELECT * FROM {typeof(T).Name}");
                if (res == null) throw new InvalidOperationException("READ_FAILED");
                return res.Count;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return -1;
            }
        }

        internal static bool Insert(object obj) {
            try {
                if (obj is LibrarianInfo && !Modules.AppContext.IsInAdminMode) return false;
                CheckConn();
                int? res = _conn?.Insert(obj);
                if (!res.HasValue) throw new InvalidOperationException("INSERT_FAILED");
                Logger.Log(Logger.LogEnums.Info, $"{obj.GetType().Name} >> {res} row{(res != 1 ? "s" : "")} inserted.");
                return res > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static bool Update(object obj) {
            try {
                if (obj is LibrarianInfo && !Modules.AppContext.IsInAdminMode) return false;
                CheckConn();
                int? res = _conn?.Update(obj);
                if (!res.HasValue) throw new InvalidOperationException("UPDATE_FAILED");
                Logger.Log(Logger.LogEnums.Info, $"{obj.GetType().Name} >> {res} row{(res != 1 ? "s" : "")} affected.");
                return res > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static bool Delete(object obj) {
            try {
                if (obj is LibrarianInfo && !Modules.AppContext.IsInAdminMode) return false;
                CheckConn();
                int? res = _conn?.Delete(obj);
                if (!res.HasValue) throw new InvalidOperationException("DEL_GEN_FAILED");
                Logger.Log(Logger.LogEnums.Info, $"{obj.GetType().Name} >> {res} row{(res != 1 ? "s" : "")} deleted.");
                return res > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static bool Delete<T>(string primaryKey) where T : new() {
            try {
                if (typeof(T).Name.Equals(nameof(LibrarianInfo)) && !Modules.AppContext.IsInAdminMode) return false;
                CheckConn();
                int? res = _conn?.Delete<T>(primaryKey);
                if (!res.HasValue) throw new InvalidOperationException("DEL_SPECIFIC_FAILED");
                Logger.Log(Logger.LogEnums.Info, $"SPECIFIC_DEL >> {res} row{(res != 1 ? "s" : "")} deleted.");
                return res > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static bool DeleteAll<T>() where T : new() {
            try {
                if (typeof(T).Name.Equals(nameof(LibrarianInfo)) && !Modules.AppContext.IsInAdminMode) return false;
                CheckConn();
                int? res = _conn?.DeleteAll<T>();
                if (!res.HasValue) throw new InvalidOperationException("DEL_TABLE_DATA_FAILED");
                Logger.Log(Logger.LogEnums.Info, $"DEL_TABLE_DATA >> {res} row{(res != 1 ? "s" : "")} deleted.");
                return res > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }


        internal static void ExportToCSV<T>(List<T> list, string path, string[]? specificCols = null) {
            using (StreamWriter sw = new StreamWriter(path)) {
                sw.WriteLine(string.Join(',', typeof(T).GetProperties().Select(pN => QuoteCSVValue(pN.Name))));

                foreach (T item in list) {
                    sw.WriteLine(string.Join(',', typeof(T).GetProperties()
                                                    .Select(pN => QuoteCSVValue(pN.GetValue(item)?.ToString()))));
                }
                sw.Flush();
            }
        }

        private static string QuoteCSVValue(string? val) {
            if (string.IsNullOrWhiteSpace(val)) return "";
            return val.Contains(',') ? $"\"{val}\"" : val;
        }

        private static void CheckConn() {
            if (!IsConnected) throw new InvalidOperationException("No connection established to the database.");
        }

        private static void WriteError(string msg) {
            Logger.Log(Logger.LogEnums.Error, $"Failed to execute database. ({msg})");
        }
    }
}
