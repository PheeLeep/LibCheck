namespace LibCheck.Forms.SearchTools {
    public partial class DateRangeDialog : Form {
        internal DateTime From { get; private set; }
        internal DateTime To { get; private set; }

        public DateRangeDialog() {
            InitializeComponent();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e) {
            FromDateTimePicker.MaxDate = ToDateTimePicker.Value.AddDays(-1);
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e) {
            ToDateTimePicker.MinDate = FromDateTimePicker.Value;
        }

        private void DateRangeDialog_Load(object sender, EventArgs e) {
            FromDateTimePicker.MinDate = new DateTime(1970, 1, 1);
            From = FromDateTimePicker.Value;
            To = ToDateTimePicker.Value;
        }

        private void button1_Click(object sender, EventArgs e) {
            From = FromDateTimePicker.Value;
            To = ToDateTimePicker.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
