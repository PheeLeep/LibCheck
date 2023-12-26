using LibCheck.Database.Tables;
using LibCheck.Modules;

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
            IEnumerable<Books>? infos = Modules.Database.Connection?.Query<Books>("SELECT * FROM Books");
            dataGridView1.DataSource = infos;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;

            dataGridView1.Columns["ISBN"].Visible = true;
            dataGridView1.Columns["Title"].Visible = true;
            dataGridView1.Columns["Author"].Visible = true;
            dataGridView1.Columns["DatePublished"].Visible = true;
            dataGridView1.Columns["DatePublished"].HeaderText = "Date Published";
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
                if (string.IsNullOrEmpty(isbn))
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
                if (string.IsNullOrEmpty(isbn))
                    return;
                if (MessageBox.Show(this, $"Do you want to delete '{isbn}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
                int? res = Modules.Database.Connection?.Delete<Books>(isbn);
                if (!res.HasValue || res != 1) {
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
                if (string.IsNullOrEmpty(isbn))
                    return;
                using (BooksDialog bdg = new BooksDialog(Miscellaneous.DatabaseMode.Read,
                                                  isbn)) {
                    if (bdg.ShowDialog(this) == DialogResult.OK) {
                        Load();
                    }
                }
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
            if (string.IsNullOrEmpty(isbn))
                return;

            PleaseWait.RunInPleaseWait(ParentForm, () => {
                PleaseWait.SetPWDText("Please wait while generating QR...");
                try {
                    Bitmap? isbnCard = null;
                    using (Bitmap qr = QRCamModule.GenerateQR($"LC#0#{isbn}")) {
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
