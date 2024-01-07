using LibCheck.Database.Tables;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class NotifBar : UserControl {

        private Notifs? n;
        internal NotifBar(Notifs n) {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.n = n;
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Dispose();
            if (n != null) Notifs.DeleteLog(n);
        }

        private void NotifBar_Load(object sender, EventArgs e) {
            Disposed += NotifBar_Disposed;
            TextLabel.Text = n?.Message;
            CaptionLabel.Text = $"{n?.Date:dd/MM/yyyy hh:mm tt} ({n?.Caption})";
        }

        private void NotifBar_Disposed(object? sender, EventArgs e) {
            n = null;
            Disposed -= NotifBar_Disposed;
        }
    }
}
