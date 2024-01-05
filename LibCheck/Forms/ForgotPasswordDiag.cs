using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class ForgotPasswordDiag : Form {
        public ForgotPasswordDiag() {
            InitializeComponent();
        }

        private void passwordTextBoxes_TextChanged(object sender, EventArgs e) {
            RecoverButton.Enabled = recoveryTextBox.Text.Length == 6
                                    && newPassTextBox.Text.Length >= 8
                                    && retypePassTextBox.Text.Length >= 8;
        }
        // 186216
        private void RecoverButton_Click(object sender, EventArgs e) {
            if (!retypePassTextBox.Text.Equals(newPassTextBox.Text)) {
                MessageBox.Show(this, "Password don't match.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            PleaseWait.RunInPleaseWait(this, new Action(() => {
                PleaseWait.SetPWDText("Attempting to recover. Please wait...");
                bool res = RecoveryCodesCenter.Challenge(recoveryTextBox.Text, newPassTextBox.Text);
                Invoke(new Action(() => {
                    if (res) {
                        MessageBox.Show(this, "Account successfully recovered!", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                        return;
                    }
                    MessageBox.Show(this, "Failed to recover. Please try again.", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }));
            }));
        }
    }
}
