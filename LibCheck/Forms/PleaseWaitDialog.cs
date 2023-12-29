namespace LibCheck.Forms
{
    public partial class PleaseWaitDialog : Form
    {

        internal bool IsProgressCompleted { get; set; } = false;
        public PleaseWaitDialog()
        {
            InitializeComponent();
        }

        internal void SetFormText(string text)
        {
            if (IsHandleCreated)
                label1.Text = text;
        }

        private void PleaseWaitDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsProgressCompleted)
                e.Cancel = true;

        }

        private void PleaseWaitDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
