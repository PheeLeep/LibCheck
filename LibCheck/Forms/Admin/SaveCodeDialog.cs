using LibCheck.Modules;

namespace LibCheck.Forms.Admin {
    public partial class SaveCodeDialog : Form {

        private readonly string[] codes;
        private bool _isSaved = false;

        public SaveCodeDialog(string[] codes) {
            InitializeComponent();
            this.codes = codes;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            try {
                if (SFD.ShowDialog(this) != DialogResult.OK) return;

                using (StreamWriter writer = new StreamWriter(SFD.FileName)) {
                    writer.WriteLine("This is a list of codes that is used for account recovery in LibCheck.");
                    writer.WriteLine("[PLEASE KEEP THIS IN SECRET LOCATION!!!]\n");
                    writer.WriteLine("Codes:\n");
                    foreach (string code in codes)
                        writer.WriteLine(code);
                    writer.Flush();
                }

                Logger.Log(Logger.LogEnums.Info, "Account recovery code were saved.");
                MessageBox.Show(this, "Codes are saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!_isSaved) _isSaved = true;
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to save codes. ({ex.Message})");
                MessageBox.Show(this, $"Failed to save.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void SaveCodeDialog_Load(object sender, EventArgs e) {
            listBox1.Items.AddRange(codes);
        }

        private void SaveCodeDialog_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_isSaved && MessageBox.Show(this,
                                             "It is recommended to save those codes for you to quickly recover " +
                                             "in case of forgetting a password. Continue anyway?",
                                             "", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation) == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}
