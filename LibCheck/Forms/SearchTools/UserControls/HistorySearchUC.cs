using LibCheck.Database.Tables;
using LibCheck.Modules;
using System.Text;

namespace LibCheck.Forms.SearchTools.UserControls {
    public partial class HistorySearchUC : UserControl {
        private readonly object _lock = new object();

        public HistorySearchUC() {
            InitializeComponent();
        }

        private void CBoxCheckChanged(object sender, EventArgs e) {
            Compose();
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            using (SearchDialog sd = new SearchDialog(BookRB.Checked ? SearchDialog.SearchType.Book : SearchDialog.SearchType.Student, false)) {
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
                    List<string> queries = new List<string>();
                    StringBuilder sb = new StringBuilder();
                    if (KeywordRB.Checked) {
                        if (!string.IsNullOrWhiteSpace(keywordTextBox.Text)) {
                            if (BookRB.Checked && Regexes.IsValidISBN(keywordTextBox.Text))
                                queries.Add($"ISBN LIKE '%{keywordTextBox.Text}%'");
                            if (StudentRB.Checked && Regexes.IsValidStudentID(keywordTextBox.Text))
                                queries.Add($"StudentID LIKE '%{keywordTextBox.Text}%'");
                        }
                    }

                    if (CategoryRB.Checked) {
                        if (BookAddedCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookAdded}");
                        if (BookBorrowedCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookBorrowed}");
                        if (bookModCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookModified}");
                        if (BookDelCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookDeleted}");
                        if (BookLDmgCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookMissingDamaged}");
                        if (BookReturnedCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookReturned}");
                        if (BookRestoredCBox.Checked)
                            queries.Add($"Category = {(int)Records.RecordStatus.BookRestored}");
                    }

                    for (int i = 0; i < queries.Count; i++) {
                        sb.Append(queries[i]);
                        if (i < queries.Count - 1)
                            sb.Append(" AND ");
                    }

                    sw.PassOffWhereCond(sb.ToString());
                }
            }
        }

        private void CriteriaRB_CheckedChanged(object sender, EventArgs e) {
            groupBox2.Enabled = KeywordRB.Checked;
            groupBox1.Enabled = CategoryRB.Checked;
            Compose();
        }
    }
}
