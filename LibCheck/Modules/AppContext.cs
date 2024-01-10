using LibCheck.Forms;
using LibCheck.Modules.Security;

namespace LibCheck.Modules {
    internal class AppContext : ApplicationContext {

        internal static bool IsInAdminMode { get; private set; } = false;

        private MainForm? _mainForm;
        private static AppContext? _currentContext;

        internal static AppContext Current {
            get {
                _currentContext ??= new AppContext();
                return _currentContext;
            }
        }

        internal AppContext() {
            Application.ApplicationExit += Application_ApplicationExit;
            Application.ThreadException += Application_ThreadException;
            RecoveryCodesCenter.Load();
            Logger.Initialize();
            Credentials.Initialize();
            Credentials.LoginAsLibrarian();

            if (!Credentials.LoggedIn) {
                Logger.Log(Logger.LogEnums.Info, "Failed to login. Exiting...");
                Environment.Exit(0);
                return;
            }

            if (!Database.Database.IsConnected)
                throw new InvalidOperationException("Database is not connected.");

            _mainForm = new MainForm();
            MainForm = _mainForm;
            _mainForm.Show();
        }

        internal static bool Auth() {
            bool isAuth = false;
            SecureDesktop.EnterSecureMode(() => {
                isAuth = new AuthenticateDiag().ShowDialog() == DialogResult.Yes;
            });
            return isAuth;
        }

        internal bool Switch() {
            if (!IsInAdminMode) {
                IsInAdminMode = Auth();

                if (IsInAdminMode) {
                    AdminForm? _adminForm = new AdminForm();
                    _adminForm.FormClosing += (s, e) => {
                        _adminForm = null;
                    };
                    MainForm = _adminForm;
                    _mainForm?.Close();
                    _mainForm = null;
                    _adminForm.Show();
                    Logger.Log(Logger.LogEnums.Info, "Context switched to admin mode.");
                    return true;
                }
                return false;
            }

            IsInAdminMode = false;
            _mainForm = new MainForm();
            MainForm = _mainForm;
            _mainForm.Show();
            Logger.Log(Logger.LogEnums.Info, "Context switched to normal mode.");
            return true;
        }
        private void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            Logger.Log(Logger.LogEnums.Fatal, "An unhandled exception occurred! A scram will perform immediately." +
                                              $" (E:{e.Exception.HResult:X})");
            CrashControl.SCRAM(e.Exception);
        }

        private void Application_ApplicationExit(object? sender, EventArgs e) {
            EmailService.Unload();
            Database.Database.Unload();
            Credentials.Unload();
            RecoveryCodesCenter.Unload();
        }
    }
}
