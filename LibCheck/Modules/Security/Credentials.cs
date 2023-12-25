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
        private static bool _isInitialized = false;
        private static readonly object _lock = new object();
        private static LibrarianToken? token;
        private static DateTime expTime = DateTime.Now;
        private static int retries = 0;
        private static int incrementTimer = 0;

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
                    SecureDesktop.EnterSecureMode(() => {
                        new Login().ShowDialog();
                    });
                    break;
                }
            }
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
                conn.CreateTable<Records>();
                conn.Insert(lInfo);
            }

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
                }
            }
            token.Dispose();
            PleaseWait.SetPWDText("Done.");
        }

        /// <summary>
        /// Login as librarian.
        /// </summary>
        /// <param name="username">A provided username string.</param>
        /// <param name="password">A provided password string.</param>
        /// <exception cref="InvalidOperationException"></exception>
        internal static void Login(string username, string password) {
            try {
                if (token == null)
                    throw new InvalidOperationException("Credential is not loaded.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return;
            }

            if (LoggedIn)
                throw new InvalidOperationException("Already logged in.");

            SecureString sqlKey = new SecureString();

            try {
                Authenticate(username, password);
                string sqlKeyUnsafe = CryptComp.StringCrypt(token.SQLCipherDBKey,
                                                              Encoding.UTF8.GetBytes(password),
                                                              Convert.FromBase64String(token.SQLCipherDBKeySalt),
                                                              false);

                GCHandle handler = GCHandle.Alloc(sqlKeyUnsafe, GCHandleType.Pinned);
                for (int i = 0; i < sqlKeyUnsafe.Length; i++)
                    sqlKey.AppendChar(sqlKeyUnsafe[i]);
                ZeroMemory(handler.AddrOfPinnedObject(), sqlKey.Length * 2);
                handler.Free();

                Database.Load(sqlKey);

                IEnumerable<LibrarianInfo>? infos = Database.Connection?
                                                   .Query<LibrarianInfo>("SELECT * FROM LibrarianInfo");
                if (infos == null || infos.Count() != 1) {
                    CrashControl.SCRAM(new InvalidOperationException("Corrupted information found!"));
                    return;
                }
                Librarian = infos.Take(1).ToArray()[0];

                LoggedIn = true;
                Logger.Log(Logger.LogEnums.Info, "Login successful.");
            } finally {
                sqlKey.Dispose();
            }
        }

        internal static void Authenticate(string password) {
            if (!LoggedIn || Librarian == null)
                throw new InvalidOperationException("Access denied.");

            string username = "";
            try {
                if (string.IsNullOrEmpty(Librarian.Username))
                    throw new InvalidOperationException("Data corruption detected.");
                username = Librarian.Username;
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
            }
            Authenticate(username, password);
        }

        private static void Authenticate(string username, string password) {
            try {
                if (token == null)
                    throw new InvalidOperationException("Credential is not loaded.");
            } catch (Exception ex) {
                CrashControl.SCRAM(ex);
                return;
            }

            if (IsInHaltPhase())
                throw new InvalidOperationException($"You cannot authenticate for a meantime.\nHalt Expiration {expTime:dd/MM/yyyy hh:mm tt}");

            try {
                byte[] salt = Convert.FromBase64String(token.Salt);
                string provUserHash = CryptComp.HashPassword(username, salt);
                string provPassHash = CryptComp.HashPassword(password, salt);
                if (!provUserHash.Equals(token.Username))
                    throw new InvalidOperationException("Username is invalid.");
                if (!provPassHash.Equals(token.Hash))
                    throw new InvalidOperationException("Password is invalid.");

                retries = 0; // Reset since the librarian logged in.
            } catch (Exception) {
                retries++;
                if (retries >= 5) {
                    incrementTimer += 30;
                    expTime = DateTime.Now.AddSeconds(incrementTimer);
                    throw new InvalidOperationException("You've logged in too many times. Please retry again later.");
                }
                throw;
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

            FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"));
            using (StreamWriter sw = new StreamWriter(f.FullName)) {
                using (JsonTextWriter writer = new JsonTextWriter(sw)) {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(writer, newToken);
                    writer.Flush();
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
                }
            }

            token.Dispose();
            token = newToken;
        }

        /// <summary>
        /// Load the credentials.
        /// </summary>
        private static void LoadLibCCred() {
            using (StreamReader stream = new StreamReader(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"))) {
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
