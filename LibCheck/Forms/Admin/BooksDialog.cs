using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin {
    public partial class BooksDialog : Form {

        private Books book = new Books();
        private DatabaseMode mode;
        private bool _isEdited = false;
        private bool _onPBoxChanged = false;

        public BooksDialog(DatabaseMode mode, string isbn = "") {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.mode = mode;
            if (mode != DatabaseMode.Add) {
                if (string.IsNullOrWhiteSpace(isbn) || Database.Database.Read(out List<Books>? r,
                                                                              whereCond: $"ISBN = '{isbn}'") < 1)
                    throw new InvalidOperationException("No ISBN provided.");

                if (r == null)
                    throw new InvalidOperationException("No data provided.");
                book = r[0];
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
            genreComboBox.Items.AddRange(Genres);
            genreComboBox.SelectedIndex = 0;

            if (mode == DatabaseMode.Read) {
                TitleTextBox.ReadOnly = true;
                AuthorTextBox.ReadOnly = true;
                PublisherTextBox.ReadOnly = true;
                DescTextBox.ReadOnly = true;
                DatePublishedDatePicker.Enabled = false;
            }

            if (mode != DatabaseMode.Add) {
                int idx = genreComboBox.Items.IndexOf(book.Genre);
                if (idx == -1)
                    idx = genreComboBox.Items.Count - 1;

                ISBNTextBox.ReadOnly = true;
                ISBNTextBox.Text = book.ISBN;
                TitleTextBox.Text = book.Title;
                AuthorTextBox.Text = book.Author;
                PublisherTextBox.Text = book.Publisher;
                DescTextBox.Text = book.Description;
                DatePublishedDatePicker.Value = book.DatePublished;
                genreComboBox.SelectedIndex = idx;

                string path = Path.Combine(EnvVars.BookImages.FullName, $"{Credentials.Librarian?.SchoolGUID}-{book.ISBN}.jpg");
                if (File.Exists(path))
                    pictureBox1.Image = Image.FromFile(path);
                ConfirmButton.Text = mode == DatabaseMode.Update ? "Update" : "OK";
                _isEdited = false;
                _onPBoxChanged = false;
                return;
            }
            book.IsLostOrDamaged = false;
            book.StudentID = "(none)";
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (_isEdited) {
                if (!CheckInformation())
                    return;

                string path = Path.Combine(EnvVars.BookImages.FullName, $"{Credentials.Librarian?.SchoolGUID}-{book.ISBN}.jpg");

                if (mode == DatabaseMode.Update && _onPBoxChanged && File.Exists(path)) {
                    try {
                        File.Delete(path);
                    } catch (Exception ex) {
                        Logger.Log(Logger.LogEnums.Warn, $"Failed to delete image. ({ex.Message})");
                    }
                }

                book.ISBN = ISBNTextBox.Text;
                book.Title = TitleTextBox.Text;
                book.Author = AuthorTextBox.Text;
                book.Publisher = PublisherTextBox.Text;
                book.DatePublished = DatePublishedDatePicker.Value;
                book.Description = DescTextBox.Text;
                book.Genre = genreComboBox.Items[genreComboBox.SelectedIndex].ToString();

                if (_onPBoxChanged) {
                    try {
                        if (!EnvVars.BookImages.Exists)
                            EnvVars.BookImages.Create();
                        pictureBox1.Image?.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                    } catch (Exception ex) {
                        Logger.Log(Logger.LogEnums.Warn, $"Failed to copy image. ({ex.Message})");
                    }
                }

                string operation = mode == DatabaseMode.Add ? "add" : "update";
                string pastSucceed = mode == DatabaseMode.Add ? "added" : "updated";
                if (!(mode == DatabaseMode.Add ? Database.Database.Insert(book)
                                               : Database.Database.Update(book))) {
                    Logger.Log(Logger.LogEnums.Error, $"Failed to {operation} book information.");
                    MessageBox.Show(this, $"Failed to {operation} book information.",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                Records r = new Records() {
                    DateOccurred = DateTime.Now,
                    ISBN = book.ISBN,
                    StudentID = "(none)",
                    Category = mode == DatabaseMode.Add ? Records.RecordStatus.BookAdded :
                                                          Records.RecordStatus.BookModified,
                    AdditionalContext = "(none)"
                };
                Database.Database.Insert(r);
                Logger.Log(Logger.LogEnums.Info, $"Book information is {pastSucceed}.");
                MessageBox.Show(this, $"Book information is {pastSucceed}.", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Controls_ValuesChanged(object sender, EventArgs e) {
            if (!_isEdited)
                _isEdited = true;
        }

        private bool CheckInformation() {
            try {
                if (!Regexes.IsValidISBN(ISBNTextBox.Text.Replace("-", "")))
                    throw new InvalidOperationException("Invalid ISBN provided.");
                if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
                    throw new InvalidOperationException("Title is empty.");
                if (string.IsNullOrWhiteSpace(AuthorTextBox.Text))
                    throw new InvalidOperationException("Author is empty.");
                if (string.IsNullOrWhiteSpace(PublisherTextBox.Text))
                    throw new InvalidOperationException("Publisher is empty.");
                if (string.IsNullOrWhiteSpace(DescTextBox.Text))
                    DescTextBox.Text = "(no information provided.)";
                return true;
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void AddImgButton_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            _onPBoxChanged = true;
            _isEdited = true;
        }

        private void RemoveImageButton_Click(object sender, EventArgs e) {
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            _onPBoxChanged = true;
            _isEdited = true;
        }

        private void BooksDialog_FormClosing(object sender, FormClosingEventArgs e) {
            pictureBox1.Image?.Dispose();
        }
    }
}
