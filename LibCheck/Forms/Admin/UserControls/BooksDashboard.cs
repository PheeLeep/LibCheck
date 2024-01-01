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
            using (BooksDialog bdg = new BooksDialog(Modules.Miscellaneous.DatabaseMode.Add)) {
                if (bdg.ShowDialog(this) == DialogResult.OK) {
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
                        Load();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                if (dataGridView1.SelectedRows.Count != 1)
                    return;
                string? isbn = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
                if (string.IsNullOrWhiteSpace(isbn))
                    return;
                if (MessageBox.Show(this, $"Do you want to delete '{isbn}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
                if (!Database.Database.Delete<Books>(isbn)) {
                    MessageBox.Show(this, "Failed to execute the database command.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                Load();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
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
                                g.DrawString(isbnCompacted, font, Brushes.Black, new PointF((isbnCard.Width - txtSize.Width) / 2, qr.Height + 10));
                            }
                        }
                    }
                    PleaseWait.SetPWDText("Done.");
                    Task.Factory.StartNew(() => {
                        Task.Delay(10).Wait();
                        Invoke(new Action(() => new IDResultDialog(isbnCard).ShowDialog(this)));
                    });
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
