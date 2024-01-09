namespace LibCheck.Forms.SearchTools {
    partial class DateRangeDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            FromDateTimePicker = new DateTimePicker();
            ToDateTimePicker = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 40);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Format = DateTimePickerFormat.Short;
            FromDateTimePicker.Location = new Point(128, 37);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(250, 31);
            FromDateTimePicker.TabIndex = 1;
            FromDateTimePicker.ValueChanged += FromDateTimePicker_ValueChanged;
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Format = DateTimePickerFormat.Short;
            ToDateTimePicker.Location = new Point(128, 74);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(250, 31);
            ToDateTimePicker.TabIndex = 3;
            ToDateTimePicker.ValueChanged += ToDateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 77);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(332, 129);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 4;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DateRangeDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(454, 176);
            Controls.Add(button1);
            Controls.Add(ToDateTimePicker);
            Controls.Add(label2);
            Controls.Add(FromDateTimePicker);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DateRangeDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select a Date Range";
            Load += DateRangeDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker FromDateTimePicker;
        private DateTimePicker ToDateTimePicker;
        private Label label2;
        private Button button1;
    }
}