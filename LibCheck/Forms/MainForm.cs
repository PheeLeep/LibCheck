using LibCheck.Database.Tables;
using LibCheck.Exceptions;
using LibCheck.Forms.SearchTools;
using LibCheck.Modules;

namespace LibCheck.Forms {
    public partial class MainForm : Form {

        private readonly SearchDialog searchDiag;
        public MainForm() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            searchDiag = new SearchDialog(SearchDialog.SearchType.All, true);
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            SetDateTime();
            StagePanel.Controls.Add(searchDiag);
            searchDiag.Show();
        }

        private void SearchDiag_ValueDetected() {
            try {
                if (string.IsNullOrWhiteSpace(searchDiag.Value)) return;
                searchDiag.SuspendOp(false);
                timer2.Enabled = false;
                Form? f = null;
                switch (searchDiag.ResultSearchType) {
                    case SearchDialog.SearchType.Book:
                        f = new BookInfo(searchDiag.Value);
                        break;
                    case SearchDialog.SearchType.Student:
                        f = new StudentInfo(searchDiag.Value);
                        break;
                    default:
                        return;
                }

                f.FormClosing += (s, e) => {
                    Show();
                    searchDiag.ResumeOp();
                    timer2.Enabled = true;
                };

                Hide();
                f.ShowDialog();
            } catch (BookNotFoundException bnfe) {
                MessageBox.Show(this, $"Failed to find a book.\n\n{bnfe.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                searchDiag.ResumeOp();
                timer2.Enabled = true;
            } catch (StudentNotFoundException snfe) {
                MessageBox.Show(this, $"{snfe.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                searchDiag.ResumeOp();
                timer2.Enabled = true;
            }
        }

        private void ShowAdminButton_Click(object sender, EventArgs e) {
            if (!Modules.AppContext.Current.Switch())
                return;
            searchDiag.SuspendOp(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            timer1.Enabled = false;
            timer1.Enabled = false;
            searchDiag.SuspendOp(true);
            if (!Modules.AppContext.IsInAdminMode)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            SetDateTime();
        }

        private void SetDateTime() {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            DateLabel.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
        }

        private void timer2_Tick(object sender, EventArgs e) {
            SearchDiag_ValueDetected();
        }
    }
}
