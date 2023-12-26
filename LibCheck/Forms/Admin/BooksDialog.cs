using LibCheck.Database.Tables;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin {
    public partial class BooksDialog : Form {
        private Books book = new Books();
        private DatabaseMode mode;
        private bool _isEdited = false;
        public BooksDialog(DatabaseMode mode, string isbn = "") {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.mode = mode;
            if (mode != DatabaseMode.Add) {
                if (string.IsNullOrEmpty(isbn))
                    throw new InvalidOperationException("No ISBN provided.");
                IEnumerable<Books>? infos = Modules.Database.Connection?
                                       .Query<Books>($"SELECT * FROM Books WHERE ISBN = '{isbn}'");
                if (infos == null || !infos.Any())
                    throw new InvalidOperationException("No data provided.");
                book = infos.Take(1).ToArray()[0];
            }
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void BooksDialog_Load(object sender, EventArgs e) {
            if (mode == DatabaseMode.Read) {
                TitleTextBox.ReadOnly = true;
                AuthorTextBox.ReadOnly = true;
                PublisherTextBox.ReadOnly = true;
                DescTextBox.ReadOnly = true;
                DatePublishedDatePicker.Enabled = false;
            }
            if (mode != DatabaseMode.Add) {
                ISBNTextBox.ReadOnly = true;
                ISBNTextBox.Text = book.ISBN;
                TitleTextBox.Text = book.Title;
                AuthorTextBox.Text = book.Author;
                PublisherTextBox.Text = book.Publisher;
                DescTextBox.Text = book.Description;
                DatePublishedDatePicker.Value = book.DatePublished;

                BorrowedLabel.Text = book.StudentID;
                IsDamagedLabel.Text = book.IsLostOrDamaged ? "Yes" : "No";
                ConfirmButton.Text = mode == DatabaseMode.Update ? "Update" : "OK";
                _isEdited = false;
                return;
            }
            book.IsLostOrDamaged = false;
            book.StudentID = "(none)";
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (_isEdited) {
                book.ISBN = ISBNTextBox.Text;
                book.Title = TitleTextBox.Text;
                book.Author = AuthorTextBox.Text;
                book.Publisher = PublisherTextBox.Text;
                book.DatePublished = DatePublishedDatePicker.Value;
                book.Description = DescTextBox.Text;
                int? res = mode == DatabaseMode.Add ?
                                  Modules.Database.Connection?.Insert(book) :
                                  Modules.Database.Connection?.Update(book);

                if (!res.HasValue || res == 0) {
                    MessageBox.Show(this, "Failed to execute a database.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                MessageBox.Show(this, "Database execution completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Controls_ValuesChanged(object sender, EventArgs e) {
            if (!_isEdited)
                _isEdited = true;
        }
    }
}
