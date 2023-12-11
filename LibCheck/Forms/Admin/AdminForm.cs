using LibCheck.Forms.Admin;

namespace LibCheck.Forms {
    public partial class AdminForm : Form {
        public AdminForm() {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            new ChangePasswordDiag().ShowDialog();
        }
    }
}
