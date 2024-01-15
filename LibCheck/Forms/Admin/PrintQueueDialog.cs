using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Drawing.Printing;

namespace LibCheck.Forms.Admin {
    public partial class PrintQueueDialog : Form {

        private List<PrintQueue>? queue;

        internal PrintQueueDialog(List<PrintQueue> queue) {
            InitializeComponent();
            this.queue = queue;
        }

        private void PrintQueueDialog_Load(object sender, EventArgs e) {
            while (!IsHandleCreated)
                Thread.Sleep(100);
            LoadItems();
        }

        private void LoadItems() {
            QueueLabel.Text = queue?.Count.ToString();
            dataGridView1.DataSource = queue;
            Miscellaneous.ResetDGVColumns(dataGridView1);
            dataGridView1.Columns["QueueName"].Visible = true;
            dataGridView1.Columns["QueueName"].HeaderText = "Queue";
        }

        private void PrintLabel_Click(object sender, EventArgs e) {
            if (queue == null || queue.Count == 0) return;
            PleaseWait.RunInPleaseWait(this, () => {
                try {
                    PleaseWait.SetPWDText("Initializing printing process..");
                    using (PrintDocument pDoc = new PrintDocument()) {

                        pDoc.PrintPage += new PrintPageEventHandler((s, e) => {
                            List<Bitmap> bmps = GenerateBitmaps();
                            while (bmps.Count > 0)
                                PrintImages(e, bmps);
                            Database.Database.DeleteAll<PrintQueue>();
                            Database.Database.Read(out queue);
                            LoadItems();
                        });

                        pDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
                        pDoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
                        pDoc.PrintController = new StandardPrintController();
                        printDialog1.Document = pDoc;

                        PleaseWait.SetPWDText("Waiting for printing confirmation...");
                        Invoke(new Action(() => {

                            if (printDialog1.ShowDialog(this) == DialogResult.OK) {
                                PleaseWait.SetPWDText("Printing..");
                                pDoc.Print();
                            }
                        }));
                    }
                } catch (Exception ex) {
                    Invoke(new Action(() => MessageBox.Show(this, $"Failed to print queued images.\n\n{ex.Message}",
                                                            "", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
                }
            });
        }

        private static void PrintImages(PrintPageEventArgs e, List<Bitmap> images) {
            float scalingFactor = 0.5f;

            int xPos = e.MarginBounds.Left;
            int yPos = e.MarginBounds.Top;

            while (images.Count > 0) {
                Bitmap bmp = images[0];
                try {
                    int scaledWidth = (int)(bmp.Width * scalingFactor);
                    int scaledHeight = (int)(bmp.Height * scalingFactor);

                    if (xPos + scaledWidth > e.MarginBounds.Right) {
                        xPos = e.MarginBounds.Left;
                        yPos += scaledHeight + 20;
                        if (yPos + scaledHeight > e.MarginBounds.Bottom) {
                            e.HasMorePages = true;
                            return;
                        }
                    }

                    e.Graphics?.DrawImage(bmp, new Rectangle(xPos, yPos, scaledWidth, scaledHeight));
                    xPos += scaledWidth + 20;
                    images.RemoveAt(0);
                } catch (Exception ex) {
                    images.RemoveAt(0);
                    Logger.Log(Logger.LogEnums.Error, $"Print Exception >> {ex.Message}");
                } finally {
                    try {
                        bmp.Dispose();
                    } catch {
                        // Ignore.
                    }
                }
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) return;
            string? queueName = dataGridView1.SelectedRows[0].Cells["QueueName"].Value.ToString();
            if (string.IsNullOrWhiteSpace(queueName)) return;
            PrintQueue? pq = queue?.FirstOrDefault(p => queueName.Equals(p.QueueName));
            if (pq == null) return;

            try {
                string imgPath = Path.Combine(EnvVars.PrintQueue.FullName, $"{queueName}");
                if (!File.Exists(imgPath))
                    throw new FileNotFoundException("Image not found.", imgPath);
                string hash = CryptComp.GenerateFileHash(imgPath);
                if (string.IsNullOrWhiteSpace(hash) || !hash.Equals(pq.HashSHA256))
                    throw new InvalidOperationException("Invalid image found.");
                using (Bitmap img = new Bitmap(imgPath))
                    new IDResultDialog(img, disablePrint: true).ShowDialog(this);

            } catch (Exception ex) {
                MessageBox.Show(this, $"Failed to open.\n\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (queue == null || queue.Count == 0 || dataGridView1.SelectedRows.Count == 0 ||
                MessageBox.Show(this, "Do you want to remove selected images?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
                string? isbn = row.Cells["QueueName"].Value.ToString();
                if (string.IsNullOrWhiteSpace(isbn)) continue;
                Database.Database.Delete<PrintQueue>(isbn);
            }
            Database.Database.Read(out queue);
            LoadItems();
        }

        private List<Bitmap> GenerateBitmaps() {
            List<Bitmap> bmps = new List<Bitmap>();
            if (queue == null || queue.Count == 0) return bmps;
            foreach (PrintQueue q in queue) {
                try {
                    string imgPath = Path.Combine(EnvVars.PrintQueue.FullName, $"{q.QueueName}");
                    if (!File.Exists(imgPath)) continue;
                    string hash = CryptComp.GenerateFileHash(imgPath);
                    if (string.IsNullOrWhiteSpace(hash) || !hash.Equals(q.HashSHA256)) continue;
                    bmps.Add(new Bitmap(imgPath));
                    PleaseWait.SetPWDText($"Added image. {q.QueueName}");
                    if (bmps[^1].Width == 1012 && bmps[^1].Height == 1276)
                        bmps[^1].RotateFlip(RotateFlipType.Rotate270FlipNone);
                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, $"Print >> {ex.Message}");
                }
            }

            PleaseWait.SetPWDText("Sorting size...");
            bmps.Sort(delegate (Bitmap bmp1, Bitmap bmp2) {
                if (bmp1 == null || bmp2 == null) return 0;
                int size1 = bmp1.Width * bmp1.Height;
                int size2 = bmp2.Width * bmp2.Height;
                return size1.CompareTo(size2);
            });

            return bmps;
        }
    }
}
