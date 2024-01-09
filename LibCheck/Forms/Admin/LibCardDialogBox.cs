using System.Drawing.Imaging;

namespace LibCheck.Forms.Admin {
    public partial class LibCardDialogBox : Form {
        readonly Bitmap backLib;
        readonly Bitmap frontLib;

        public LibCardDialogBox(Bitmap frontLib, Bitmap backLib) {
            InitializeComponent();
            this.backLib = backLib;
            this.frontLib = frontLib;
        }

        private void LibCardDialogBox_Load(object sender, EventArgs e) {
            FrontPicBox.Image = frontLib;
            BackPicBox.Image = backLib;
        }

        private void LibCardDialogBox_FormClosing(object sender, FormClosingEventArgs e) {
            FrontPicBox.Image = null;
            frontLib.Dispose();
            BackPicBox.Image = null;
            backLib.Dispose();
        }

        private void SaveImageButton_Click(object sender, EventArgs e) {
            try {
                if (SFD.ShowDialog() != DialogResult.OK) return;
                string extension = Path.GetExtension(SFD.FileName).ToLower();

                using (Bitmap bmp = new Bitmap(frontLib.Width, frontLib.Height + backLib.Height)) {

                    using (Graphics g = Graphics.FromImage(bmp)) {
                        g.DrawImage(frontLib, new Point(0, 0));
                        g.Flush();
                        g.DrawImage(backLib, new Point(0, frontLib.Height));
                        g.Flush();
                    }

                    using (PictureBox pbx = new PictureBox()) {
                        pbx.Image = bmp;
                        // Save the image based on the selected format
                        switch (extension) {
                            case ".png":
                                pbx.Image.Save(SFD.FileName, ImageFormat.Png);
                                break;
                            case ".jpg":
                                pbx.Image.Save(SFD.FileName, ImageFormat.Jpeg);
                                break;
                            case ".bmp":
                                pbx.Image.Save(SFD.FileName, ImageFormat.Bmp);
                                break;
                        }
                    }
                }

            } catch (Exception ex) {
                MessageBox.Show(this, $"Failed to print.\n\nCause: {ex.Message}", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
