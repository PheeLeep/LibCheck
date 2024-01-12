using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Text.RegularExpressions;

namespace LibCheck.Forms.Admin {
    public partial class ComposeDiag : Form {

        private readonly List<Students> students;
        private readonly RecentEmail? recent;
        internal ComposeDiag(RecentEmail? re = null) {
            InitializeComponent();
            students = new List<Students>();
            recent = re;
            if (recent != null) {
                if (Database.Database.Read(out List<Students>? oldStudent,
                                           whereCond: $"StudentID = '{recent.StudentID}'") <= 0
                                           || oldStudent == null)
                    throw new InvalidOperationException("No students found.");
                students = oldStudent;
                return;
            }
            if (Database.Database.Read(out List<Students>? tmpStudent) <= 0 || tmpStudent == null)
                throw new InvalidOperationException("No students found.");
            students = tmpStudent;
        }

        private void ComposeDiag_Load(object sender, EventArgs e) {
            foreach (Students s in students)
                ToComboxBox.Items.Add($"{s.EmailAddress} ({Miscellaneous.GenerateFullName(s)})");

            if (recent != null) {
                ToComboxBox.SelectedIndex = 0;
                ToComboxBox.Enabled = false;
                SubjectTextBox.ReadOnly = true;
                BodyTextBox.ReadOnly = true;
                if (!string.IsNullOrWhiteSpace(recent.Body)) {
                    recent.Body = recent.Body.Replace("<br />", Environment.NewLine);
                    BodyTextBox.Text = HtmlRegex().Replace(recent.Body, string.Empty);
                }
                SubjectTextBox.Text = recent.Subject;
                ComposeBtn.Text = "OK";
            }
        }

        internal void SetSpecificEmail(string? emailAdd) {
            if (string.IsNullOrWhiteSpace(emailAdd))
                return;
            List<Students>sR = students.Where(s => !string.IsNullOrWhiteSpace(s.EmailAddress) && s.EmailAddress.Equals(emailAdd)).ToList();
            if (sR.Count != 1)
                return;
            Students s = sR[0];
            ToComboxBox.SelectedIndex = ToComboxBox.Items.IndexOf($"{s.EmailAddress} ({Miscellaneous.GenerateFullName(s)})");
            ToComboxBox.Enabled = false;
        }

        private void ComposeLabel_Click(object sender, EventArgs e) {
            if (recent != null) {
                Close();
                return;
            }
            try {
                if (ToComboxBox.SelectedIndex == -1)
                    throw new InvalidOperationException("Please select the email address of a student.");
                if (string.IsNullOrWhiteSpace(SubjectTextBox.Text))
                    throw new InvalidOperationException("No subject text found.");
                if (string.IsNullOrWhiteSpace(BodyTextBox.Text))
                    throw new InvalidOperationException("No body text found.");

                string body = BodyTextBox.Text.Replace("\r\n", "<br />")
                                              .Replace("\n", "<br />");
                string txt = Properties.Resources.CustomEmail.Replace("%school%", Credentials.Librarian?.SchoolName)
                                                           .Replace("%text%", body)
                                                           .Replace("%librarian%",
                                                                    Miscellaneous.GenerateFullName(Credentials.Librarian));

                if (!EmailService.Queue(students[ToComboxBox.SelectedIndex], txt, SubjectTextBox.Text))
                    throw new InvalidOperationException("Failed to add to the email queue.");

                MessageBox.Show(this, "Your composed email was added to the queue.",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        [GeneratedRegex("<.*?>")]
        private static partial Regex HtmlRegex();
    }
}
