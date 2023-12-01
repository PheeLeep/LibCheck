namespace LibCheck.Modules {
    internal static class Credentials {
        private static bool _isInitialized = false;

        internal static void Initialize() {
            if (_isInitialized)
                throw new InvalidOperationException("Credentials already initialized.");
            if (!EnvVars.CredentialsInfo.Exists) {
                EnvVars.CredentialsInfo.Create();
                throw new InvalidOperationException("No credentials were loaded.");
            }

            _isInitialized = true;
        }


    }
}
