using LibCheck.Modules;

namespace LibCheck.Forms {
    public partial class AuthenticateDiag : Form {
        public AuthenticateDiag() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(passwordTextBox.Text)) {
                    MessageBox.Show(this, "Please provide the credentials.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Credentials.Authenticate(passwordTextBox.Text);
                DialogResult = DialogResult.Yes;
                Close();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
