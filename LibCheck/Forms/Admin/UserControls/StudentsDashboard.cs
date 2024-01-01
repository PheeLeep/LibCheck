using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Text;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class StudentsDashboard : UserControl {
        public StudentsDashboard() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        internal new void Load() {
            CurrentlyBorrowedLabel.Text = Database.Database.Read(out List<Students>? infos).ToString();
            dataGridView1.DataSource = infos;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;

            dataGridView1.Columns["StudentID"].Visible = true;
            dataGridView1.Columns["StudentID"].HeaderText = "Student ID";
            dataGridView1.Columns["FirstName"].Visible = true;
            dataGridView1.Columns["FirstName"].HeaderText = "First Name";
            dataGridView1.Columns["MiddleName"].Visible = true;
            dataGridView1.Columns["MiddleName"].HeaderText = "Middle Name";
            dataGridView1.Columns["LastName"].Visible = true;
            dataGridView1.Columns["LastName"].HeaderText = "Last Name";
            dataGridView1.Columns["GradeSection"].Visible = true;
            dataGridView1.Columns["GradeSection"].HeaderText = "Grade and Section";
        }

        private void AddButton_Click(object sender, EventArgs e) {
            using (StudentDialog bdg = new StudentDialog(Modules.Miscellaneous.DatabaseMode.Add)) {
                if (bdg.ShowDialog(this) == DialogResult.OK) {
                    Load();
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;
                string? id = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
                if (string.IsNullOrWhiteSpace(id))
                    return;
                using (StudentDialog bdg = new StudentDialog(Miscellaneous.DatabaseMode.Update, id)) {
                    if (bdg.ShowDialog(this) == DialogResult.OK) {
                        Load();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;
                string? id = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
                if (string.IsNullOrWhiteSpace(id))
                    return;
                if (MessageBox.Show(this, $"Do you want to delete Student '{id}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
                if (!Database.Database.Delete<Students>(id)) {
                    MessageBox.Show(this, "Failed to execute the database command.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                Load();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count == 0)
                    return;
                string? id = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
                if (string.IsNullOrWhiteSpace(id))
                    return;
                using (StudentInfo bdg = new StudentInfo(id)) {
                    if (bdg.ShowDialog(this) == DialogResult.OK) {
                        Load();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintLabel_Click(object sender, EventArgs e) {
            if (ParentForm == null) return;
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            string? id = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
            if (string.IsNullOrWhiteSpace(id))
                return;

            PleaseWait.RunInPleaseWait(ParentForm, () => {
                PleaseWait.SetPWDText("Please wait while generating QR...");
                try {

                    if (Database.Database.Read(out List<Students>? s, whereCond: $"StudentID = '{id}'") <= 0 || s == null)
                        throw new InvalidOperationException("No data provided.");
                    Students student = s[0];

                    Bitmap frontCard = new Bitmap(Properties.Resources.front_card);
                    Bitmap backCard = new Bitmap(Properties.Resources.back_card);
                    using (Font font = new Font("Century Gothic", 20)) {
                        using (Bitmap qr = QRCamModule.GenerateQR($"LC#{Credentials.Librarian?.SchoolGUID}#1#{id}")) {
                            using (Graphics g = Graphics.FromImage(frontCard)) {
                                g.DrawImage(qr, new Point(47, 130));
                                g.Flush();

                                PleaseWait.SetPWDText("Writing the information...");
                                string fullName = Miscellaneous.GenerateFullName(student);

                                SizeF fNameSize = g.MeasureString(fullName, font);
                                SizeF sectionSize = g.MeasureString(student.GradeSection, font);
                                g.DrawString(fullName, font, Brushes.White, new PointF(((378 + 979) / 2) - fNameSize.Width / 2, 249));
                                g.DrawString(student.GradeSection, font, Brushes.White, new PointF(((378 + 979) / 2) - sectionSize.Width / 2, 398));

                                g.Flush();
                            }

                            using (Graphics g = Graphics.FromImage(backCard)) {
                                SizeF sIDSize = g.MeasureString(student.StudentID, font);
                                g.DrawString(student.StudentID, font, Brushes.White, new PointF(((182 + 840) / 2) - sIDSize.Width / 2, 138));
                                g.Flush();
                            }
                        }
                    }
                    PleaseWait.SetPWDText("Done.");
                    Task.Factory.StartNew(() => {
                        Task.Delay(10).Wait();
                        Invoke(new Action(() => new LibCardDialogBox(frontCard, backCard).ShowDialog(this)));
                    });
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
