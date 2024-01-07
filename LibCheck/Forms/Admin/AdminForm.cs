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

        private bool ChangeDashboards(UserControl uc) {
            if (StagePanel.Controls.GetChildIndex(uc) == 0) return false;
            uc.BringToFront();
            uc.Focus();
            return true;
        }
        private void HomeButton_Click(object sender, EventArgs e) {
            if (ChangeDashboards(homeDashboard1))
                homeDashboard1.LoadItems();
        }

        private void BooksButton_Click(object sender, EventArgs e) {
            if (ChangeDashboards(booksDashboard1))
                booksDashboard1.Load();
        }

        private void AccountRecoveryButton_Click(object sender, EventArgs e) {
            new AccountRecoveryDiag().ShowDialog(this);
        }

        private void StudentsButton_Click(object sender, EventArgs e) {
            if (ChangeDashboards(studentsDashboard1))
                studentsDashboard1.Load();
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

        private void LogsButton_Click(object sender, EventArgs e) {
            ChangeDashboards(logsDashboard1);
        }

        private void StatsButton_Click(object sender, EventArgs e) {
            if (ChangeDashboards(statisticsDashboard1))
                statisticsDashboard1.LoadData();
        }
    }
}
