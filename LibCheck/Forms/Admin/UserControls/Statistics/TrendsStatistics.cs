﻿using LibCheck.Database.Tables;
using LibCheck.Forms.SearchTools;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin.UserControls.Statistics {
    public partial class TrendsStatistics : UserControl {
        private List<Students> students = new List<Students>();
        private List<Books> books = new List<Books>();
        private List<Records> records = new List<Records>();
        private bool isLoading = true;

        private DateTime from = CheckForSunday(DateTime.Now);
        private DateTime to = CheckForSunday(DateTime.Now);

        public TrendsStatistics() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            booksCListBox.ItemCheck += BooksCListBox_ItemCheck;
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        internal void LoadData(List<Students> students, List<Books> books, List<Records> records) {
            booksCListBox.Items.Clear();
            studentsCheckListBox.Items.Clear();
            this.records.Clear();
            this.records = records;

            this.students.Clear();
            this.students = students;

            this.books.Clear();
            this.books = books;

            for (int i = 0; i < books.Count; i++)
                booksCListBox.Items.Add($"{books[i].ISBN} ({books[i].Title})");
            for (int i = 0; i < booksCListBox.Items.Count; i++)
                booksCListBox.SetItemChecked(i, true);

            for (int i = 0; i < students.Count; i++)
                studentsCheckListBox.Items.Add($"{students[i].StudentID} ({GenerateFullName(students[i])})");
            for (int i = 0; i < studentsCheckListBox.Items.Count; i++)
                studentsCheckListBox.SetItemChecked(i, true);

            checkBox1.Checked = true;
            checkBox2.Checked = true;

            isLoading = false;
            tabControl2.SelectedIndex = 0;
        }

        private void cboxDateRange_SelectedIndexChanged(object sender, EventArgs e) {
            if (isLoading)
                return;

            to = CheckForSunday(DateTime.Now);
            switch (TrendsDateRangeCBox.SelectedIndex) {
                case int n when n == TrendsDateRangeCBox.Items.Count - 1:
                    using (DateRangeDialog drd = new DateRangeDialog()) {
                        if (drd.ShowDialog(this) != DialogResult.OK) {
                            TrendsDateRangeCBox.SelectedItem = 0;
                            return;
                        }
                        from = CheckForSunday(drd.From);
                        to = CheckForSunday(drd.To);
                    }
                    break;
                case 0:
                    from = CheckForSunday(DateTime.Now);
                    break;
                case 1:
                    from = CheckForSunday(DateTime.Now.AddDays(-7));
                    break;
                case 2:
                    from = CheckForSunday(DateTime.Now.AddDays(-14));
                    break;
                case 3:
                    from = CheckForSunday(DateTime.Now.AddDays(-30));
                    break;
            }
            SelectData(from, to);
        }
        private void BooksCListBox_ItemCheck(object? sender, ItemCheckEventArgs e) {
            if (isLoading)
                return;
            SelectData(from, to);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            booksCListBox.Enabled = !checkBox1.Checked;
            if (checkBox1.Checked && booksCListBox.CheckedItems.Count != books.Count) {
                isLoading = true;
                for (int i = 0; i < booksCListBox.Items.Count; i++)
                    booksCListBox.SetItemChecked(i, true);
                isLoading = false;
                SelectData(from, to);
            }
        }

        internal void SelectData(DateTime from, DateTime to) {
            List<double> borrowRates = new List<double>();
            List<double> returnRates = new List<double>();
            if (tabControl2.SelectedTab == tabPage3) {
                List<string> bookNames = new List<string>();

                List<string> isbns = new List<string>();

                try {
                    Invoke(new Action(() => {
                        for (int i = 0; i < booksCListBox.Items.Count; i++) {
                            if (booksCListBox.GetItemChecked(i)) {
                                string? text = booksCListBox.Items[i].ToString();
                                if (string.IsNullOrWhiteSpace(text))
                                    continue;
                                isbns.Add(text.Split(" ")[0]);
                            }
                        }
                    }));
                } catch {
                    // Ignore
                }

                foreach (string isbn in isbns) {
                    Books? b = books.FirstOrDefault(b => isbn.Equals(b.ISBN));
                    if (b == null)
                        continue;

                    if (string.IsNullOrWhiteSpace(b.Title))
                        continue;
                    bookNames.Add(b.Title);
                    borrowRates.Add(records.Count(s => !string.IsNullOrEmpty(s.ISBN) &&
                                                     s.Category == Records.RecordStatus.BookBorrowed &&
                                                     s.DateOccurred.Date >= from.Date && s.DateOccurred.Date <= to.Date &&
                                                     s.ISBN.Equals(b.ISBN)));
                    returnRates.Add(records.Count(s => !string.IsNullOrEmpty(s.ISBN) &&
                                                     s.Category == Records.RecordStatus.BookReturned &&
                                                     s.DateOccurred.Date >= from.Date && s.DateOccurred.Date <= to.Date &&
                                                     s.ISBN.Equals(b.ISBN)));

                }



                try {
                    Invoke(new Action(() => {

                        string range = to.Date == from.Date ? "Today" : $"{from:dd/MM/yyyy}-{to:dd/MM/yyyy}";

                        ConstructChart(BorrowPlot, false, new double[][] { borrowRates.ToArray() },
                                        bookNames.ToArray(), $"Borrow Rate Trend ({range})",
                                        "Books", "Borrow Rate");

                        ConstructChart(ReturnPlot, false, new double[][] { returnRates.ToArray() },
                                       bookNames.ToArray(), $"Return Rate Trend ({range})",
                                        "Books", "Borrow Rate");

                    }));
                } catch {
                    // Ignore
                }
                return;
            }
            List<string> studentNames = new List<string>();
            List<string> sIDs = new List<string>();

            try {
                Invoke(new Action(() => {
                    for (int i = 0; i < studentsCheckListBox.Items.Count; i++) {
                        if (studentsCheckListBox.GetItemChecked(i)) {
                            string? text = studentsCheckListBox.Items[i].ToString();
                            if (string.IsNullOrWhiteSpace(text))
                                continue;
                            sIDs.Add(text.Split(" ")[0]);
                        }
                    }
                }));
            } catch {
                // Ignore
            }

            foreach (string sID in sIDs) {
                Students? ss = students.FirstOrDefault(b => !string.IsNullOrWhiteSpace(b.StudentID) && b.StudentID.Equals(sID));
                if (ss == null)
                    continue;

                studentNames.Add(GenerateFullName(ss));
                borrowRates.Add(records.Count(s => !string.IsNullOrEmpty(s.StudentID) &&
                                                 s.Category == Records.RecordStatus.BookBorrowed &&
                                                 s.DateOccurred.Date >= from.Date && s.DateOccurred.Date <= to.Date &&
                                                 s.StudentID.Equals(ss.StudentID)));
                returnRates.Add(records.Count(s => !string.IsNullOrEmpty(s.StudentID) &&
                                                 s.Category == Records.RecordStatus.BookReturned &&
                                                 s.DateOccurred.Date >= from.Date && s.DateOccurred.Date <= to.Date &&
                                                 s.StudentID.Equals(ss.StudentID)));

            }



            try {
                Invoke(new Action(() => {

                    string range = to.Date == from.Date ? "Today" : $"{from:dd/MM/yyyy}-{to:dd/MM/yyyy}";

                    ConstructChart(BorrowPlot, false, new double[][] { borrowRates.ToArray() },
                                    studentNames.ToArray(), $"Borrow Rate Trend ({range})",
                                    "Students", "Borrow Rate");

                    ConstructChart(ReturnPlot, false, new double[][] { returnRates.ToArray() },
                                   studentNames.ToArray(), $"Return Rate Trend ({range})",
                                    "Students", "Borrow Rate");

                }));
            } catch {
                // Ignore
            }

        }

        private void TrendsRefreshButton_Click(object sender, EventArgs e) {
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

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e) {
            cboxDateRange_SelectedIndexChanged(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            studentsCheckListBox.Enabled = !checkBox2.Checked;
            if (checkBox2.Checked && studentsCheckListBox.CheckedItems.Count != students.Count) {
                isLoading = true;
                for (int i = 0; i < studentsCheckListBox.Items.Count; i++)
                    studentsCheckListBox.SetItemChecked(i, true);
                isLoading = false;
                SelectData(from, to);
            }
        }
    }
}
