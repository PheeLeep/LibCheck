using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Drawing.Imaging;

namespace LibCheck.Forms.Admin {
    public partial class IDResultDialog : Form {
        readonly Bitmap bmp;
        private readonly bool disablePrint;
        private readonly string pathName;
        public IDResultDialog(Bitmap bmp, string pathName = "", bool disablePrint = false) {
            InitializeComponent();
            this.bmp = bmp;
            this.disablePrint = disablePrint;
            this.pathName = pathName;
        }

        private void IDResultDialog_Load(object sender, EventArgs e) {
            pictureBox1.Image = bmp;
            if (disablePrint)
                AddToPrintQueue.Dispose();
        }

        private void IDResultDialog_FormClosing(object sender, FormClosingEventArgs e) {
            pictureBox1.Image = null;
            bmp.Dispose();
        }

        private void SaveImageButton_Click(object sender, EventArgs e) {
            try {
                if (SFD.ShowDialog() != DialogResult.OK) return;
                string extension = Path.GetExtension(SFD.FileName).ToLower();

                // Save the image based on the selected format
                switch (extension) {
                    case ".png":
                        pictureBox1.Image.Save(SFD.FileName, ImageFormat.Png);
                        break;
                    case ".jpg":
                        pictureBox1.Image.Save(SFD.FileName, ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        pictureBox1.Image.Save(SFD.FileName, ImageFormat.Bmp);
                        break;
                }
                MessageBox.Show(this, $"Image saved to '{SFD.FileName}'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(this, $"Failed to save.\n\nCause: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void AddToPrintQueue_Click(object sender, EventArgs e) {
            try {
                if (Database.Database.Read(out List<PrintQueue>? queues) > 0 && queues != null &&
                    queues.Any(q => pathName.Equals(q.QueueName)))
                    throw new InvalidOperationException("Queue already added.");

                if (!EnvVars.PrintQueue.Exists)
                    EnvVars.PrintQueue.Create();

                string path = Path.Combine(EnvVars.PrintQueue.FullName, pathName);
                pictureBox1.Image?.Save(path, ImageFormat.Jpeg);

                PrintQueue pq = new PrintQueue() {
                    QueueName = pathName,
                    HashSHA256 = CryptComp.GenerateFileHash(path)
                };

                if (!Database.Database.Insert(pq))
                    throw new InvalidOperationException("Failed to insert the queue.");

                MessageBox.Show(this, $"Image added to the print queue.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(this, $"Failed to add.\n\nCause: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
