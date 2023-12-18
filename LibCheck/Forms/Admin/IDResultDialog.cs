using System.Drawing.Imaging;

namespace LibCheck.Forms.Admin {
    public partial class IDResultDialog : Form {
        Bitmap bmp;
        public IDResultDialog(Bitmap bmp) {
            InitializeComponent();
            this.bmp = bmp;
        }

        private void IDResultDialog_Load(object sender, EventArgs e) {
            pictureBox1.Image = bmp;
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
                MessageBox.Show(this, $"Failed to print.\n\nCause: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
