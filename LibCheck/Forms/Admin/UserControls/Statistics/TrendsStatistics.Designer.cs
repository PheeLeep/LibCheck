namespace LibCheck.Forms.Admin.UserControls.Statistics {
    partial class TrendsStatistics {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TrendsPanel = new Controls.DoubleBufferedPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BorrowPlot = new ScottPlot.FormsPlot();
            tabPage2 = new TabPage();
            ReturnPlot = new ScottPlot.FormsPlot();
            doubleBufferedPanel2 = new Controls.DoubleBufferedPanel();
            groupBox2 = new GroupBox();
            booksCListBox = new CheckedListBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            TrendsRefreshButton = new Button();
            TrendsDateRangeCBox = new ComboBox();
            TrendsPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            doubleBufferedPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TrendsPanel
            // 
            TrendsPanel.Controls.Add(tabControl1);
            TrendsPanel.Controls.Add(doubleBufferedPanel2);
            TrendsPanel.Dock = DockStyle.Fill;
            TrendsPanel.Location = new Point(0, 0);
            TrendsPanel.Margin = new Padding(2, 2, 2, 2);
            TrendsPanel.Name = "TrendsPanel";
            TrendsPanel.Size = new Size(690, 378);
            TrendsPanel.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(270, 0);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(420, 378);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BorrowPlot);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(412, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Borrow Rate";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BorrowPlot
            // 
            BorrowPlot.BackColor = Color.FromArgb(128, 128, 255);
            BorrowPlot.Dock = DockStyle.Fill;
            BorrowPlot.Location = new Point(2, 2);
            BorrowPlot.Margin = new Padding(4, 3, 4, 3);
            BorrowPlot.Name = "BorrowPlot";
            BorrowPlot.Size = new Size(408, 346);
            BorrowPlot.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ReturnPlot);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(411, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Return Rate";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReturnPlot
            // 
            ReturnPlot.BackColor = Color.FromArgb(128, 128, 255);
            ReturnPlot.Dock = DockStyle.Fill;
            ReturnPlot.Location = new Point(2, 2);
            ReturnPlot.Margin = new Padding(4, 3, 4, 3);
            ReturnPlot.Name = "ReturnPlot";
            ReturnPlot.Size = new Size(407, 346);
            ReturnPlot.TabIndex = 1;
            // 
            // doubleBufferedPanel2
            // 
            doubleBufferedPanel2.BackColor = Color.FromArgb(128, 128, 255);
            doubleBufferedPanel2.Controls.Add(groupBox2);
            doubleBufferedPanel2.Controls.Add(groupBox1);
            doubleBufferedPanel2.Dock = DockStyle.Left;
            doubleBufferedPanel2.Location = new Point(0, 0);
            doubleBufferedPanel2.Margin = new Padding(2, 2, 2, 2);
            doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            doubleBufferedPanel2.Size = new Size(270, 378);
            doubleBufferedPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(booksCListBox);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 78);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(270, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Books";
            // 
            // booksCListBox
            // 
            booksCListBox.Dock = DockStyle.Fill;
            booksCListBox.FormattingEnabled = true;
            booksCListBox.Location = new Point(2, 46);
            booksCListBox.Margin = new Padding(2, 2, 2, 2);
            booksCListBox.Name = "booksCListBox";
            booksCListBox.Size = new Size(266, 252);
            booksCListBox.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Top;
            checkBox1.Location = new Point(2, 22);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(266, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "All Books";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TrendsRefreshButton);
            groupBox1.Controls.Add(TrendsDateRangeCBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(270, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date Range";
            // 
            // TrendsRefreshButton
            // 
            TrendsRefreshButton.BackColor = Color.Transparent;
            TrendsRefreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            TrendsRefreshButton.FlatAppearance.BorderSize = 0;
            TrendsRefreshButton.FlatStyle = FlatStyle.Flat;
            TrendsRefreshButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TrendsRefreshButton.Image = Properties.Resources.refresh_32px;
            TrendsRefreshButton.Location = new Point(18, 34);
            TrendsRefreshButton.Margin = new Padding(2, 2, 2, 2);
            TrendsRefreshButton.Name = "TrendsRefreshButton";
            TrendsRefreshButton.Size = new Size(26, 26);
            TrendsRefreshButton.TabIndex = 4;
            TrendsRefreshButton.UseVisualStyleBackColor = false;
            TrendsRefreshButton.Click += TrendsRefreshButton_Click;
            // 
            // TrendsDateRangeCBox
            // 
            TrendsDateRangeCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TrendsDateRangeCBox.FormattingEnabled = true;
            TrendsDateRangeCBox.Items.AddRange(new object[] { "Today", "7 days", "14 days", "1 month", "All Time", "Custom" });
            TrendsDateRangeCBox.Location = new Point(52, 34);
            TrendsDateRangeCBox.Margin = new Padding(2, 2, 2, 2);
            TrendsDateRangeCBox.Name = "TrendsDateRangeCBox";
            TrendsDateRangeCBox.Size = new Size(205, 27);
            TrendsDateRangeCBox.TabIndex = 0;
            TrendsDateRangeCBox.SelectedIndexChanged += cboxDateRange_SelectedIndexChanged;
            // 
            // TrendsStatistics
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(TrendsPanel);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "TrendsStatistics";
            Size = new Size(690, 378);
            TrendsPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            doubleBufferedPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.DoubleBufferedPanel TrendsPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ScottPlot.FormsPlot BorrowPlot;
        private TabPage tabPage2;
        private ScottPlot.FormsPlot ReturnPlot;
        private Controls.DoubleBufferedPanel doubleBufferedPanel2;
        private GroupBox groupBox2;
        private CheckedListBox booksCListBox;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Button TrendsRefreshButton;
        private ComboBox TrendsDateRangeCBox;
    }
}
