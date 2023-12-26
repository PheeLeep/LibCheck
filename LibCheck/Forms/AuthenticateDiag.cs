using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class AuthenticateDiag : Form {
        public AuthenticateDiag() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            try {
                Credentials.Authenticate(passwordTextBox.Text);
                DialogResult = DialogResult.Yes;
                Close();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e) {
            LoginButton.Enabled = passwordTextBox.Text.Length >= 8;
        }
    }
}
