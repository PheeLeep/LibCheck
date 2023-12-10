using System.Text;

namespace LibCheck.Forms {
    public partial class ErrorDialog : Form {
        private Exception ex;
        private StringBuilder log;
        private bool isSaved;
        public ErrorDialog(Exception ex, StringBuilder log, bool isSaved) {
            InitializeComponent();
            this.ex = ex;
            this.log = log;
            this.isSaved = isSaved;
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void ErrorDialog_Load(object sender, EventArgs e) {
            ErrorLabel.Text = ex.Message;
            richTextBox1.Text = log.ToString();
            if (!isSaved)
                CrashSaveInfoLabel.Text = "Unfortunately, the program unable to save the crash log," +
                                          " But you can able to copy the info and paste it on the Notepad.";
        }
    }
}
