using LibCheck.Forms.Admin;
using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class AdminForm : Form {
        public AdminForm() {
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

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            new ChangePasswordDiag().ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            WelcomeLabel.Text = $"Welcome, {Credentials.Librarian?.Username}!";
        }
    }
}
