using LibCheck.Modules;
using LibCheck.Modules.Security;
using SQLite;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                if (IsConnected)
                    return;
                SQLiteConnectionString connStr = new SQLiteConnectionString(dbPath, false, key: CryptComp.ConvertToString(secString));
                Debug.Print(CryptComp.ConvertToString(secString));
                _conn = new SQLiteConnection(connStr);
                protectedByte = ProtectedData.Protect(Encoding.UTF8.GetBytes(CryptComp.ConvertToString(secString)),
                                                      null,
                                                      DataProtectionScope.CurrentUser);
               
                Logger.Log(Logger.LogEnums.Info,"Database loaded");
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
            }
        }

        internal static byte[] KeyHandover() {
            if (!Credentials.LoggedIn) throw new InvalidOperationException("Access is denied.");
            if (protectedByte == null) throw new InvalidOperationException("Byte key not loaded.");
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

        internal static int Read<T>(out List<T>? res, string cols = "*", string whereCond = "") where T : new(){
            res = new List<T>();
            try {
                CheckConn();
                string q = $"SELECT {cols} FROM {typeof(T).Name}";
                if (!string.IsNullOrWhiteSpace(whereCond)) q += $" WHERE {whereCond}";
                res = _conn?.Query<T>(q);
                if (res == null) throw new InvalidOperationException("READ_FAILED");
                return res.Count;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return -1;
            }
        }

        internal static bool Insert(object obj) {
            try {
                CheckConn();
                return _conn?.Insert(obj) > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static bool Update(object obj) {
            try {
                CheckConn();
                return _conn?.Update(obj) > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        internal static bool Delete<T>(string primaryKey) where T : new (){
            try {
                CheckConn();
                return _conn?.Delete<T>(primaryKey) > 0;
            } catch (Exception ex) {
                WriteError(ex.Message);
                return false;
            }
        }

        private static void CheckConn() {
            if (!IsConnected) throw new InvalidOperationException("No connection established to the database.");
        }

        private static void WriteError(string msg) {
            Logger.Log(Logger.LogEnums.Error, $"Failed to execute database. ({msg})");
        }
    }
}
