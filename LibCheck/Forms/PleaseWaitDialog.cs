namespace LibCheck.Forms {
    public partial class PleaseWaitDialog : Form {

        internal bool IsProgressCompleted { get; set; } = false;
        public PleaseWaitDialog(EventHandler? cancelHandler = null) {
            InitializeComponent();

            if (cancelHandler == null) {
                panel2.Dispose();
                return;
            }
            CancelBtn.Click += new EventHandler(cancelHandler);
        }

        internal void SetFormText(string text) {
            if (IsHandleCreated)
                label1.Text = text;
        }

        private void PleaseWaitDialog_FormClosing(object sender, FormClosingEventArgs e) {
            if (!IsProgressCompleted)
                e.Cancel = true;
        }

        private void PleaseWaitDialog_Load(object sender, EventArgs e) {

        }
    }
}
