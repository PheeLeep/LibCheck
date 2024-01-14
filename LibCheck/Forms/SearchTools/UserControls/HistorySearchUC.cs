using LibCheck.Database.Tables;
using LibCheck.Modules;

namespace LibCheck.Forms.SearchTools.UserControls {
    public partial class HistorySearchUC : UserControl {
        private readonly object _lock = new object();
        private readonly List<Records>? query_snapshot;
        public HistorySearchUC() {
            InitializeComponent();
            Database.Database.Read(out query_snapshot);
        }

        private void CBoxCheckChanged(object sender, EventArgs e) {
            Compose();
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            using (SearchDialog sd = new SearchDialog(BookRB.Checked ? SearchDialog.SearchType.Book : SearchDialog.SearchType.Student,
                                                        false, true)) {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value))
                    return;
                keywordTextBox.Text = sd.Value;
            }
        }

        private void keywordTextBox_TextChanged(object sender, EventArgs e) {
            Compose();
        }

        private void StudentRB_CheckedChanged(object sender, EventArgs e) {
            keywordTextBox.Clear();
        }

        private void Compose() {
            lock (_lock) {
                if (ParentForm is SearchWindow sw) {
                    List<Records>? r = query_snapshot?.ToList();

                    if (r != null) {
                        if (KeywordRB.Checked && !string.IsNullOrWhiteSpace(keywordTextBox.Text)) {
                            if (BookRB.Checked && Regexes.IsValidISBN(keywordTextBox.Text))
                                r = r.Where(rr => !string.IsNullOrWhiteSpace(rr.ISBN) &&
                                                   rr.ISBN.Contains(keywordTextBox.Text)).ToList();
                            if (StudentRB.Checked && Regexes.IsValidStudentID(keywordTextBox.Text))
                                r = r.Where(rr => !string.IsNullOrWhiteSpace(rr.StudentID) &&
                                                  rr.StudentID.Contains(keywordTextBox.Text)).ToList();
                        }


                        if (CategoryRB.Checked) {
                            r = r.Where(rr => (BookAddedCBox.Checked && rr.Category == Records.RecordStatus.BookAdded) ||
                                              (BookBorrowedCBox.Checked && rr.Category == Records.RecordStatus.BookBorrowed) ||
                                              (bookModCBox.Checked && rr.Category == Records.RecordStatus.BookModified) ||
                                              (BookDelCBox.Checked && rr.Category == Records.RecordStatus.BookDeleted) ||
                                              (BookLDmgCBox.Checked && rr.Category == Records.RecordStatus.BookMissingDamaged) ||
                                              (BookReturnedCBox.Checked && rr.Category == Records.RecordStatus.BookReturned) ||
                                              (BookRestoredCBox.Checked && rr.Category == Records.RecordStatus.BookRestored)).ToList();
                        }
                    }

                    sw.PassOffWhereCond(r);
                }
            }
        }

        private void CriteriaRB_CheckedChanged(object sender, EventArgs e) {
            groupBox2.Enabled = KeywordRB.Checked;
            groupBox1.Enabled = CategoryRB.Checked;
            Compose();
        }

        private void HistorySearchUC_Load(object sender, EventArgs e) {
            CriteriaRB_CheckedChanged(sender, e);
        }
    }
}
