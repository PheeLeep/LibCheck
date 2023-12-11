using LibCheck.Modules.Security;

namespace LibCheck.Forms.Admin {
    public partial class ChangePasswordDiag : Form {
        public ChangePasswordDiag() {
            InitializeComponent();
        }

        private void passwordTextBoxes_TextChanged(object sender, EventArgs e) {
            ChangeButton.Enabled = oldPassTextBox.Text.Length >= 8 && newPassTextBox.Text.Length >= 8 && retypePassTextBox.Text.Length >= 8;
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            try {
                if (!newPassTextBox.Text.Equals(retypePassTextBox.Text))
                    throw new InvalidOperationException("New and retype passwords are not matched.");
                Credentials.ChangePassword(oldPassTextBox.Text, newPassTextBox.Text);
                MessageBox.Show(this, "Password changed.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Close();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Failed to change password.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
