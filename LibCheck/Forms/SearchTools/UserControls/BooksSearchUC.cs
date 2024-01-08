using LibCheck.Database.Tables;
using LibCheck.Modules;
using System.Text;

namespace LibCheck.Forms.SearchTools.UserControls
{
    public partial class BooksSearchUC : UserControl
    {
        private readonly object _lock = new object();
        private bool isLoaded = false;
        public BooksSearchUC()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (!IsbnRB.Checked) return;
            using (SearchDialog sd = new SearchDialog(SearchDialog.SearchType.Book, false))
            {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value)) return;
                keywordTextBox.Text = sd.Value;
            }
        }

        private void BooksSearchUC_Load(object sender, EventArgs e)
        {
            genreComboBox.Items.AddRange(Modules.Miscellaneous.Genres);
            genreComboBox.SelectedIndex = 0;
            isLoaded = true;
        }

        private void GenreCBox_CheckedChanged(object sender, EventArgs e)
        {
            genreComboBox.Enabled = GenreCBox.Checked;
            Compose();
        }

        private void Compose()
        {
            lock (_lock)
            {
                if (ParentForm is SearchWindow sw)
                {
                    List<string> queries = new List<string>();
                    StringBuilder sb = new StringBuilder();
                    if (!string.IsNullOrWhiteSpace(keywordTextBox.Text))
                    {
                        if (IsbnRB.Checked)
                        {
                            if (Regexes.IsValidISBN(keywordTextBox.Text))
                                queries.Add($"ISBN LIKE '%{keywordTextBox.Text}%'");
                        }
                        else if (TitleRB.Checked)
                        {
                            if (Regexes.IsValidAlphanumSpace(keywordTextBox.Text))
                                queries.Add($"Title LIKE '%{keywordTextBox.Text}%'");
                        }
                        else if (AuthorRB.Checked)
                        {
                            if (Regexes.IsValidAlphanumSpace(keywordTextBox.Text))
                                queries.Add($"Author LIKE '%{keywordTextBox.Text}%'");
                        }
                    }

                    if (BookBorrowedCBox.Checked) queries.Add($"StudentID <> '(none)'");
                    if (BookLDmgCbox.Checked) queries.Add($"IsLostOrDamaged = 1");
                    if (GenreCBox.Checked)
                    {
                        int idx = genreComboBox.SelectedIndex;
                        if (idx != -1)
                        {
                            string? val = genreComboBox.Items[idx].ToString();
                            if (!string.IsNullOrWhiteSpace(val))
                                queries.Add($"Genre = '{val}'");
                        }
                    }

                    for (int i = 0; i < queries.Count; i++)
                    {
                        sb.Append(queries[i]);
                        if (i < queries.Count - 1)
                            sb.Append(" OR ");
                    }

                    sw.PassOffWhereCond(sb.ToString());
                }
            }
        }

        private void RadioButtonsCheckedChanged(object sender, EventArgs e)
        {
             keywordTextBox.Clear();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            Compose();
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            Compose();
        }
    }
}
