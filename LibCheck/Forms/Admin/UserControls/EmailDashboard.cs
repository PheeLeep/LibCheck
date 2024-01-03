using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class EmailDashboard : UserControl {

        private ComposeDiag? _diag;
        public EmailDashboard() {
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

        private void EmailDashboard_Load(object sender, EventArgs e) {
            Disposed += EmailDashboard_Disposed;
            EmailService.EmailQueueChanged += EmailService_EmailQueueChanged;
            EmailQueueLabel.Text = EmailService.EmailQueueCount.ToString();
            CheckRecentEmails();
        }

        private void EmailDashboard_Disposed(object? sender, EventArgs e) {
            EmailService.EmailQueueChanged -= EmailService_EmailQueueChanged;
        }

        private void EmailService_EmailQueueChanged() {
            try {
                Invoke(new Action(() => {
                    EmailQueueLabel.Text = EmailService.EmailQueueCount.ToString();
                    CheckRecentEmails();
                }));
            } catch {
                Logger.Log(Logger.LogEnums.Warn, $"Failed to Invoke in {GetType().Name}");
            }
        }

        private void ComposeButton_Click(object sender, EventArgs e) {
            if (_diag != null) {
                _diag.BringToFront();
                _diag.WindowState = FormWindowState.Normal;
                _diag.Focus();
                return;
            }
            bool isAuthenticated = false;
            SecureDesktop.EnterSecureMode(() => {
                isAuthenticated = new AuthenticateDiag().ShowDialog() == DialogResult.Yes;
            });
            if (!isAuthenticated || MessageBox.Show(this, "Please use this feature responsibly! " +
                                                    "This will record what you're typing and unable to delete!", "",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            _diag = new ComposeDiag();
            _diag.FormClosed += (g, e) => {
                CheckRecentEmails();
                _diag = null;
            };
            _diag.Show();
        }

        private void CheckRecentEmails() {
            dataGridView1.DataSource = null;
            if (Database.Database.Read(out List<RecentEmail>? _recent) <= 0 || _recent == null)
                return;
            dataGridView1.DataSource = _recent;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;

            dataGridView1.Columns["DateOccurred"].HeaderText = "Date Occurred";
            dataGridView1.Columns["DateOccurred"].Visible = true;
            dataGridView1.Columns["StudentID"].Visible = true;
            dataGridView1.Columns["MailTo"].Visible = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if (dataGridView1.DataSource == null) return;
                List<RecentEmail> recentEmails = (List<RecentEmail>)dataGridView1.DataSource;
                using (ComposeDiag cd = new ComposeDiag(recentEmails[e.RowIndex])) {
                    cd.ShowDialog();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
