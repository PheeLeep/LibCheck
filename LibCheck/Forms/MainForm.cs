using LibCheck.Database.Tables;
using LibCheck.Modules;

namespace LibCheck.Forms {
    public partial class MainForm : Form {
        public MainForm() {
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

        private void MainForm_Load(object sender, EventArgs e) {
            Task.Run(() => {
                IEnumerable<LibrarianInfo>? infos = Modules.Database.Connection?
                                                    .Query<LibrarianInfo>("SELECT * FROM LibrarianInfo");
                if (infos == null || infos.Count() != 1) {
                    CrashControl.SCRAM(new InvalidOperationException("Corrupted information found!"));
                    return;
                }
                LibrarianInfo inf = infos.Take(1).ToArray()[0];
                Invoke(new Action(() => {
                    WelcomeLabel.Text = $"Welcome, {inf.Username}!";
                }));
            });
        }
    }
}
