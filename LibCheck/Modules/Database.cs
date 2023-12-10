using LibCheck.Modules.Security;
using SQLite;
using System.Security;

namespace LibCheck.Modules {
    /// <summary>
    /// A basic class containing the database functions.
    /// </summary>
    internal static class Database {

        /// <summary>
        /// Get the current connection of the SQLCipher.
        /// </summary>
        internal static SQLiteConnection? Connection { get; private set; }
        private static readonly object _locker = new object();

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
                if (Connection != null)
                    return;
                SQLiteConnectionString connStr = new SQLiteConnectionString(dbPath, false, key: CryptComp.ConvertToString(secString));
                Connection = new SQLiteConnection(connStr);
            }
        }

        /// <summary>
        /// Unloads the database.
        /// </summary>
        internal static void Unload() {
            lock (_locker) {
                if (Connection == null)
                    return;
                Connection?.Close();
                Connection = null;
            }
        }
    }
}
