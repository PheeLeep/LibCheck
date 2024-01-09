using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text)) {
                MessageBox.Show(this, "Please provide the credentials.", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Credentials.Login(usernameTextBox.Text, passwordTextBox.Text)) {
                MessageBox.Show(this, "Invalid username or password.", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Credentials.TimeoutEvent -= Credentials_TimeoutEvent;
            Close();
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

        private void Login_Load(object sender, EventArgs e) {
            Credentials.TimeoutEvent += Credentials_TimeoutEvent;
        }

        private void Credentials_TimeoutEvent(bool isInLocked, string? info) {
            try {
                Invoke(new Action(() => {
                    if (!string.IsNullOrWhiteSpace(info)) {
                        usernameTextBox.Enabled = !isInLocked;
                        passwordTextBox.Enabled = !isInLocked;
                        LoginButton.Enabled = !isInLocked;
                        label4.Visible = true;
                        label4.Text = info;
                        return;
                    }

                    usernameTextBox.Enabled = true;
                    passwordTextBox.Enabled = true;
                    label4.Visible = false;
                }));
            } catch {
                // Ignore
            }
        }
    }
}
