using LibCheck.Forms.Admin;
using LibCheck.Modules.Security;

namespace LibCheck.Forms {
    public partial class AdminForm : Form {
        public AdminForm() {
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

        private void AdminForm_Load(object sender, EventArgs e) {
            WelcomeLabel.Text = $"Welcome, {Credentials.Librarian?.Username}!";
            booksDashboard1.Load();
            studentsDashboard1.Load();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e) {
            switch (MessageBox.Show(this, "Do you want to go back to main window, or exit the program?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    Modules.AppContext.Current.Switch();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    Database.Database.Unload();
                    Credentials.Unload();
                    Environment.Exit(0);
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    return;
            }
        }

        private void ChangeDashboards(UserControl uc) {
            if (StagePanel.Controls.GetChildIndex(uc) != 0)
                uc.BringToFront();
        }
        private void HomeButton_Click(object sender, EventArgs e) {
            ChangeDashboards(homeDashboard1);
        }

        private void BooksButton_Click(object sender, EventArgs e) {
            ChangeDashboards(booksDashboard1);
        }

        private void AccountRecoveryButton_Click(object sender, EventArgs e) {
            new AccountRecoveryDiag().ShowDialog(this);
        }

        private void StudentsButton_Click(object sender, EventArgs e) {
            ChangeDashboards(studentsDashboard1);
        }

        private void SettingsButton_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                cMS1.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {
            new ChangePasswordDiag().ShowDialog(this);
        }

        private void accountRecoveryToolStripMenuItem_Click(object sender, EventArgs e) {
            new AccountRecoveryDiag().ShowDialog(this);
        }

        private void EmailsButton_Click(object sender, EventArgs e) {
            ChangeDashboards(emailDashboard1);
        }
    }
}
