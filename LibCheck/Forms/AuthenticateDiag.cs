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

        private void AuthenticateDiag_Load(object sender, EventArgs e) {
            Credentials.TimeoutEvent += Credentials_TimeoutEvent;
        }

        private void Credentials_TimeoutEvent(bool isInLocked, string? info) {
            try {
                Invoke(new Action(() => {
                    if (!string.IsNullOrWhiteSpace(info)) {
                        label3.Text = info;
                        passwordTextBox.Enabled = !isInLocked;
                        LoginButton.Enabled = !isInLocked;
                        return;
                    }
                    passwordTextBox.Enabled = true;
                    label3.Text = "Please enter your password for authentication:";
                }));
            } catch {
                // Ignore
            }
        }

        private void AuthenticateDiag_FormClosing(object sender, FormClosingEventArgs e) {

            Credentials.TimeoutEvent -= Credentials_TimeoutEvent;
        }
    }
}
