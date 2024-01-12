using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Forms.Admin;
using LibCheck.Modules;

namespace LibCheck.Forms {
    public partial class StudentInfo : Form {
        private readonly Students student;

        private ComposeDiag? _diag;
        public StudentInfo(string studentID) {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(studentID) ||
                Database.Database.Read(out List<Students>? l, whereCond: $"StudentID = '{studentID}'") <= 0 ||
                l == null)
                throw new StudentNotFoundException(studentID);

            student = l[0];
        }

        private void StudentInfo_Load(object sender, EventArgs e) {
            LoadItems();
        }
        private void LoadItems() {
            Database.Database.Read(out List<Books>? l, "ISBN, Title, DateToReturn",
                                   $"StudentID = '{student.StudentID}'");

            DateTime currentDate = DateTime.Now;
            DateTime bdate = student.BirthDate;
            int age;
            if (bdate.Month > currentDate.Month || (bdate.Month == currentDate.Month && bdate.Day > currentDate.Day)) {
                age = currentDate.Year - bdate.Year - 1;
            } else {
                age = currentDate.Year - bdate.Year;
            }

            Text = StudentLabel.Text = Miscellaneous.GenerateFullName(student);
            StudentIDLabel.Text = student.StudentID;
            GenderLabel.Text = $"Gender: {(student.IsFemale ? "Female" : "Male")}";
            DOBLabel.Text = $"Birth Date: {student.BirthDate:MMMM dd, yyyy} ({age} y/o)";
            LevelGradeSecLabel.Text = $"Level, Grade and Section: {student.GradeSection} ({Miscellaneous.Levels[student.Level]})";
            EmailAddressLabel.Text = $"Email Address: {student.EmailAddress}";

            dataGridView1.DataSource = l;

            dataGridView1.Columns.Add("DateIssued", "Date Issued");
            dataGridView1.Columns["DateIssued"].DisplayIndex = dataGridView1.Columns["SafeDateToReturn"].DisplayIndex - 1;

            if (l != null) {
                for (int i = 0; i < l.Count; i++) {
                    Books b = l[i];
                    if (Database.Database.Read(out List<Records>? records,
                                                    whereCond: $"StudentID = '{student.StudentID}' " +
                                                               $"AND ISBN = '{b.ISBN}' AND " +
                                                               $"Category = {(int)Records.RecordStatus.BookBorrowed}") <= 0
                                               || records == null) {
                        dataGridView1.Rows[i].Cells["DateIssued"].Value = "(none)";
                        continue;
                    }
                    dataGridView1.Rows[i].Cells["DateIssued"].Value = records[0].DateOccurred.ToString("dd/MM/yyyy");
                }
            }

            Miscellaneous.ResetDGVColumns(dataGridView1);

            dataGridView1.Columns["Title"].Visible = true;
            dataGridView1.Columns["SafeDateToReturn"].Visible = true;
            dataGridView1.Columns["SafeDateToReturn"].HeaderText = "Date to Return";
            dataGridView1.Columns["DateIssued"].Visible = true;



        }

        private void ReturnBookButton_Click(object sender, EventArgs e) {
            try {
                if (new BorrowReturnDialog(false, studentID: student.StudentID).ShowDialog(this) == DialogResult.Yes)
                    LoadItems();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmailAddressLabel_DoubleClick(object sender, EventArgs e) {
            if (_diag != null) {
                _diag.BringToFront();
                _diag.WindowState = FormWindowState.Normal;
                _diag.Focus();
                return;
            }
            if (!Modules.AppContext.Auth() || MessageBox.Show(this, "Please use this feature responsibly! " +
                                                            "This will record what you're typing and unable to delete!", "",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            _diag = new ComposeDiag();
            _diag.FormClosed += (g, e) => {
                _diag = null;
            };
            _diag.Show();
           
            _diag.SetSpecificEmail(student.EmailAddress);
        }

        private void StudentInfo_FormClosing(object sender, FormClosingEventArgs e) {
            if (_diag != null)
                _diag.Close();
        }
    }
}
