using LibCheck.Database.Tables;
using LibCheck.Modules;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin {
    public partial class BooksDialog : Form {

        private Books book = new Books();
        private DatabaseMode mode;
        private bool _isEdited = false;
        private string? _imagePath = "";
        private string? _fullImagePath = "";
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
                _imagePath = book.ImagePath;

                if (!string.IsNullOrWhiteSpace(_imagePath)) {
                    pictureBox1.Image = Image.FromFile($"{EnvVars.MainPath.FullName}\\book_images\\{book.ImagePath}");
                }
                ConfirmButton.Text = mode == DatabaseMode.Update ? "Update" : "OK";
                _isEdited = false;
                return;
            }
            book.IsLostOrDamaged = false;
            book.StudentID = "(none)";
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (_isEdited) {
                if (!CheckInformation())
                    return;

                pictureBox1.Image.Dispose();

                if (mode == DatabaseMode.Update) {
                    if (string.IsNullOrWhiteSpace(_imagePath) ||
                        (!string.IsNullOrWhiteSpace(book.ImagePath) && !_imagePath.Equals(book.ImagePath))) {
                        File.Delete($"{EnvVars.MainPath.FullName}\\book_images\\{book.ImagePath}");
                    }
                }
                book.ISBN = ISBNTextBox.Text;
                book.Title = TitleTextBox.Text;
                book.Author = AuthorTextBox.Text;
                book.Publisher = PublisherTextBox.Text;
                book.DatePublished = DatePublishedDatePicker.Value;
                book.Description = DescTextBox.Text;
                book.Genre = genreComboBox.Items[genreComboBox.SelectedIndex].ToString();
                book.ImagePath = _imagePath;

                if (!string.IsNullOrWhiteSpace(_fullImagePath)) {
                    try {

                        if (!Directory.Exists(EnvVars.MainPath.FullName + "\\book_images"))
                            Directory.CreateDirectory(EnvVars.MainPath.FullName + "\\book_images");
                        File.Copy(_fullImagePath, $"{EnvVars.MainPath.FullName}\\book_images\\{_imagePath}", true);
                    } catch (Exception ex) {
                        Logger.Log(Logger.LogEnums.Warn, $"Failed to copy image. ({ex.Message})");
                        book.ImagePath = "";
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
            _imagePath = openFileDialog1.SafeFileName;
            _fullImagePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            _isEdited = true;
        }

        private void RemoveImageButton_Click(object sender, EventArgs e) {
            _imagePath = "";
            _fullImagePath = "";
            _isEdited = true;
        }

        private void BooksDialog_FormClosing(object sender, FormClosingEventArgs e) {
            pictureBox1.Image?.Dispose();
        }
    }
}
