using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Diagnostics;

namespace LibCheck.Forms.Admin {
    public partial class LibrarianOptions : Form {

        private bool _isEdited = false;

        public LibrarianOptions() {
            InitializeComponent();
        }

        private void LibrarianOptions_Load(object sender, EventArgs e) {
            WriteInfos();
            LibrarianInfo? info = Credentials.Librarian;
            if (info != null) {
                UsernameLabel.Text = $"Username: {info.Username}";
                LastLoggedInLabel.Text = $"Last Logged In: {info.LastLoggedIn:dd/MM/yyyy hh:mm:ss tt}";
                SchoolNameLabel.Text = "A FOS Book Borrowing and Returning System made for the school " +
                                      $"\"{info.SchoolName}\"";
                PesoAccureTextBox.Text = info.FeePerOverdueDay.ToString();
                FNameTxtBox.Text = info.FirstName;
                MNameTxtBox.Text = info.MiddleName;
                LNameTxtBox.Text = info.LastName;
                BDatePicker.Value = info.BirthDate;
                GenderCBox.SelectedIndex = info.IsFemale ? 1 : 0;
                _isEdited = false;
            }
            Logger.Log(Logger.LogEnums.Verbose, $"{GetType().Name} info loaded.");
        }

        private void Controls_ValueChanged(object sender, EventArgs e) {
            if (!_isEdited) _isEdited = true;

        }

        private void NextButton_Click(object sender, EventArgs e) {
            Save();
        }

        private void ChangePassButton_Click(object sender, EventArgs e) {
            new ChangePasswordDiag().ShowDialog(this);
        }

        private void LibrarianOptions_FormClosing(object sender, FormClosingEventArgs e) {
            if (_isEdited) {
                switch (MessageBox.Show(this, "There is an unsaved changes. Do you want to save?", "",
                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                    case DialogResult.Yes:
                        if (!Save()) {
                            e.Cancel = true;
                            return;
                        }
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private bool Save() {
            try {
                LibrarianInfo? info = Credentials.Librarian;
                if (_isEdited && info != null) {
                    if (!Regexes.IsValidAlphanumSpace(FNameTxtBox.Text)) {
                        MessageBox.Show(this, "Invalid first name.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    if (!Regexes.IsValidAlphanumSpace(LNameTxtBox.Text)) {
                        MessageBox.Show(this, "Invalid last name.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    if (!string.IsNullOrEmpty(MNameTxtBox.Text) && !Regexes.IsValidAlphanumSpace(MNameTxtBox.Text)) {
                        MessageBox.Show(this, "Invalid middle name.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    if (!double.TryParse(PesoAccureTextBox.Text, out double payDue)) {
                        MessageBox.Show(this, "Input peso value is invalid.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }

                    LibrarianInfo lInfo = new LibrarianInfo {
                        Username = info.Username,
                        FirstName = FNameTxtBox.Text,
                        MiddleName = MNameTxtBox.Text,
                        LastName = LNameTxtBox.Text,
                        BirthDate = BDatePicker.Value,
                        IsFemale = GenderCBox.SelectedIndex == 1,
                        FeePerOverdueDay = payDue,
                        SchoolGUID = info.SchoolGUID,
                        SchoolName = info.SchoolName
                    };
                    Credentials.UpdateLibrarianInfo(lInfo);
                    _isEdited = false;
                    return true;
                }
                return false;
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to save info. ({ex.Message})");
                MessageBox.Show(this, $"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        // ---------------------- Account Recovery

        private void WriteInfos() {
            GenerateLabel.Text = RecoveryCodesCenter.Count > 0 ?
                                $"Currently, there are {RecoveryCodesCenter.Count} codes that are active to use for recovery." :
                                 "There are no codes that are previously generated. Click 'Generate' to create a new one.";
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

        private void RemoveCodesButton_Click(object sender, EventArgs e) {

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

        // ---------------------

        private void StartProcess(string link) {
            try {
                Process.Start(new ProcessStartInfo() {
                    FileName = link,
                    UseShellExecute = true
                });
            } catch (Exception ex) {
                MessageBox.Show(this, $"Failed to open a link.\n\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void PheeLeepLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            StartProcess("https://github.com/PheeLeep/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            StartProcess("https://github.com/PheeLeep/LibCheck");
        }

        private void MitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            StartProcess("https://github.com/PheeLeep/LibCheck/blob/master/LICENSE.txt");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            StartProcess("https://github.com/ajaxel8/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            StartProcess("https://github.com/CAMIILA0508/");
        }
    }
}
