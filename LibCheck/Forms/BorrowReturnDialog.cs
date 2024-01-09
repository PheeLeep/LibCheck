using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Forms.SearchTools;
using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class BorrowReturnDialog : Form {

        private readonly bool lockISBNControls;
        private readonly bool lockStudIDControls;

        private Books? book;
        private Students? student;

        private readonly bool isBorrow;

        public BorrowReturnDialog(bool isBorrow, string? isbn = "", string? studentID = "") {
            InitializeComponent();
            this.isBorrow = isBorrow;

            if (!string.IsNullOrWhiteSpace(isbn)) {
                lockISBNControls = true;
                LoadStudBookInfo(typeof(Books), isbn);
            }
            if (!string.IsNullOrWhiteSpace(studentID)) {
                lockStudIDControls = true;
                LoadStudBookInfo(typeof(Students), studentID);
            }
        }

        private void LoadStudBookInfo(Type t, string val) {
            if (t == typeof(Books)) {
                if (Database.Database.Read(out List<Books>? bookInfo, whereCond: $"ISBN = '{val}'") <= 0
                    || bookInfo == null)
                    throw new BookNotFoundException(val);
                if (bookInfo[0].IsLostOrDamaged)
                    throw new BookNotFoundException("This book is currently lost or damaged.");

                book = bookInfo[0];

                if (isBorrow && !string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)"))
                    throw new BookNotFoundException("This book is currently borrowed.", book.ISBN);

                ISBNTextBox.Text = book.ISBN;
                BookTitleLabel.Text = $"Title: {book.Title}";

                if (!string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)")) {
                    if (book.DateToReturn == null)
                        throw new InvalidOperationException("Illegal data found.");

                    DateTime currentDate = DateTime.Now;
                    DateTime dueDate = book.DateToReturn.Value;

                    switch (Miscellaneous.CalculateDateExcptSun(currentDate, dueDate)) {
                        case int d when d < 3:
                            ReturnLabel.BackColor = Color.Red;
                            if (d < 0) {
                                int daysOverdue = Math.Abs(d);
                                double? priceOverdue = (Credentials.Librarian?.FeePerOverdueDay * daysOverdue);
                                if (priceOverdue.HasValue) {
                                    ReturnLabel.Text = $"The student must pay P{priceOverdue} overdue fee when returning their book.";
                                    break;
                                }
                                ReturnLabel.Text = "This student must notify them for overdue.";
                                break;
                            }
                            ReturnLabel.Text = "The student must return the book before the due.";
                            break;
                        case int d when d >= 3 && d < 7:
                            ReturnLabel.BackColor = Color.Orange;
                            ReturnLabel.Text = "This student must return a book to prevent due in a few days.";
                            break;
                        default:
                            ReturnLabel.BackColor = Color.Green;
                            ReturnLabel.Text = "Good!";
                            break;
                    }
                }
                return;
            }

            if (Database.Database.Read(out List<Students>? studInfo, whereCond: $"StudentID = '{val}'") <= 0 || studInfo == null)
                throw new StudentNotFoundException(val);
            student = studInfo[0];
            StudIDTextBox.Text = student.StudentID;
            StudNameLabel.Text = $"Name: {Miscellaneous.GenerateFullName(student, true)}";
        }

        private void BorrowReturnDialog_Load(object sender, EventArgs e) {
            if (isBorrow) {
                DateBorrowDTP.MinDate = DateTime.Now.AddDays(1);
                if (DateBorrowDTP.MinDate.DayOfWeek == DayOfWeek.Sunday)
                    DateBorrowDTP.MinDate = DateBorrowDTP.MinDate.AddDays(1);
                DateBorrowDTP.MaxDate = DateTime.Now.AddDays(31);
                if (DateBorrowDTP.MaxDate.DayOfWeek == DayOfWeek.Sunday)
                    DateBorrowDTP.MaxDate = DateBorrowDTP.MinDate.AddDays(-1);
            }
            BookGroupBox.Enabled = !lockISBNControls;
            groupBox1.Enabled = !lockStudIDControls;

            (!isBorrow ? ReturnPanel : BorrowPanel).BringToFront();
            ExecuteButton.Text = isBorrow ? "Borrow" : "Return";
        }

        private void BookBrowseBtn_Click(object sender, EventArgs e) {
            AcquireData(SearchDialog.SearchType.Book);
        }

        private void StudBrowseBtn_Click(object sender, EventArgs e) {
            AcquireData(SearchDialog.SearchType.Student);
        }

        private void AcquireData(SearchDialog.SearchType t) {
            if (t == SearchDialog.SearchType.All)
                return;
            using (SearchDialog sd = new SearchDialog(t, false, true)) {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value))
                    return;
                try {
                    LoadStudBookInfo(t == SearchDialog.SearchType.Student ? typeof(Students) : typeof(Books), sd.Value);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e) {
            try {
                if (book == null || book.IsLostOrDamaged)
                    throw new InvalidOperationException("No book provided or it was damaged.");
                if (student == null)
                    throw new InvalidOperationException("No student provided.");

                if (isBorrow) {
                    if (!string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)"))
                        throw new InvalidOperationException("This book is already borrowed by someone.");

                    if (Database.Database.Read<Books>(out _, whereCond: $"StudentID = {student.StudentID}") == 3)
                        throw new InvalidOperationException("This student reached its book borrowed limit.");

                    book.DateToReturn = DateBorrowDTP.Value;
                    book.StudentID = student.StudentID;
                    book.ThreeDayNoticeSent = false;

                    Records rBorrow = new Records() {
                        DateOccurred = DateTime.Now,
                        AdditionalContext = string.IsNullOrEmpty(richTextBox1.Text) ?
                                                    "(no additional context)" :
                                                    richTextBox1.Text,
                        ISBN = book.ISBN,
                        StudentID = student.StudentID,
                        Category = Records.RecordStatus.BookBorrowed
                    };

                    if (!Database.Database.Update(book) || !Database.Database.Insert(rBorrow))
                        throw new InvalidOperationException("Unable to execute the database.");

                    string body = Properties.Resources.BookBorrowedEmail
                                                       .Replace("%school%", Credentials.Librarian?.SchoolName)
                                                       .Replace("%isbn%", book.ISBN)
                                                       .Replace("%title%", book.Title)
                                                       .Replace("%author%", book.Author)
                                                       .Replace("%dateBorrow%", rBorrow.DateOccurred.ToString("dd/MM/yyyy"))
                                                       .Replace("%due%", book.DateToReturn?.ToString("dd/MM/yyyy"))
                                                       .Replace("%librarian%", Miscellaneous.GenerateFullName(Credentials.Librarian));
                    EmailService.Queue(student, body, "Book Borrowed");

                    if (!Modules.AppContext.IsInAdminMode)
                        Notifs.CreateNotification("Book Borrowed",
                                                  $"A student {Miscellaneous.GenerateFullName(student)} borrowed a book " +
                                                  $"{book.Title}.");
                    MessageBox.Show(this, "Book borrowed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Yes;
                    Close();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(book.StudentID)) {
                    if (book.StudentID.Equals("(none)"))
                        throw new InvalidOperationException("This book was not borrowed yet.");

                    if (!book.StudentID.Equals(student.StudentID))
                        throw new InvalidOperationException("This book was borrowed by someone that supposed to return it.");
                }

                if (DateTime.Now > book.DateToReturn &&
                    MessageBox.Show(this, "The student must pay an overdue fee before you proceed. Continue?"
                                          , "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;

                book.StudentID = "(none)";
                book.DateToReturn = null;
                book.ThreeDayNoticeSent = false;

                Records rReturn = new Records() {
                    DateOccurred = DateTime.Now,
                    AdditionalContext = string.IsNullOrEmpty(richTextBox1.Text) ?
                                                   "(no additional context)" :
                                                   richTextBox1.Text,
                    ISBN = book.ISBN,
                    StudentID = student.StudentID,
                    Category = Records.RecordStatus.BookReturned
                };

                if (!Database.Database.Update(book) || !Database.Database.Insert(rReturn))
                    throw new InvalidOperationException("Unable to execute the database.");

                if (!Modules.AppContext.IsInAdminMode)
                    Notifs.CreateNotification("Book Return",
                                              $"A student {Miscellaneous.GenerateFullName(student)} returned a book " +
                                              $"{book.Title}.");

                MessageBox.Show(this, "Book returned.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DateBorrowDTP_ValueChanged(object sender, EventArgs e) {
            if (DateBorrowDTP.Value.DayOfWeek == DayOfWeek.Sunday)
                DateBorrowDTP.Value = DateBorrowDTP.Value.AddDays(1);

        }
    }
}
