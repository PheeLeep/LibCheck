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
    }
}
