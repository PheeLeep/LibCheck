using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Modules;

namespace LibCheck.Forms {
    public partial class StudentInfo : Form {
        private readonly Students student;

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
            Database.Database.Read(out List<Books>? l, "ISBN, Title, Author, DatePublished, DateToReturn",
                                   whereCond: $"StudentID = '{student.StudentID}'");

            DateTime currentDate = DateTime.Now;
            DateTime bdate = student.BirthDate;
            int age = 0;
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
            Miscellaneous.ResetDGVColumns(dataGridView1);

            dataGridView1.Columns["ISBN"].Visible = true;
            dataGridView1.Columns["Title"].Visible = true;
            dataGridView1.Columns["Author"].Visible = true;
            dataGridView1.Columns["SafeDatePublished"].Visible = true;
            dataGridView1.Columns["SafeDatePublished"].HeaderText = "Date Published";
            dataGridView1.Columns["SafeDateToReturn"].Visible = true;
            dataGridView1.Columns["SafeDateToReturn"].HeaderText = "Date to Return";
        }

        private void ReturnBookButton_Click(object sender, EventArgs e) {
            try {
                if (new BorrowReturnDialog(false, studentID: student.StudentID).ShowDialog(this) == DialogResult.Yes)
                    LoadItems();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
