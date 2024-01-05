using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms.Admin {
    public partial class AccountRecoveryDiag : Form {
        public AccountRecoveryDiag() {
            InitializeComponent();
        }

        private void AccountRecoveryDiag_Load(object sender, EventArgs e) {
            WriteInfos();
            Logger.Log(Logger.LogEnums.Verbose, $"{GetType().Name} info loaded.");
        }

        private void WriteInfos() {
            if (RecoveryCodesCenter.Count > 0) {
                label1.Text = $"Currently, there are {RecoveryCodesCenter.Count} codes that are active to use for recovery.";
                return;
            }
            label1.Text = "There are no codes that are previously generated. Click 'Generate' to create a new one.";
        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            if (RecoveryCodesCenter.Count > 0 &&
                MessageBox.Show(this, "Creating another recovery codes will discard the previous codes. Continue?",
                                                                 "", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            PleaseWait.RunInPleaseWait(this, new Action(() => {
                try {
                    PleaseWait.SetPWDText("Generating code...");
                    string[] res = RecoveryCodesCenter.Generate();
                    PleaseWait.SetPWDText("Done.");

                    Task.Factory.StartNew(() => {
                        Invoke(new Action(() => {
                            new SaveCodeDialog(res).ShowDialog(this);
                            WriteInfos();
                        }));
                    });

                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, $"Failed to generate recovery codes. ({ex.Message})");
                    MessageBox.Show(this, $"Failed to generate recovery.\nCause: {ex.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }));
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            if (RecoveryCodesCenter.Count == 0) return;
            if (MessageBox.Show(this, "Do you want to remove all recovery codes? This will prevent you from recovering when you forget password.",
                                "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;
            PleaseWait.RunInPleaseWait(this, new Action(() => {
                try {
                    PleaseWait.SetPWDText("Clearing recovery codes...");
                    RecoveryCodesCenter.Clear();
                    PleaseWait.SetPWDText("Done.");
                    Invoke(new Action(() => WriteInfos()));
                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, $"Failed to clear recovery codes. ({ex.Message})");
                    MessageBox.Show(this, $"Failed to clear recovery.\nCause: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }));
        }
    }
}
