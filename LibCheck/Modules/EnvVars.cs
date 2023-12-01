namespace LibCheck.Modules {
    internal static class EnvVars {
        private static readonly string _mainPath = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string _credPath = Path.Combine(_mainPath, "creds");

        internal static DirectoryInfo CredentialsInfo {
            get => new DirectoryInfo(_credPath);
        }

        internal static DirectoryInfo MainPath {
            get => new DirectoryInfo(_mainPath);
        }
    }
}

