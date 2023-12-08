using SQLite;

namespace LibCheck.Modules {
    internal static class Database {

        internal static SQLiteConnection? Connection { get; private set; }
        private static readonly object _locker = new object();

        internal static void Load() {
            lock (_locker) {
                string dbPath = Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite");
                if (!File.Exists(dbPath))
                    throw new FileNotFoundException("Database file was not found!");
                if (Connection != null)
                    return;
                Connection = new SQLiteConnection(dbPath);
            }
        }

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
