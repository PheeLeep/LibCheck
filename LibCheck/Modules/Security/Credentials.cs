using LibCheck.Database.Tables;
using LibCheck.Forms;
using Newtonsoft.Json;
using SQLite;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using static LibCheck.Modules.WinNatives;

namespace LibCheck.Modules.Security {

    /// <summary>
    /// A class that houses credentials and functions.
    /// </summary>
    internal static class Credentials {

        internal delegate void TimeoutEventDelegate(bool isInLocked, string? info);

        private static bool _isInitialized = false;
        private static readonly object _lock = new object();
        private static LibrarianToken? token;
        private static DateTime expTime = DateTime.Now;
        private static int retries = 0;
        private static int incrementTimer = 0;

        internal static event TimeoutEventDelegate? TimeoutEvent;

        /// <summary>
        /// Checks whether the user is currently logged in.
        /// </summary>
        internal static bool LoggedIn { get; private set; }

        internal static LibrarianInfo? Librarian { get; private set; }
        /// <summary>
        /// Initialize the credentials.
        /// </summary>
        internal static void Initialize() {
            if (_isInitialized)
                CrashControl.SCRAM(new InvalidOperationException("Credentials already initialized."));
            if (!EnvVars.CredentialsInfo.Exists) {
                Logger.Log(Logger.LogEnums.Warn, $"No credentials info found. Creating...");
                EnvVars.CredentialsInfo.Create();
            }

            if (CheckPresence()) {
                Logger.Log(Logger.LogEnums.Verbose, $"Credentials and database found. Proceed loading...");
                LoadLibCCred();
            }

            _isInitialized = true;

            // Start the timeout watchdog.
            Task.Factory.StartNew(() => {
                Logger.Log(Logger.LogEnums.Verbose, "Timeout watchdog started.");

                while (_isInitialized) {
                    Task.Delay(100).Wait();
                    if (IsInHaltPhase()) {
                        TimeSpan dt = expTime - DateTime.Now;

                        StringBuilder sb = new StringBuilder();
                        sb.Append("You've been locked for ");
                        if ((int)dt.TotalHours > 0) sb.Append($"{string.Format("{00:00}", (int)dt.TotalHours)}:");
                        sb.Append($"{string.Format("{00:00}", dt.Minutes)}:");
                        sb.Append($"{string.Format("{00:00}", dt.Seconds)} ({expTime:dd/MM/yyyy hh:mm:ss tt})");

                        TimeoutEvent?.Invoke(true, sb.ToString());
                        continue;
                    }
                    TimeoutEvent?.Invoke(false, "");
                }

                Logger.Log(Logger.LogEnums.Verbose, "Timeout watchdog ended.");
            });
        }

        /// <summary>
        /// Unload all credentials.
        /// </summary>
        internal static void Unload() {
            if (!_isInitialized)
                return;
            token?.Dispose();
            Librarian = null;
            Logger.Log(Logger.LogEnums.Info, "Tokens unloaded.");
            _isInitialized = false;
        }

        /// <summary>
        /// Attempt to logged in as librarian.
        /// </summary>
        /// <returns></returns>
        internal static void LoginAsLibrarian() {
            lock (_lock) {
                while (true) {
                    if (!CheckPresence()) {
                        Logger.Log(Logger.LogEnums.Warn, "No presence of LibCheck credentials. Proceed to register.");
                        using (RegisterLib rLib = new RegisterLib()) {
                            if (rLib.ShowDialog() == DialogResult.Yes) {
                                LoadLibCCred();
                                continue;
                            }
                        }
                        break;
                    }
                    SecureDesktop.EnterSecureMode(() => new Login().ShowDialog());
                    break;
                }
            }
        }

        internal static void UpdateLibrarianInfo(LibrarianInfo token) {
            if (!LoggedIn || !AppContext.IsInAdminMode)
                throw new InvalidOperationException("Access denied.");
            Database.Database.Update(token);
            Librarian = token;
        }

        internal static void Register(LibrarianToken token, LibrarianInfo lInfo, SecureString key) {
            if (LoggedIn)
                throw new InvalidOperationException("Access denied.");

            PleaseWait.SetPWDText("Setting up database...");
            string dbPath = Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite");

            SQLiteConnectionString connStr = new SQLiteConnectionString(dbPath, false, key: token.SQLCipherDBKey);
            using (SQLiteConnection conn = new SQLiteConnection(connStr)) {
                conn.CreateTable<LibrarianInfo>();
                conn.CreateTable<Books>();
                conn.CreateTable<Students>();
                conn.CreateTable<EmailQueue>();
                conn.CreateTable<RecentEmail>();
                conn.CreateTable<Records>();
                conn.CreateTable<Notifs>();
                conn.CreateTable<PrintQueue>();

                conn.Insert(lInfo);
            }
            Logger.Log(Logger.LogEnums.Info, "Main database created.");

            PleaseWait.SetPWDText("Saving credentials...");
            string encryptedStr = CryptComp.StringCrypt(token.SQLCipherDBKey,
                                                          Encoding.UTF8.GetBytes(key.ConvertToString()),
                                                          Convert.FromBase64String(token.SQLCipherDBKeySalt));
            token.SQLCipherDBKey = encryptedStr;

            FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"));
            using (StreamWriter sw = new StreamWriter(f.FullName)) {
                using (JsonTextWriter writer = new JsonTextWriter(sw)) {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(writer, token);
                    writer.Flush();
                    Logger.Log(Logger.LogEnums.Info, "Credentials written.");
                }
            }
            token.Dispose();
            PleaseWait.SetPWDText("Done.");
            Notifs.CreateNotification("Welcome to LibCheck!", ":D");
        }

        /// <summary>
        /// Login as librarian.
        /// </summary>
        /// <param name="username">A provided username string.</param>
        /// <param name="password">A provided password string.</param>
        /// <exception cref="InvalidOperationException"></exception>
        internal static bool Login(string username, string password) {
            try {
                if (token == null)
                    throw new InvalidOperationException("Credential is not loaded.");
                if (LoggedIn)
                    throw new InvalidOperationException("Already logged in.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return false;
            }

            SecureString sqlKey = new SecureString();

            try {
                if (!Authenticate(username, password)) return false;
                string sqlKeyUnsafe = CryptComp.StringCrypt(token.SQLCipherDBKey,
                                                              Encoding.UTF8.GetBytes(password),
                                                              Convert.FromBase64String(token.SQLCipherDBKeySalt),
                                                              false);

                GCHandle handler = GCHandle.Alloc(sqlKeyUnsafe, GCHandleType.Pinned);
                for (int i = 0; i < sqlKeyUnsafe.Length; i++)
                    sqlKey.AppendChar(sqlKeyUnsafe[i]);
                ZeroMemory(handler.AddrOfPinnedObject(), sqlKey.Length * 2);
                handler.Free();

                Database.Database.Load(sqlKey);

                if (Database.Database.Read(out List<LibrarianInfo>? l) != 1 || l == null) {
                    CrashControl.SCRAM(new InvalidOperationException("Corrupted information found!"));
                    return false;
                }
                Librarian = l[0];

                LoggedIn = true;
                Logger.Log(Logger.LogEnums.Info, "Login successful.");
                return true;
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to login. {ex.Message}");
                return false;
            } finally {
                sqlKey.Dispose();
            }
        }

        internal static bool Authenticate(string password) {
            string username;
            try {
                if (!LoggedIn || Librarian == null)
                    throw new InvalidOperationException("Access denied.");

                if (string.IsNullOrEmpty(Librarian.Username))
                    throw new InvalidOperationException("Data corruption detected.");

                username = Librarian.Username;
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return false;
            }
            return Authenticate(username, password);
        }

        private static bool Authenticate(string username, string password) {
            try {
                if (token == null)
                    throw new InvalidOperationException("Credential is not loaded.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return false;
            }

            byte[] salt = Convert.FromBase64String(token.Salt);
            string provUserHash = CryptComp.HashPassword(username, salt);
            string provPassHash = CryptComp.HashPassword(password, salt);
            if (!provUserHash.Equals(token.Username) || !provPassHash.Equals(token.Hash)) {
                Penalize();
                return false;
            }

            retries = 0; // Reset since the librarian logged in.
            incrementTimer = 0;
            return true;
        }

        internal static void SetLastLoggedIn() {
            if (Librarian == null || !LoggedIn || !AppContext.IsInAdminMode) return;
            Librarian.LastLoggedIn = DateTime.Now;
            Database.Database.Update(Librarian);
        }
        private static void Penalize() {
            retries++;
            if (retries >= 5) {
                Logger.Log(Logger.LogEnums.Error, $"Multiple authentication attempts occurred.");
                incrementTimer += 30;
                expTime = DateTime.Now.AddSeconds(incrementTimer);
            }
        }

        internal static void ChangePassword(string password, string newPassword) {
            if (!LoggedIn || string.IsNullOrEmpty(Librarian?.Username))
                throw new InvalidOperationException("Access denied.");
            try {
                if (token == null)
                    throw new InvalidOperationException("Credential is not loaded.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return;
            }

            byte[] salt = Convert.FromBase64String(token.Salt);
            string provPassHash = CryptComp.HashPassword(password, salt);
            if (!provPassHash.Equals(token.Hash))
                throw new InvalidOperationException("Password is invalid.");

            if (provPassHash.Equals(CryptComp.HashPassword(newPassword, salt)))
                throw new InvalidOperationException("Password is the same as the previous one.");

            byte[] newSalt = CryptComp.GenerateRNGBytes();
            string sqlKeyUnsafe = CryptComp.StringCrypt(token.SQLCipherDBKey,
                                                             Encoding.UTF8.GetBytes(password),
                                                             Convert.FromBase64String(token.SQLCipherDBKeySalt),
                                                             false);
            GCHandle handler = GCHandle.Alloc(sqlKeyUnsafe, GCHandleType.Pinned);

            LibrarianToken newToken = new LibrarianToken {
                Username = CryptComp.HashPassword(Librarian.Username, newSalt),
                Salt = Convert.ToBase64String(newSalt),
                Hash = CryptComp.HashPassword(newPassword, newSalt),
                SQLCipherDBKey = CryptComp.StringCrypt(sqlKeyUnsafe,
                                                             Encoding.UTF8.GetBytes(newPassword),
                                                             Convert.FromBase64String(token.SQLCipherDBKeySalt)),
                SQLCipherDBKeySalt = token.SQLCipherDBKeySalt
            };

            ZeroMemory(handler.AddrOfPinnedObject(), sqlKeyUnsafe.Length * 2);
            handler.Free();

            FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"));
            using (StreamWriter sw = new StreamWriter(f.FullName)) {
                using (JsonTextWriter writer = new JsonTextWriter(sw)) {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(writer, newToken);
                    writer.Flush();
                    Logger.Log(Logger.LogEnums.Info, "Credentials re-written due to changed password.");
                }
            }

            token.Dispose();
            token = newToken;
        }

        internal static void EmergencyChangePassword(string username, string newPassword, string SQLKey) {
            if (LoggedIn || !RecoveryCodesCenter.IsByPassed)
                throw new InvalidOperationException("Access denied.");

            try {
                if (token == null)
                    throw new InvalidOperationException("Credential is not loaded.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return;
            }

            byte[] newSalt = CryptComp.GenerateRNGBytes();
            byte[] newSQLSalt = CryptComp.GenerateRNGBytes();

            LibrarianToken newToken = new LibrarianToken {
                Username = CryptComp.HashPassword(username, newSalt),
                Salt = Convert.ToBase64String(newSalt),
                Hash = CryptComp.HashPassword(newPassword, newSalt),
                SQLCipherDBKey = CryptComp.StringCrypt(SQLKey,
                                                             Encoding.UTF8.GetBytes(newPassword),
                                                             newSQLSalt),
                SQLCipherDBKeySalt = Convert.ToBase64String(newSQLSalt)
            };

            FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"));
            using (StreamWriter sw = new StreamWriter(f.FullName)) {
                using (JsonTextWriter writer = new JsonTextWriter(sw)) {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(writer, newToken);
                    writer.Flush();
                    Logger.Log(Logger.LogEnums.Info, "Credentials re-written due to account recovery.");
                }
            }

            token.Dispose();
            token = newToken;
        }

        /// <summary>
        /// Load the credentials.
        /// </summary>
        private static void LoadLibCCred() {
            using (StreamReader stream = new StreamReader(Path.Combine(EnvVars.CredentialsInfo.FullName,
                                                          "lc_cred.json"))) {
                using (JsonTextReader reader = new JsonTextReader(stream)) {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    token = serializer.Deserialize<LibrarianToken>(reader);
                    Logger.Log(Logger.LogEnums.Verbose, "Token loaded.");
                }
            }
        }

        /// <summary>
        /// Checks whether the login is in halt.
        /// </summary>
        /// <returns>Returns whether the login is in halt.</returns>
        private static bool IsInHaltPhase() {
            if (retries < 5)
                return false;
            if (DateTime.Now < expTime)
                return true;
            retries = 0;
            return false;
        }

        /// <summary>
        /// Checks the presence of a credentials and the database.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static bool CheckPresence() {
            try {
                FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"));
                if (!f.Exists || f.Length == 0) {
                    if (File.Exists(Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite")))
                        throw new InvalidOperationException("Database exists but no credentials.");
                    return false;
                }
                if (!File.Exists(Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite")))
                    throw new InvalidOperationException("Credentials exists but no database.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
            }
            return true;
        }
    }
}
