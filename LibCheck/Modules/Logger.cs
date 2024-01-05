using SQLite;

namespace LibCheck.Modules {

    /// <summary>
    /// A class that purpose to log the current session of a program.
    /// </summary>
    internal static class Logger {
        private static SQLiteConnection? conn = null;

        internal static bool CurrentLog { get => conn != null; }
        /// <summary>
        /// An enumeration of the log level.
        /// </summary>
        internal enum LogEnums {
            Verbose,
            Info,
            Warn,
            Error,
            Fatal
        }

        /// <summary>
        /// Initialize the logger.
        /// </summary>
        internal static void Initialize() {
            if (CurrentLog) return;
            FileInfo f = new FileInfo(Path.Combine(EnvVars.MainPath.FullName, "lclog.sqlite"));

            bool firstCreated = false;
            if (!f.Exists) {
                firstCreated = true;
                f.Create().Close();
            }
            conn = new SQLiteConnection(f.FullName);
            if (firstCreated)
                conn.CreateTable<Logs>();

            Log(LogEnums.Info, "Log started.");
        }

        /// <summary>
        /// Unload and save the current log.
        /// </summary>
        internal static void Unload() {
            if (CurrentLog) return;
            Log(LogEnums.Info, "Log closed.");
            conn?.Dispose();
            conn = null;
        }

        /// <summary>
        /// Write the information to the logger.
        /// </summary>
        /// <param name="logType">A log level of the message.</param>
        /// <param name="msg">A message string.</param>
        /// <exception cref="NotImplementedException"></exception>
        internal static void Log(LogEnums logType, string msg) {
            if (!CurrentLog) return;

            conn?.Insert(new Logs() {
                Date = DateTime.Now,
                Level = logType,
                Message = msg
            });
        }

        internal static List<Logs>? AcquireLog() {
            if (!CurrentLog) return new List<Logs>();
            return conn?.Query<Logs>("SELECT * FROM Logs").ToList();
        }

        internal static void ClearLog() {
            if (!CurrentLog) return;
            conn?.DeleteAll<Logs>();
        }

        internal class Logs {
            [PrimaryKey, NotNull]
            public DateTime Date { get; set; }

            [NotNull]
            public LogEnums Level { get; set; }

            [NotNull]
            public string? Message { get; set; }
        }
    }
}
