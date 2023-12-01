using System.Data.SQLite;

namespace LibCheck.Modules {
    internal static class Database {

        private static SQLiteConnection? _connection;

        internal static bool IsConnected {
            get {
                if (_connection == null)
                    return false;
                return _connection.State == System.Data.ConnectionState.Open || _connection.State == System.Data.ConnectionState.Executing;
            }
        }

        internal static void Load() {
            string dbPath = Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite");
            if (!File.Exists(dbPath))
                throw new FileNotFoundException("Database file was not found!");
            if (IsConnected)
                return;
            _connection = new SQLiteConnection($"Data Source={dbPath};");
            _connection.Open();
        }

        internal static void Unload() {
            if (!IsConnected)
                return;
            _connection?.Close();
            _connection = null;
        }
    }
}
