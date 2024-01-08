using LibCheck.Database.Tables;
using LibCheck.Modules;

namespace LibCheck.Forms.Admin.UserControls
{
    public partial class StatisticsDashboard : UserControl
    {

        public StatisticsDashboard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void StatisticsDashboard_Load(object sender, EventArgs e)
        {
            while (!IsHandleCreated)
                Thread.Sleep(100);
            LoadData();
        }

        internal void LoadData()
        {
            if (Database.Database.Read(out List<Records>? r) == -1 || r == null ||
                Database.Database.Read(out List<Books>? b) == -1 || b == null ||
                Database.Database.Read(out List<Students>? s) == -1 || s == null)
            {
                Logger.Log(Logger.LogEnums.Error, "Failed to count data.");
                return;
            }

            trendsStatistics1.LoadData(s, b, r);
            transactStatistics1.LoadData(s, b, r);
            historyStatistics1.LoadData(s, b, r);
        }

        private void TrendsButton_Click(object sender, EventArgs e)
        {
            trendsStatistics1.BringToFront();
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            transactStatistics1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historyStatistics1.BringToFront();
        }
    }
}
