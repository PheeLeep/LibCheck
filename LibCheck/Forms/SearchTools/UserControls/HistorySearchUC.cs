using LibCheck.Database.Tables;
using System.Text;

namespace LibCheck.Forms.SearchTools.UserControls {
    public partial class HistorySearchUC : UserControl {
        private readonly object _lock = new object();

        public HistorySearchUC() {
            InitializeComponent();
        }

        private void CBoxCheckChanged(object sender, EventArgs e) {
            lock (_lock) {
                if (ParentForm is SearchWindow sw) {
                    List<string> queries = new List<string>();
                    StringBuilder sb = new StringBuilder();
                    if (BookAddedCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookAdded}");
                    if (BookBorrowedCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookBorrowed}");
                    if (bookModCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookModified}");
                    if (BookDelCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookDeleted}");
                    if (BookLDmgCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookMissingDamaged}");
                    if (BookReturnedCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookReturned}");
                    if (BookRestoredCBox.Checked) queries.Add($"Category = {(int)Records.RecordStatus.BookRestored}");

                    for (int i = 0; i < queries.Count; i++) {
                        sb.Append(queries[i]);
                        if (i < queries.Count - 1)
                            sb.Append(" OR ");
                    }

                    sw.PassOffWhereCond(sb.ToString());
                }
            }
        }
    }
}
