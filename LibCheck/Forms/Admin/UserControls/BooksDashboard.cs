using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class BooksDashboard : UserControl {
        public BooksDashboard() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        internal new void Load() {

            if (Database.Database.Read(out List<Books>? infos) >= 0 && infos != null) {
                CurrentlyBorrowedLabel.Text = infos.Count(book => {
                    if (book == null || string.IsNullOrWhiteSpace(book.StudentID)) return false;
                    return !book.StudentID.Equals("(none)");
                }).ToString();

                DamagedLabel.Text = infos.Count(book => {
                    if (string.IsNullOrWhiteSpace(book.StudentID)) return false;
                    if (book.IsLostOrDamaged) return true;
                    if (!book.StudentID.Equals("(none)") && DateTime.Now > book.DateToReturn) return true;
                    return false;
                }).ToString();

                dataGridView1.DataSource = infos;
                Logger.Log(Logger.LogEnums.Verbose, $"{GetType().Name} info loaded.");
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    dataGridView1.Columns[i].Visible = false;

                dataGridView1.Columns["ISBN"].Visible = true;
                dataGridView1.Columns["Title"].Visible = true;
                dataGridView1.Columns["Author"].Visible = true;
                dataGridView1.Columns["SafeDatePublished"].Visible = true;
                dataGridView1.Columns["SafeDatePublished"].HeaderText = "Date Published";
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            using (BooksDialog bdg = new BooksDialog(Miscellaneous.DatabaseMode.Add)) {
                if (bdg.ShowDialog(this) == DialogResult.OK) {
                    Logger.Log(Logger.LogEnums.Verbose, $"A book was added. Reloading...");
                    Load();
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;
                string? isbn = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
                if (string.IsNullOrWhiteSpace(isbn))
                    return;
                using (BooksDialog bdg = new BooksDialog(Miscellaneous.DatabaseMode.Update, isbn)) {
                    if (bdg.ShowDialog(this) == DialogResult.OK) {
                        Logger.Log(Logger.LogEnums.Verbose, $"A book was updated. Reloading...");
                        Load();
                    }
                }
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to update a book. ({ex.Message})");
                MessageBox.Show(this, $"Failed to update.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;
                string? isbn = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
                if (string.IsNullOrWhiteSpace(isbn))
                    return;
                if (Database.Database.Read(out List<Books>? b, whereCond: $"ISBN = '{isbn}'") != 1
                    || b == null) return;

                Books br = b[0];
                if (!string.IsNullOrWhiteSpace(br.StudentID) && !br.StudentID.Equals("(none)")) {
                    MessageBox.Show(this, "Unable to delete as the book was borrowed by someone.",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Logger.Log(Logger.LogEnums.Warn, $"Unable to delete as the book was borrowed by someone.");
                    return;
                }

                if (MessageBox.Show(this, $"Do you want to delete '{isbn}'? The printed QR code will invalidate.",
                                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;

                if (!Database.Database.Delete<Books>(isbn))
                    throw new InvalidOperationException("Couldn't remove a book from the database.");
                Logger.Log(Logger.LogEnums.Warn, "Book was deleted. Reloading...");
                Load();
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to delete a book. ({ex.Message})");
                MessageBox.Show(this, $"Failed to delete.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count == 0)
                    return;
                string? isbn = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
                if (string.IsNullOrWhiteSpace(isbn))
                    return;
                using (BookInfo bInfo = new BookInfo(isbn))
                    if (bInfo.ShowDialog() == DialogResult.OK)
                        Load();
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to read a book. ({ex.Message})");
                MessageBox.Show(this, $"Failed to read.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void PrintLabel_Click(object sender, EventArgs e) {
            if (ParentForm == null)
                return;

            if (dataGridView1.SelectedRows.Count != 1)
                return;
            string? isbn = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
            if (string.IsNullOrWhiteSpace(isbn))
                return;

            PleaseWait.RunInPleaseWait(ParentForm, () => {
                PleaseWait.SetPWDText("Please wait while generating QR...");
                try {
                    Bitmap? isbnCard = null;
                    using (Bitmap qr = QRCamModule.GenerateQR($"LC#{Credentials.Librarian?.SchoolGUID}#0#{isbn}")) {
                        isbnCard = new Bitmap(qr.Width, qr.Height + 50);
                        using (Graphics g = Graphics.FromImage(isbnCard)) {
                            g.FillRectangle(new SolidBrush(Color.White), 0, 0, isbnCard.Width, isbnCard.Height);
                            g.DrawImage(qr, new Point(0, 0));
                            g.Flush();

                            PleaseWait.SetPWDText("Writing the information...");
                            string isbnCompacted = "ISBN: " + isbn;
                            using (Font font = new Font("Calibri", 12)) {
                                SizeF txtSize = g.MeasureString(isbnCompacted, font);
                                PointF pF = new PointF((isbnCard.Width - txtSize.Width) / 2, qr.Height + 10);
                                g.DrawString(isbnCompacted, font, Brushes.Black, pF);
                            }
                        }
                    }
                    PleaseWait.SetPWDText("Done.");
                    Logger.Log(Logger.LogEnums.Info, "Book QR code generated.");
                    Task.Factory.StartNew(() => {
                        Task.Delay(10).Wait();
                        Invoke(new Action(() => new IDResultDialog(isbnCard).ShowDialog(this)));
                    });
                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, $"Failed to update a book. ({ex.Message})");
                    MessageBox.Show(this, $"Failed to print.\nCause: {ex.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            });
        }
    }
}
