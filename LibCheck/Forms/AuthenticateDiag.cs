using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class AuthenticateDiag : Form {
        public AuthenticateDiag() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            if (!Credentials.Authenticate(passwordTextBox.Text)) {
                MessageBox.Show(this, "Invalid password.", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e) {
            LoginButton.Enabled = passwordTextBox.Text.Length >= 8;
        }
    }
}
