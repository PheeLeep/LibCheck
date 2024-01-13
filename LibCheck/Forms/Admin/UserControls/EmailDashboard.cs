using LibCheck.Database.Tables;
using LibCheck.Modules;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class EmailDashboard : UserControl {

        private ComposeDiag? _diag;
        private bool isLoaded = false;
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

        internal void LoadItems() {
            EmailQueueLabel.Text = EmailService.EmailQueueCount.ToString();
            CheckRecentEmails();
            CheckEmailValidation();
            isLoaded = true;
            Logger.Log(Logger.LogEnums.Verbose, $"{GetType().Name} info loaded.");
        }
        private void EmailDashboard_Load(object sender, EventArgs e) {
            Disposed += EmailDashboard_Disposed;
            EmailService.EmailQueueChanged += EmailService_EmailQueueChanged;
            LoadItems();
        }

        private void CheckEmailValidation() {
            EmailSignUpButton.Visible = !EmailService.IsInitialized;
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
            if (!Modules.AppContext.Auth() || MessageBox.Show(this, "Please use this feature responsibly! " +
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
            Miscellaneous.ResetDGVColumns(dataGridView1);

            dataGridView1.Columns["SafeDateOccurred"].HeaderText = "Date Occurred";
            dataGridView1.Columns["SafeDateOccurred"].Visible = true;
            dataGridView1.Columns["StudentID"].Visible = true;
            dataGridView1.Columns["MailTo"].Visible = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if (!isLoaded || dataGridView1.DataSource == null || e.RowIndex < 0)
                    return;
                List<RecentEmail> recentEmails = (List<RecentEmail>)dataGridView1.DataSource;
                using (ComposeDiag cd = new ComposeDiag(recentEmails[e.RowIndex])) {
                    cd.ShowDialog();
                }
            } catch (Exception ex) {
                Logger.Log(Logger.LogEnums.Error, $"Failed to read email. ({ex.Message})");
                MessageBox.Show(this, $"Failed to read email.\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void EmailSignUpButton_Click(object sender, EventArgs e) {
            EmailService.Initialize(Modules.AppContext.Current.MainForm);
        }
    }
}
