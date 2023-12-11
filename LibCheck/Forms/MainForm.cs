using LibCheck.Modules.Security;

namespace LibCheck.Forms
{
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
                if (adminForm.WindowState == FormWindowState.Minimized)
                    adminForm.WindowState = FormWindowState.Normal;
                adminForm.BringToFront();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (adminForm != null) {
                if (MessageBox.Show(this, "An admin page is still open. Do you want to close it anyway?", 
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
                adminForm.Close();
            }
        }
    }
}
