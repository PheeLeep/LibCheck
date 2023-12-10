namespace LibCheck.Modules {

    /// <summary>
    /// A class that supplied with the environment variables loaded.
    /// </summary>
    internal static class EnvVars {
        private static readonly string _mainPath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// A <see cref="DirectoryInfo"/> containing the credentials path.
        /// </summary>
        internal static DirectoryInfo CredentialsInfo {
            get => new DirectoryInfo(Path.Combine(_mainPath, "creds"));
        }

        /// <summary>
        /// A <see cref="DirectoryInfo"/> containing the main path of the program.
        /// </summary>
        internal static DirectoryInfo MainPath {
            get => new DirectoryInfo(_mainPath);
        }

        /// <summary>
        /// A <see cref="DirectoryInfo"/> containing the crash logs folder.
        /// </summary>
        internal static DirectoryInfo CrashDirectory {
            get => new DirectoryInfo(Path.Combine(_mainPath, "crash"));
        }

        /// <summary>
        /// A <see cref="DirectoryInfo"/> containing the crash logs folder.
        /// </summary>
        internal static DirectoryInfo LogsDirectory {
            get => new DirectoryInfo(Path.Combine(_mainPath, "logs"));
        }
    }
}

