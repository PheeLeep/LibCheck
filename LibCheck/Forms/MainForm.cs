using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class MainForm : Form {

        public MainForm() {
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

        private void MainForm_Load(object sender, EventArgs e) {
            SetDateTime();
            QRCamModule.NewFrame += QRCamModule_NewFrame;
            camComboBox.Items.AddRange(QRCamModule.ListInputDevices());
            camComboBox.SelectedIndex = 0;
        }

        private void QRCamModule_NewFrame(Bitmap bmp) {
            using (Bitmap oldBmp = (Bitmap)pictureBox1.Image)
                pictureBox1.Image = bmp; 
        }

        private void ShowAdminButton_Click(object sender, EventArgs e) {
            if (!Modules.AppContext.Current.Switch())
                return;
            QRCamModule.Stop();
            QRCamModule.NewFrame -= QRCamModule_NewFrame;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            timer1.Enabled = false;
            QRCamModule.Stop();
            QRCamModule.NewFrame -= QRCamModule_NewFrame;
           if (!Modules.AppContext.IsInAdminMode)
                Application.Exit();
        }

        private void camComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string? val = camComboBox.Items[camComboBox.SelectedIndex].ToString();
            if (string.IsNullOrEmpty(val))
                return;
            QRCamModule.Stop();
            QRCamModule.Start(val);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            SetDateTime();
        }

        private void SetDateTime() {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            DateLabel.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
        }
    }
}
