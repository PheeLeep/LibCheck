using System.Data.SQLite;

namespace LibCheck.Modules {
    internal static class Database {

        private static SQLiteConnection? _connection;
        private static readonly object _locker = new object();
        internal static bool IsConnected {
            get {
                if (_connection == null)
                    return false;
                return _connection.State == System.Data.ConnectionState.Open || _connection.State == System.Data.ConnectionState.Executing;
            }
        }

        internal static void Load() {
            lock (_locker) {
                string dbPath = Path.Combine(EnvVars.MainPath.FullName, "libcheckdb.sqlite");
                if (!File.Exists(dbPath))
                    throw new FileNotFoundException("Database file was not found!");
                if (IsConnected)
                    return;
                _connection = new SQLiteConnection($"Data Source={dbPath};");
                _connection.Open();
            }
        }

        internal static void Unload() {
            lock (_locker) {
                if (!IsConnected)
                    return;
                _connection?.Close();
                _connection = null;
            }
        }

        internal static int Count(string cmd) {
            lock (_locker) {
                if (!IsConnected)
                    return -1;
                using (SQLiteCommand command = new SQLiteCommand(cmd)) {
                    command.Connection = _connection;
                    return int.TryParse(command.ExecuteScalar().ToString(), out int res) ? res : -1;
                }
            }
        }
    }
}
