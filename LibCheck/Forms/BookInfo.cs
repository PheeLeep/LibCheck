using LibCheck.Database.Tables;
using LibCheck.Exceptions;

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
            book = infos.Take(1).ToArray()[0];
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
            richTextBox1.Text = book.Description;

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
            if (book == null || !Modules.AppContext.Auth()) return;
            string msg = book.IsLostOrDamaged ? "Make sure the book was found or replaced a new copy before you proceed. Continue?"
                                              : "This will mark as lost or damaged and marked violated to the student who are " +
                                                "currently borrowed. Continue?";
            if (MessageBox.Show(this, msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No) return;
            book.IsLostOrDamaged = !book.IsLostOrDamaged;
            if (!book.IsLostOrDamaged) {
                book.DateToReturn = null;
                book.StudentID = "(none)";
            }

            if (!Database.Database.Update(book)) {
                MessageBox.Show(this, "Failed to execute the database command.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
    }
}
