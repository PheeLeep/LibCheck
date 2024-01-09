using LibCheck.Database.Tables;
using LibCheck.Modules.Security;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class HomeDashboard : UserControl {
        public HomeDashboard() {
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

        private void HomeDashboard_Load(object sender, EventArgs e) {
            CheckNotifLatestCBox.Checked = true;
            LoadItems();
            Credentials.SetLastLoggedIn();
        }

        internal void LoadItems() {
            notifPanel.Controls.Clear();
            BooksLabel.Text = $"{Database.Database.Read<Books>(out _)}";
            StudentsLabel.Text = $"{Database.Database.Read<Students>(out _)}";
            // Get notifications
            if (Database.Database.Read(out List<Records>? infos,
                                        whereCond: $"Category = {(int)Records.RecordStatus.BookBorrowed}" +
                                                   $" OR Category = {(int)Records.RecordStatus.BookReturned}") >= 0
                                        && infos != null) {
                NBRLabel.Text = $"{infos.Count(s => s.DateOccurred == DateTime.Now &&
                                                    s.Category == Records.RecordStatus.BookReturned)}";

                NBBLabel.Text = $"{infos.Count(s => s.DateOccurred == DateTime.Now &&
                                                  s.Category == Records.RecordStatus.BookBorrowed)}";
                NotifsLabel.Text = $"{Notifs.Count()}";
                List<NotifBar> notifs = new List<NotifBar>();
                List<Notifs> lists = new List<Notifs>();
                lists.AddRange(Notifs.GetNotifications());

                if (CheckNotifLatestCBox.Checked)
                    lists = lists.Where(s => s.Date >= Credentials.Librarian?.LastLoggedIn).ToList();

                foreach (Notifs n in lists)
                    notifs.Add(new NotifBar(n));
                notifPanel.Controls.AddRange(notifs.ToArray());
                notifs.Clear();
            }
        }

        private void CheckNotifLatestCBox_CheckedChanged(object sender, EventArgs e) {
            LoadItems();
        }

        private void ClearLogButton_Click(object sender, EventArgs e) {
            Notifs.Clear();
            LoadItems();
        }

        private void BackButton_Click(object sender, EventArgs e) {
            MainPanel.BringToFront();
        }

        private void NotifControls_Click(object sender, EventArgs e) {
            NotifPanelMain.BringToFront();
        }
    }
}
