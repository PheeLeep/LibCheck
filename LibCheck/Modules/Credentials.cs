using LibCheck.Forms;

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
                while (true) {
                    if (!CheckPresence()) {
                        using (RegisterLib rLib = new RegisterLib()) {
                            if (rLib.ShowDialog() == DialogResult.Yes)
                                continue;
                        }
                        return false;
                    }
                    MessageBox.Show("Log in");
                    return true;
                }
            }
        }

        private static bool CheckPresence() {
            FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "lc_cred.json"));
            if (!f.Exists || f.Length == 0) return false;
            return true;
        }
    }
}
