namespace LibCheck.Forms {
    public partial class DimForm : Form {
        private Bitmap _bitmap;
        public DimForm(Bitmap bmp) {
            InitializeComponent();
            _bitmap = bmp;
        }

        private void DimForm_Load(object sender, EventArgs e) {
            pictureBox1.Image = _bitmap;
            pictureBox1.Refresh();
        }

        private void DimForm_FormClosing(object sender, FormClosingEventArgs e) {
            pictureBox1.Image = null;
            _bitmap.Dispose();
        }
    }
}
