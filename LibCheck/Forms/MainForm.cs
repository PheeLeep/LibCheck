using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class MainForm : Form {

        private AdminForm? adminForm;
        private readonly object _lock = new object();

        public MainForm() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            WelcomeLabel.Text = $"Welcome, {Credentials.Librarian?.Username}!";
        }

        private void ShowAdminButton_Click(object sender, EventArgs e) {
            if (adminForm != null) {
                adminForm.Show();
                return;
            }
            bool isAuthenticated = false;
            SecureDesktop.EnterSecureMode(() => {
                isAuthenticated = new AuthenticateDiag().ShowDialog() == DialogResult.Yes;
            });
            if (isAuthenticated) {
                adminForm = new AdminForm();
                adminForm.FormClosing += (s, e) => {
                    adminForm.FormClosing -= (s, e) => { };
                    adminForm = null;
                };
                adminForm.Show();
            }
        }
    }
}
