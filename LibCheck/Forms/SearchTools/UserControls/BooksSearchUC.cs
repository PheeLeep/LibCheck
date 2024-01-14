using LibCheck.Database.Tables;

namespace LibCheck.Forms.SearchTools.UserControls {
    public partial class BooksSearchUC : UserControl {
        private readonly object _lock = new object();
        private bool isLoaded = false;
        private readonly List<Books>? query_snapshot;
        public BooksSearchUC() {
            InitializeComponent();
            Database.Database.Read(out query_snapshot);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            if (!IsbnRB.Checked)
                return;
            using (SearchDialog sd = new SearchDialog(SearchDialog.SearchType.Book, false, true)) {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value))
                    return;
                keywordTextBox.Text = sd.Value;
            }
        }

        private void BooksSearchUC_Load(object sender, EventArgs e) {
            genreComboBox.Items.AddRange(Modules.Miscellaneous.Genres);
            genreComboBox.SelectedIndex = 0;
            isLoaded = true;
            CriteriaRB_CheckedChanged(sender, e);
        }

        private void CriteriaRB_CheckedChanged(object sender, EventArgs e) {
            groupBox2.Enabled = KeywordRB.Checked;
            groupBox1.Enabled = CategoryRB.Checked;
            Compose();
        }

        private void Compose() {
            lock (_lock) {
                if (ParentForm is SearchWindow sw) {
                    List<Books>? b = query_snapshot?.ToList();
                    if (b != null) {
                        if (KeywordRB.Checked && !string.IsNullOrWhiteSpace(keywordTextBox.Text)) {
                            if (IsbnRB.Checked) {
                                b = b.Where(bb => !string.IsNullOrWhiteSpace(bb.ISBN) &&
                                                  bb.ISBN.Contains(keywordTextBox.Text)).ToList();
                            } else if (TitleRB.Checked) {
                                b = b.Where(bb => !string.IsNullOrWhiteSpace(bb.Title) &&
                                                  bb.Title.Contains(keywordTextBox.Text)).ToList();
                            } else if (AuthorRB.Checked) {
                                b = b.Where(bb => !string.IsNullOrWhiteSpace(bb.Author) &&
                                                 bb.Author.Contains(keywordTextBox.Text)).ToList();
                            }
                        }


                        if (CategoryRB.Checked) {
                            if (BookBorrowedCBox.Checked)
                                b = b.Where(bb => !string.IsNullOrWhiteSpace(bb.StudentID) &&
                                                  !bb.StudentID.Equals("(none)")).ToList();
                            if (BookLDmgCbox.Checked)
                                b = b.Where(bb => bb.IsLostOrDamaged).ToList();
                            if (GenreCBox.Checked) {
                                int idx = genreComboBox.SelectedIndex;
                                if (idx != -1) {
                                    string? val = genreComboBox.Items[idx].ToString();
                                    if (!string.IsNullOrWhiteSpace(val))
                                        b = b.Where(bb => !string.IsNullOrWhiteSpace(bb.Genre) &&
                                                           bb.Genre.Contains(val)).ToList();
                                }
                            }
                        }
                    }
                    sw.PassOffWhereCond(b);
                }
            }
        }

        private void RadioButtonsCheckedChanged(object sender, EventArgs e) {
            keywordTextBox.Clear();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (!isLoaded)
                return;
            Compose();
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e) {
            genreComboBox.Enabled = GenreCBox.Checked;
            Compose();
        }

        private void keywordTextBox_TextChanged(object sender, EventArgs e) {
            Compose();
        }
    }
}
