using LibCheck.Database.Tables;
using LibCheck.Forms.SearchTools;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin.UserControls.Statistics {
    public partial class TransactStatistics : UserControl {

        private List<Students> students = new List<Students>();
        private List<Books> books = new List<Books>();
        private List<Records> records = new List<Records>();
        private bool isLoading = true;

        private DateTime from = CheckForSunday(DateTime.Now.AddDays(-7));
        private DateTime to = CheckForSunday(DateTime.Now);

        public TransactStatistics() {
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
            TransactComboBox.SelectedIndex = 0;
        }

        private void TransactComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (isLoading)
                return;

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
            List<string> dateStrings = new List<string>();
            List<double> borrowRates = new List<double>();
            List<double> returnRates = new List<double>();

            DateTime dt = from;

            while (dt.Date <= to.Date) {
                dateStrings.Add(dt.ToString("dd/MM/yyyy"));

                borrowRates.Add(BorrowCBox.Checked ? records.Count(s => s.Category == Records.RecordStatus.BookBorrowed &&
                                                   s.DateOccurred.Date == dt.Date) : 0);
                returnRates.Add(ReturnCBox.Checked ? records.Count(s => s.Category == Records.RecordStatus.BookReturned &&
                                                       s.DateOccurred.Date == dt.Date) : 0);

                dt = dt.AddDays(1);
                if (dt.DayOfWeek == DayOfWeek.Sunday)
                    dt = dt.AddDays(1);
            }

            try {
                Invoke(new Action(() => {

                    string range = to.Date == from.Date ? "Today" : $"{from:dd/MM/yyyy}-{to:dd/MM/yyyy}";

                    ConstructChart(ChartsPlot, true, new double[][] { borrowRates.ToArray(), returnRates.ToArray() },
                                    dateStrings.ToArray(), $"Student's Rate Trend ({range})",
                                    "Date", "Rate", new string[] { "Borrow", "Return" });
                }));
            } catch {
                //Ignore.
            }
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e) {
            SelectData(from, to);
        }
    }
}
