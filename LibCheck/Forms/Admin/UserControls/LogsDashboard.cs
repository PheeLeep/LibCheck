using LibCheck.Modules;
using System.Data;
using static LibCheck.Modules.Logger;

namespace LibCheck.Forms.Admin.UserControls {
    public partial class LogsDashboard : UserControl {

        private DateTime? specificDate = null;
        List<Logs>? tmplogs;
        public LogsDashboard() {
            InitializeComponent();
        }

        private void LogsDashboard_Load(object sender, EventArgs e) {
            while (!IsHandleCreated)
                Thread.Sleep(100);
            Reload();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            Reload();
        }

        internal void Reload() {
            dateTimePicker1.MaxDate = DateTime.MaxValue;
            tmplogs = AcquireLog();

            if (specificDate != null)
                tmplogs = tmplogs?.FindAll(s => s.Date.Date == specificDate.Value.Date);

            ResetView();
        }

        private void ResetView() {
            List<Logs> logs = new List<Logs>();
            if (tmplogs != null) {
                logs.AddRange(tmplogs.FindAll(s => s.Level == LogEnums.Verbose && VerboseLabel.Checked));
                logs.AddRange(tmplogs.FindAll(s => s.Level == LogEnums.Info && InfoLabel.Checked));
                logs.AddRange(tmplogs.FindAll(s => s.Level == LogEnums.Warn && WarnCB.Checked));
                logs.AddRange(tmplogs.FindAll(s => s.Level == LogEnums.Error && ErrorCB.Checked));
                logs.AddRange(tmplogs.FindAll(s => s.Level == LogEnums.Fatal && FatalLabel.Checked));
                logs = logs.OrderByDescending(s => s.Date).ToList();
            }

            dataGridView1.DataSource = logs;
            Miscellaneous.ResetDGVColumns(dataGridView1, false);
            VerboseLabel.Text = tmplogs?.FindAll(s => s.Level == LogEnums.Verbose).Count.ToString();
            InfoLabel.Text = tmplogs?.FindAll(s => s.Level == LogEnums.Info).Count.ToString();
            WarnCB.Text = tmplogs?.FindAll(s => s.Level == LogEnums.Warn).Count.ToString();
            ErrorCB.Text = tmplogs?.FindAll(s => s.Level == LogEnums.Error).Count.ToString();
            FatalLabel.Text = tmplogs?.FindAll(s => s.Level == LogEnums.Fatal).Count.ToString();
            groupBox1.Text = $"All logs{(specificDate == null ? "." : $" since {specificDate:dd/MM/yyyy}.")}";

            foreach (DataGridViewRow r in dataGridView1.Rows) {
                DataGridViewCell cell = r.Cells["Level"];
                switch ((LogEnums)cell.Value) {
                    case LogEnums.Verbose:
                        cell.Style.BackColor = Color.Blue;
                        cell.Style.ForeColor = Color.White;
                        break;
                    case LogEnums.Info:
                        cell.Style.BackColor = Color.Green;
                        cell.Style.ForeColor = Color.White;
                        break;
                    case LogEnums.Warn:
                        cell.Style.BackColor = Color.Yellow;
                        break;
                    case LogEnums.Error:
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.White;
                        break;
                    case LogEnums.Fatal:
                        cell.Style.BackColor = Color.Black;
                        cell.Style.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            specificDate = null;
            Reload();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            specificDate = dateTimePicker1.Value;
            Reload();
        }

        private void ClearLogButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "Do you want to clear logs?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;
            ClearLog();
            specificDate = null;
            Reload();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (ParentForm == null || dataGridView1.DataSource == null ||
                SFD.ShowDialog(this) != DialogResult.OK)
                return;
            List<Logs> logs = (List<Logs>)dataGridView1.DataSource;

            PleaseWait.RunInPleaseWait(ParentForm, new Action(() => {
                PleaseWait.SetPWDText("Saving logs...");
                try {
                    using (StreamWriter writer = new StreamWriter(SFD.FileName)) {
                        writer.WriteLine("Date:\tLevel:\tMessage:\n");
                        foreach (Logger.Logs l in logs)
                            writer.WriteLine($"{l.Date:dd/MM/yyyy hh:mm:ss tt}\t{l.Level}\t{l.Message}");
                        Log(LogEnums.Info, "Log saved.");
                    }
                } catch (Exception ex) {
                    Log(LogEnums.Error, $"Failed to save logs. ({ex.Message})");
                    MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }));
        }

        private void CBoxCheckedChanged(object sender, EventArgs e) {
            ResetView();
        }
    }
}
