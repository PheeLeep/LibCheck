using LibCheck.Database.Tables;
using LibCheck.Forms.SearchTools;
using LibCheck.Forms.SearchTools.UserControls;
using static LibCheck.Modules.Miscellaneous;


namespace LibCheck.Forms.Admin.UserControls.Statistics {
    public partial class HistoryStatistics : UserControl {
        private List<Students> students = new List<Students>();
        private List<Books> books = new List<Books>();
        private List<Records> records = new List<Records>();
        private bool isLoading = true;

        private DateTime from = CheckForSunday(DateTime.Now.AddDays(-7));
        private DateTime to = CheckForSunday(DateTime.Now);
        public HistoryStatistics() {
            InitializeComponent();
        }

        private void ChartsRefreshButton_Click(object sender, EventArgs e) {
            Control? uc = Parent;
            while (uc != null) {
                if (uc is not StatisticsDashboard) {
                    uc = uc.Parent;
                    continue;
                }
                ((StatisticsDashboard)uc).LoadData();
                TransactComboBox.SelectedIndex = 0;
                break;
            }
        }

        internal void LoadData(List<Students> students, List<Books> books, List<Records> records) {
            this.records.Clear();
            this.records = records;

            this.students.Clear();
            this.students = students;

            this.books.Clear();
            this.books = books;

            isLoading = false;
        }

        private void TransactComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (isLoading) return;

            to = CheckForSunday(DateTime.Now);
            switch (TransactComboBox.SelectedIndex) {
                case int n when n == TransactComboBox.Items.Count - 1:
                    using (DateRangeDialog drd = new DateRangeDialog()) {
                        if (drd.ShowDialog(this) != DialogResult.OK) {
                            TransactComboBox.SelectedItem = 0;
                            return;
                        }
                        from = CheckForSunday(drd.From);
                        to = CheckForSunday(drd.To, false);
                    }
                    break;
                case 0:
                    from = CheckForSunday(DateTime.Now.AddDays(-7));
                    break;
                case 1:
                    from = CheckForSunday(DateTime.Now.AddDays(-14));
                    break;
                case 2:
                    from = CheckForSunday(DateTime.Now.AddDays(-30));
                    break;
                case 3:
                    from = CheckForSunday(DateTime.Now.AddDays(-7));
                    break;
            }
            SelectData(from, to);
        }

        internal void SelectData(DateTime from, DateTime to) {
            List<Records> specificRecord = new List<Records>();

            specificRecord.AddRange(records.Where(r => r.DateOccurred.Date >= from.Date && r.DateOccurred <= to.Date));
            specificRecord.Reverse();
            dataGridView1.DataSource = specificRecord;
            ResetDGVColumns(dataGridView1);

            dataGridView1.Columns["DateOccurred"].Visible = true;
            dataGridView1.Columns["DateOccurred"].HeaderText = "Date";
            dataGridView1.Columns["ISBN"].Visible = true;
            dataGridView1.Columns["StudentID"].Visible = true;
            dataGridView1.Columns["StudentID"].HeaderText = "Student ID";
            dataGridView1.Columns["Category"].Visible = true;
            dataGridView1.Columns["AdditionalContext"].Visible = true;
            dataGridView1.Columns["AdditionalContext"].HeaderText = "Additional Context";
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (Modules.AppContext.Current.MainForm == null) return;
            object? obj = dataGridView1.DataSource;
            if (obj == null) return;
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            PleaseWait.RunInPleaseWait(Modules.AppContext.Current.MainForm, new Action(() => {
                try {
                    List<Records> specificRecord = (List<Records>)obj;
                    PleaseWait.SetPWDText("Saving...");
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName)) {
                        sw.WriteLine("Date,ISBN,Student ID,Category,Additional Context");
                        foreach (Records r in specificRecord) {
                            sw.Write($"{r.DateOccurred:dd/MM/yyyy hh:mm:ss tt},");
                            sw.Write($"{r.ISBN},");
                            sw.Write($"{r.StudentID},");
                            sw.Write($"{r.Category},");
                            string? context = r.AdditionalContext;
                            if (!string.IsNullOrWhiteSpace(context) && context.Contains(","))
                                context = $"\"{context}\"";
                            sw.WriteLine($"{context},");
                        }
                        sw.Flush();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }));
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            if (Modules.AppContext.Current.MainForm is AdminForm af) {
                SearchWindow sw = new SearchWindow();
                HistorySearchUC hsuc = new HistorySearchUC();
                sw.Controls.Add(hsuc);
                sw.SearchWhereCondition += Sw_SearchWhereCondition;
                sw.FormClosing += (s, e) => {
                    sw.SearchWhereCondition -= Sw_SearchWhereCondition;
                };
                hsuc.Dock = DockStyle.Fill;
                hsuc.CreateControl();
                af.RegisterWindow(sw);
                sw.Text = "Search History.";
                sw.Show();
            }
        }

        private void Sw_SearchWhereCondition(string whereCond) {
            if (!string.IsNullOrWhiteSpace(whereCond)
                 && Database.Database.Read(out List<Records>? specRecords, whereCond: whereCond) >= 0
                 && specRecords != null) {
                records = specRecords;
                SelectData(from, to);
            }
        }
    }
}
