namespace LibCheck.Modules {
    internal static class Credentials {
        private static bool _isInitialized = false;
        private static readonly object _lock = new object();
        internal static void Initialize() {
            if (_isInitialized)
                throw new InvalidOperationException("Credentials already initialized.");
            if (!EnvVars.CredentialsInfo.Exists) {
                EnvVars.CredentialsInfo.Create();
                throw new InvalidOperationException("No credentials were loaded.");
            }

            _isInitialized = true;
        }

        internal static bool LoginAsLibrarian() {
            lock (_lock) {
                switch (CheckLibrarianPresence()) {
                    case 0:
                        // Assume for the librarian sign in.
                        SecureDesktop.EnterSecureMode(new Action(() => {
                            MessageBox.Show("Sign up!");
                        }));
                         return true;
                    case 1:
                        // Login
                        MessageBox.Show("Log in");
                        return true;
                    default:
                        throw new InvalidOperationException("Failed to identify.");
                }
            }
        }

        private static int CheckLibrarianPresence() {
            return Database.Count("SELECT COUNT(*) FROM admin");
        }
    }
}
