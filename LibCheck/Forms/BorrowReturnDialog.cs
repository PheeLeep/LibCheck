using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Forms.SearchTools;
using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class BorrowReturnDialog : Form {
        private string? isbn;
        private string? studentID;

        private bool lockISBNControls;
        private bool lockStudIDControls;

        private Books? book;
        private Students? student;

        private readonly bool isBorrow;

        public BorrowReturnDialog(bool isBorrow, string? isbn = "", string? studentID = "") {
            InitializeComponent();
            this.isBorrow = isBorrow;
            this.isbn = isbn;
            this.studentID = studentID;

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
                if (Database.Database.Read(out List<Books>? bookInfo, whereCond: $"ISBN = '{val}'") <= 0 || bookInfo == null)
                    throw new BookNotFoundException(val);
                book = bookInfo.Take(1).ToArray()[0];
                ISBNTextBox.Text = book.ISBN;
                BookTitleLabel.Text = $"Title: {book.Title}";

                if (!string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)")) {
                    if (book.DateToReturn == null) throw new InvalidOperationException("Illegal data found.");

                    DateTime currentDate = DateTime.Now;
                    DateTime dueDate = book.DateToReturn.Value;

                    int daysDifference = (int)(dueDate - currentDate).TotalDays;

                    // Exclude Sundays from the count
                    for (int i = 0; i <= daysDifference; i++) {
                        DateTime currentDay = currentDate.AddDays(i);

                        if (currentDay.DayOfWeek == DayOfWeek.Sunday)
                            daysDifference--;
                    }

                    switch (daysDifference) {
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
            student = studInfo.Take(1).ToArray()[0];
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
            if (t == SearchDialog.SearchType.All) return;
            using (SearchDialog sd = new SearchDialog(t, false)) {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value)) return;
                try {
                    LoadStudBookInfo(t == SearchDialog.SearchType.Student ? typeof(Students) : typeof(Books), sd.Value);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e) {
            try {
                if (book == null || book.IsLostOrDamaged) throw new InvalidOperationException("No book provided or it was damaged.");
                if (student == null) throw new InvalidOperationException("No student provided.");

                if (!Modules.AppContext.Auth()) return;

                if (isBorrow) {
                    if (!string.IsNullOrWhiteSpace(book.StudentID) && !book.StudentID.Equals("(none)"))
                        throw new InvalidOperationException("This book is already borrowed by someone.");
                    book.DateToReturn = DateBorrowDTP.Value;
                    book.StudentID = student.StudentID;

                    if (!Database.Database.Update(book))
                        throw new InvalidOperationException("Unable to execute the database.");
                    MessageBox.Show("Book borrowed.");
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

                if (DateTime.Now > book.DateToReturn && MessageBox.Show(this, "The student must pay an overdue fee before you proceed. Continue?"
                                                                        , "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                                                        == DialogResult.No) return;
                book.StudentID = "(none)";
                book.DateToReturn = null;
                if (!Database.Database.Update(book))
                    throw new InvalidOperationException("Unable to execute the database.");
                MessageBox.Show("Book returned.");
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
