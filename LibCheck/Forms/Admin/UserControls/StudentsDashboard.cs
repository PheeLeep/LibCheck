using LibCheck.Database.Tables;
using LibCheck.Forms.SearchTools;
using LibCheck.Forms.SearchTools.UserControls;
using LibCheck.Modules;
using LibCheck.Modules.Security;

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
            Logger.Log(Logger.LogEnums.Verbose, $"{GetType().Name} info loaded.");
            Miscellaneous.ResetDGVColumns(dataGridView1);

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
                Logger.Log(Logger.LogEnums.Error, $"Failed to update a student. ({ex.Message})");
                MessageBox.Show(this, $"Failed to update.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;
                string? id = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
                if (string.IsNullOrWhiteSpace(id))
                    return;
                if (Database.Database.Read(out List<Books>? b) > 0 && b != null && b.Any(bb => id.Equals(bb.StudentID))) {

                    Logger.Log(Logger.LogEnums.Error, $"Couldn't delete. There are remaining borrowed books.");
                    MessageBox.Show(this, $"Student {id} has some books that are currently borrowed.",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (MessageBox.Show(this, $"Do you want to delete Student '{id}'? Deleting info will invalidate the " +
                                    "QR code that already printed.", "", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;

                if (!Database.Database.Delete<Students>(id))
                    throw new InvalidOperationException("Couldn't remove a student info from the database.");
                Logger.Log(Logger.LogEnums.Warn, "Student info is deleted. Reloading...");
                Load();
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to delete a student info. ({ex.Message})");
                MessageBox.Show(this, $"Failed to delete.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                Logger.Log(Logger.LogEnums.Error, $"Failed to read a student info. ({ex.Message})");
                MessageBox.Show(this, $"Failed to read.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void PrintLabel_Click(object sender, EventArgs e) {
            if (ParentForm == null)
                return;
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            string? id = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
            if (string.IsNullOrWhiteSpace(id))
                return;

            PleaseWait.RunInPleaseWait(ParentForm, () => {
                PleaseWait.SetPWDText("Please wait while generating QR...");
                try {

                    if (Database.Database.Read(out List<Students>? s) <= 0 || s == null)
                        throw new InvalidOperationException("No data provided.");

                    s = s.Where(ss => id.Equals(ss.StudentID)).ToList();
                    if (s.Count != 1)
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

                                PointF namePoint = new PointF(((378 + 979) / 2) - fNameSize.Width / 2, 249);
                                PointF gsPoint = new PointF(((378 + 979) / 2) - sectionSize.Width / 2, 398);

                                g.DrawString(fullName, font, Brushes.White, namePoint);
                                g.DrawString(student.GradeSection, font, Brushes.White, gsPoint);

                                g.Flush();
                            }

                            using (Graphics g = Graphics.FromImage(backCard)) {
                                SizeF sIDSize = g.MeasureString(student.StudentID, font);
                                PointF sIDPoint = new PointF(((182 + 840) / 2) - sIDSize.Width / 2, 138);

                                g.DrawString(student.StudentID, font, Brushes.White, sIDPoint);
                                g.Flush();
                            }
                        }
                    }
                    PleaseWait.SetPWDText("Done.");
                    Logger.Log(Logger.LogEnums.Info, $"Student QR code printed.");
                    Task.Factory.StartNew(() => {
                        Task.Delay(10).Wait();
                        Invoke(new Action(() => new LibCardDialogBox(frontCard, backCard).ShowDialog(this)));
                    });
                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, $"Failed to print a student info. ({ex.Message})");
                    MessageBox.Show(this, $"Failed to print.\nCause: {ex.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            });
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            if (Modules.AppContext.Current.MainForm is AdminForm af) {
                SearchWindow sw = new SearchWindow();
                StudentsSearchUC hsuc = new StudentsSearchUC();
                sw.Controls.Add(hsuc);
                sw.SearchWhereCondition += Sw_SearchWhereCondition;
                sw.FormClosing += (s, e) => {
                    sw.SearchWhereCondition -= Sw_SearchWhereCondition;
                    Sw_SearchWhereCondition("");
                };
                hsuc.Dock = DockStyle.Fill;
                hsuc.CreateControl();
                af.RegisterWindow(sw);
                sw.Text = "Search Student.";
                sw.Show(this);
            }
        }

        private void Sw_SearchWhereCondition(object? list) {
            if (list is not List<Students>) {
                Load();
                return;
            }
            dataGridView1.DataSource = list;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (Modules.AppContext.Current.MainForm == null)
                return;
            object? obj = dataGridView1.DataSource;
            if (obj == null)
                return;
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;
            PleaseWait.RunInPleaseWait(Modules.AppContext.Current.MainForm, new Action(() => {
                try {
                    List<Students> specificRecord = (List<Students>)obj;
                    PleaseWait.SetPWDText("Saving...");
                    Database.Database.ExportToCSV(specificRecord, saveFileDialog1.FileName);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }));
        }
    }
}
