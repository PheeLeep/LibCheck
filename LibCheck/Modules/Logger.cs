namespace LibCheck.Modules {

    /// <summary>
    /// A class that purpose to log the current session of a program.
    /// </summary>
    internal static class Logger {
        private static StreamWriter? sw;

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
            if (sw != null) return;
            if (!EnvVars.LogsDirectory.Exists)
                EnvVars.LogsDirectory.Create();
            sw = new StreamWriter(Path.Combine(EnvVars.LogsDirectory.FullName, $"logs_{DateTime.Now:ddMMyyyy-hhmmss-tt}.txt")) {
                AutoFlush = true
            };
            Log(LogEnums.Info, "Log started.");
        }

        /// <summary>
        /// Unload and save the current log.
        /// </summary>
        internal static void Unload() {
            if (sw == null) return;
            Log(LogEnums.Info, "Log closed.");
            sw?.Close();
            sw = null;
        }

        /// <summary>
        /// Write the information to the logger.
        /// </summary>
        /// <param name="logType">A log level of the message.</param>
        /// <param name="msg">A message string.</param>
        /// <exception cref="NotImplementedException"></exception>
        internal static void Log(LogEnums logType, string msg) {
            if (sw == null) return;
            string typeStr = logType switch {
                LogEnums.Verbose => "[VERBOSE]",
                LogEnums.Info => "[INFO]",
                LogEnums.Warn => "[WARN]",
                LogEnums.Error => "[ERROR]",
                LogEnums.Fatal => "[X]",
                _ => throw new NotImplementedException()
            };

            sw?.WriteLine($"[{DateTime.Now:dd/MM/yyyy hh:mm:ss tt}]{typeStr}: {msg}");
        }
    }
}
