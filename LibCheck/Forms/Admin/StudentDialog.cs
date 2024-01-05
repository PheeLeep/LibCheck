using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin {
    public partial class StudentDialog : Form {

        private Students student = new Students();
        private bool _isEdited = false;
        private DatabaseMode mode;

        public StudentDialog(DatabaseMode mode, string studentID = "") {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.mode = mode;
            if (mode != DatabaseMode.Add) {
                if (string.IsNullOrWhiteSpace(studentID) ||
                    Database.Database.Read(out List<Students>? l, whereCond: $"StudentID = '{studentID}'") <= 0 ||
                    l == null)
                    throw new InvalidOperationException("No Student ID provided.");

                student = l[0];
            }
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void StudentDialog_Load(object sender, EventArgs e) {
            LevelComboBox.Items.AddRange(Levels);
            SuffixCombobox.SelectedIndex = 0;
            MaleRadioButton.Checked = true;
            DOBDatePicker.MaxDate = DateTime.Today;
            LevelComboBox.SelectedIndex = 0;

            if (mode == DatabaseMode.Read) {
                foreach (Control control in Controls) {
                    if (control is not GroupBox gb) continue;
                    foreach (Control c2 in gb.Controls) {
                        switch (c2) {
                            case Control c when c is TextBox txtbox:
                                txtbox.ReadOnly = true;
                                break;
                            case Control c when c is DateTimePicker dtp:
                                dtp.Enabled = false;
                                break;
                            case Control c when c is RadioButton rb:
                                rb.Enabled = false;
                                break;
                            case Control c when c is ComboBox cb:
                                cb.Enabled = false;
                                break;
                        }
                    }
                }
            }

            if (mode != DatabaseMode.Add) {
                StudIDTextBox.ReadOnly = true;
                StudIDTextBox.Text = student.StudentID;
                FirstNameTextBox.Text = student.FirstName;
                MiddleNameTextBox.Text = student.MiddleName;
                LastNameTextBox.Text = student.LastName;
                SetComboboxIndexByVal(SuffixCombobox, student.Suffix);

                (student.IsFemale ? FemaleRadioButton : MaleRadioButton).Checked = true;
                DOBDatePicker.Value = student.BirthDate;

                LevelComboBox.SelectedIndex = student.Level;
                GradeSecTextBox.Text = student.GradeSection;
                EmailAddressTextBox.Text = student.EmailAddress;
                ConfirmButton.Text = mode == DatabaseMode.Update ? "Update" : "OK";
                _isEdited = false;
            }
        }
        private void Controls_ValuesChanged(object sender, EventArgs e) {
            if (!_isEdited)
                _isEdited = true;
        }

        private void SetComboboxIndexByVal(ComboBox cb, string? val) {
            if (cb.Items.Count == 0 || string.IsNullOrWhiteSpace(val)) return;
            int idx = cb.Items.IndexOf(val);
            if (idx == -1) idx = 0;
            cb.SelectedIndex = idx;
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (_isEdited) {
                if (!CheckInformation()) return;
                bool isEmailChanged = false;

                if (mode == DatabaseMode.Update) {
                    if (!string.IsNullOrWhiteSpace(student.EmailAddress)
                        && !student.EmailAddress.Equals(EmailAddressTextBox.Text)
                        && MessageBox.Show(this, "Changing student's email address will discard the previous. Continue?",
                                        "Changing Email", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation) == DialogResult.No) {
                        EmailAddressTextBox.Text = student.EmailAddress;
                        return;
                    } else {
                        isEmailChanged = true;
                    }
                }

                student.StudentID = StudIDTextBox.Text;
                student.FirstName = FirstNameTextBox.Text;
                student.LastName = LastNameTextBox.Text;
                student.MiddleName = MiddleNameTextBox.Text;
                student.Suffix = SuffixCombobox.Items[SuffixCombobox.SelectedIndex].ToString();
                student.IsFemale = FemaleRadioButton.Checked;
                student.BirthDate = DOBDatePicker.Value;
                student.Level = LevelComboBox.SelectedIndex;
                student.GradeSection = GradeSecTextBox.Text;
                student.EmailAddress = EmailAddressTextBox.Text;


                if (!(mode == DatabaseMode.Add ? Database.Database.Insert(student)
                                               : Database.Database.Update(student))) {
                    Logger.Log(Logger.LogEnums.Error, "Failed to add/update student information.");
                    MessageBox.Show(this, "Failed to add or update student information.",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                Logger.Log(Logger.LogEnums.Info, "Student information is added/updated.");
                MessageBox.Show(this, "Student information is added/updated.", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                string body;

                if (mode == DatabaseMode.Add) {
                    body = Properties.Resources.AddEmailTxt.Replace("%school%", Credentials.Librarian?.SchoolName)
                                                           .Replace("%stID%", student.StudentID)
                                                           .Replace("%name%", GenerateFullName(student))
                                                           .Replace("%librarian%", GenerateFullName(Credentials.Librarian));
                    EmailService.Queue(student, body, "Welcome to LibCheck!");
                } else if (mode == DatabaseMode.Update && isEmailChanged) {
                    body = Properties.Resources.UpdateEmailTxt.Replace("%school%", Credentials.Librarian?.SchoolName)
                                                           .Replace("%stID%", student.StudentID)
                                                           .Replace("%name%", GenerateFullName(student))
                                                           .Replace("%librarian%", GenerateFullName(Credentials.Librarian));
                    EmailService.Queue(student, body, "Regarding to Email Update.");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool CheckInformation() {
            try {
                if (string.IsNullOrWhiteSpace(StudIDTextBox.Text)
                    || !Regexes.IsValidStudentID(StudIDTextBox.Text))
                    throw new InvalidOperationException("Invalid Student ID.");

                if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text)
                    || !Regexes.IsValidAlphanumSpace(FirstNameTextBox.Text))
                    throw new InvalidOperationException("Invalid First Name.");

                if (!string.IsNullOrWhiteSpace(MiddleNameTextBox.Text)
                    && !Regexes.IsValidAlphanumSpace(MiddleNameTextBox.Text))
                    throw new InvalidOperationException("Invalid Middle Name.");

                if (string.IsNullOrWhiteSpace(LastNameTextBox.Text)
                    || !Regexes.IsValidAlphanumSpace(LastNameTextBox.Text))
                    throw new InvalidOperationException("Invalid Last Name.");

                if (string.IsNullOrWhiteSpace(GradeSecTextBox.Text)
                    || !Regexes.IsValidAlphanumSpace(GradeSecTextBox.Text))
                    throw new InvalidOperationException("Invalid Grade and Section.");

                if (string.IsNullOrWhiteSpace(EmailAddressTextBox.Text)
                    || !Regexes.IsValidEmail(EmailAddressTextBox.Text, out _))
                    throw new InvalidOperationException("Invalid Email Address.");

                if (Database.Database.Read(out List<Students>? s, whereCond: $"EmailAddress = '{EmailAddressTextBox.Text}'") > 0
                    && s != null && s.Any(s => !string.IsNullOrWhiteSpace(s.StudentID) &&
                    !s.StudentID.Equals(StudIDTextBox.Text)))
                    throw new InvalidOperationException("The email was already registered by someone.");

                return true;
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }
    }
}
