using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text)) {
                    MessageBox.Show(this, "Please provide the credentials.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Credentials.Login(usernameTextBox.Text, passwordTextBox.Text);
                if (Credentials.LoggedIn)
                    Close();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e) {
            LoginButton.Enabled = !string.IsNullOrEmpty(usernameTextBox.Text) && passwordTextBox.Text.Length >= 8;
        }

        private void linkForgorPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (RecoveryCodesCenter.Count == 0) {
                MessageBox.Show(this, "Unable to recover as this account doesn't have a recovery codes before. :(",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            new ForgotPasswordDiag().ShowDialog(this);
        }
    }
}
