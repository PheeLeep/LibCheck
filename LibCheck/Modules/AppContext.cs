using LibCheck.Forms;
using LibCheck.Modules.Security;

namespace LibCheck.Modules {
    internal class AppContext : ApplicationContext {

        internal static bool IsInAdminMode { get; private set; } = false;

        private AdminForm? _adminForm;
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
            USBAccRec.Load();
            Logger.Initialize();
            Credentials.Initialize();
            Credentials.LoginAsLibrarian();

            if (!Credentials.LoggedIn) {
                Environment.Exit(0);
                return;
            }

            if (Database.Connection == null)
                throw new InvalidOperationException("Database is not connected.");

            _mainForm = new MainForm();
            _mainForm.Show();
        }

        internal bool Switch() {
            if (!IsInAdminMode) {
                SecureDesktop.EnterSecureMode(() => {
                    IsInAdminMode = new AuthenticateDiag().ShowDialog() == DialogResult.Yes;
                });
                if (IsInAdminMode) {
                    _adminForm = new AdminForm();
                    _adminForm.FormClosing += (s, e) => {
                        _adminForm = null;
                    };
                    MainForm = _adminForm;
                    _mainForm?.Close();
                    _mainForm = null;
                    _adminForm.Show();
                    return true;
                }
                return false;
            }
            IsInAdminMode = false;
            _mainForm = new MainForm();
            MainForm = _mainForm;
            _mainForm.Show();
            return true;
        }
        private void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            CrashControl.SCRAM(e.Exception);
        }

        private void Application_ApplicationExit(object? sender, EventArgs e) {
            Database.Unload();
            Credentials.Unload();
            USBAccRec.Unload();
        }
    }
}
