using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Modules;

namespace LibCheck.Forms {
    public partial class StudentInfo : Form {
        private readonly Students student;

        public StudentInfo(string studentID) {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(studentID))
                throw new InvalidOperationException("No ID provided.");
            if (Database.Database.Read(out List<Students>? l, whereCond: $"StudentID = '{studentID}'") <= 0 || l == null)
                throw new StudentNotFoundException(studentID);
            student = l[0];
        }

        private void StudentInfo_Load(object sender, EventArgs e) {
            LoadItems();
        }
        private void LoadItems() {
            Database.Database.Read(out List<Books>? l,"ISBN, Title, Author, DatePublished", whereCond: $"StudentID = '{student.StudentID}'");

            Text = StudentLabel.Text = Miscellaneous.GenerateFullName(student);
            StudentIDLabel.Text = student.StudentID;
            GenderLabel.Text = $"Gender: {(student.IsFemale ? "Female" : "Male")}";
            DOBLabel.Text = $"Birth Date: {student.BirthDate:MMMM dd, yyyy} ({DateTime.Now.Year - student.BirthDate.Year} y/o)";
            LevelGradeSecLabel.Text = $"Level, Grade and Section: {student.GradeSection} ({Miscellaneous.Levels[student.Level]})";
            EmailAddressLabel.Text = $"Email Address: {student.EmailAddress}";

            dataGridView1.DataSource = l;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;

            dataGridView1.Columns["ISBN"].Visible = true;
            dataGridView1.Columns["Title"].Visible = true;
            dataGridView1.Columns["Author"].Visible = true;
            dataGridView1.Columns["SafeDatePublished"].Visible = true;
            dataGridView1.Columns["SafeDatePublished"].HeaderText = "Date Published";
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
