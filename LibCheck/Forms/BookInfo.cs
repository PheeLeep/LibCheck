using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Modules;
using Microsoft.VisualBasic;

namespace LibCheck.Forms {
    public partial class BookInfo : Form {

        private Books? book;
        private readonly string isbn;
        internal BookInfo(string isbn) {
            InitializeComponent();
            this.isbn = isbn;
        }

        private void BookInfo_Load(object sender, EventArgs e) {
            while (!IsHandleCreated)
                Thread.Sleep(100);
            LoadInfo();
        }

        private void LoadInfo() {
            if (string.IsNullOrWhiteSpace(isbn))
                throw new BookNotFoundException();
            if (Database.Database.Read(out List<Books>? infos, whereCond: $"ISBN = '{isbn}'") <= 0 || infos == null)
                throw new BookNotFoundException(isbn);
            book = infos[0];
            Text = TitleLabel.Text = book.Title;
            OwnedLabel.Text = "No student is currently owned by this book.";

            if (book.IsLostOrDamaged) {
                BorrowBookButton.Enabled = false;
                MarkAsDamageButton.Text = "MarkRet";
                OwnedLabel.Text = "This book is known lost or damaged.";
                if (!string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)"))
                    OwnedLabel.Text += $" (Last owner: {book.StudentID})";
            } else {
                BorrowBookButton.Enabled = true;
                MarkAsDamageButton.Text = "MarkLDmg";
                if (!string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)")) {
                    OwnedLabel.Text = $"Currently owned by '{book.StudentID}'";
                    if (DateTime.Now > book.DateToReturn)
                        OwnedLabel.Text += " (OVERDUE)";
                }
            }

            AuthorLabel.Text = $"Author/s: {book.Author}";
            ISBNLabel.Text = $"ISBN: {book.ISBN}";
            PublisherLabel.Text = $"Publisher: {book.Publisher}";
            DatePubLabel.Text = $"Date Published: {book.DatePublished:MMMM dd, yyyy}";
            GenreLabel.Text = $"Genre: {book.Genre}";
            richTextBox1.Text = book.Description;
            if (!string.IsNullOrWhiteSpace(book.ImagePath)) {
                pictureBox1.Image = Image.FromFile($"{EnvVars.MainPath.FullName}\\book_images\\{book.ImagePath}");
            }
            BorrowBookButton.Visible = !string.IsNullOrWhiteSpace(book.StudentID) && book.StudentID.Equals("(none)");

        }

        private void OwnedLabel_DoubleClick(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(book?.StudentID) || book.StudentID.Equals("(none)")) {
                return;
            }
            new StudentInfo(book.StudentID).ShowDialog();
            LoadInfo();
        }

        private void MarkAsDamageButton_Click(object sender, EventArgs e) {
            if (book == null || !Modules.AppContext.Auth())
                return;
            string msg = book.IsLostOrDamaged ? "Make sure the book was found or replaced a new copy before you proceed. Continue?"
                                              : "This will mark as lost or damaged and marked violated to the student who are " +
                                                "currently borrowed. Continue?";
            if (MessageBox.Show(this, msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                return;

            string reason = Interaction.InputBox("Enter the Reason. (optional)");
            book.IsLostOrDamaged = !book.IsLostOrDamaged;
            if (!book.IsLostOrDamaged) {
                book.DateToReturn = null;
                book.StudentID = "(none)";
            }

            Records r = new Records() {
                DateOccurred = DateTime.Now,
                AdditionalContext = string.IsNullOrWhiteSpace(reason) ? "(no additional context)" : reason,
                ISBN = book.ISBN,
                Category = book.IsLostOrDamaged ? Records.RecordStatus.BookMissingDamaged : Records.RecordStatus.BookRestored,
                StudentID = "(none)"
            };

            if (book.IsLostOrDamaged && !string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)"))
                r.StudentID = book.StudentID;

            if (!Database.Database.Update(book) || !Database.Database.Update(r)) {
                MessageBox.Show(this, "Failed to mark/unmark the book.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            LoadInfo();
        }

        private void BorrowBookButton_Click(object sender, EventArgs e) {
            try {
                if (new BorrowReturnDialog(true, book?.ISBN).ShowDialog(this) == DialogResult.Yes)
                    LoadInfo();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookInfo_FormClosing(object sender, FormClosingEventArgs e) {
            pictureBox1.Image?.Dispose();
        }
    }
}
