namespace LibCheck.Forms.Admin.UserControls {
    partial class StatisticsDashboard {
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
            doubleBufferedPanel3 = new Controls.DoubleBufferedPanel();
            trendsStatistics1 = new Statistics.TrendsStatistics();
            historyStatistics1 = new Statistics.HistoryStatistics();
            transactStatistics1 = new Statistics.TransactStatistics();
            TrendsButton = new Button();
            ChartsButton = new Button();
            button1 = new Button();
            doubleBufferedPanel1 = new Controls.DoubleBufferedPanel();
            doubleBufferedPanel3.SuspendLayout();
            doubleBufferedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // doubleBufferedPanel3
            // 
            doubleBufferedPanel3.Controls.Add(trendsStatistics1);
            doubleBufferedPanel3.Controls.Add(historyStatistics1);
            doubleBufferedPanel3.Controls.Add(transactStatistics1);
            doubleBufferedPanel3.Dock = DockStyle.Fill;
            doubleBufferedPanel3.Location = new Point(0, 38);
            doubleBufferedPanel3.Margin = new Padding(3, 2, 3, 2);
            doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            doubleBufferedPanel3.Size = new Size(754, 354);
            doubleBufferedPanel3.TabIndex = 2;
            // 
            // trendsStatistics1
            // 
            trendsStatistics1.BackColor = SystemColors.ActiveCaption;
            trendsStatistics1.Dock = DockStyle.Fill;
            trendsStatistics1.Location = new Point(0, 0);
            trendsStatistics1.Margin = new Padding(2, 2, 2, 2);
            trendsStatistics1.Name = "trendsStatistics1";
            trendsStatistics1.Size = new Size(754, 354);
            trendsStatistics1.TabIndex = 5;
            // 
            // historyStatistics1
            // 
            historyStatistics1.BackColor = SystemColors.ActiveCaption;
            historyStatistics1.Dock = DockStyle.Fill;
            historyStatistics1.Location = new Point(0, 0);
            historyStatistics1.Margin = new Padding(2, 2, 2, 2);
            historyStatistics1.Name = "historyStatistics1";
            historyStatistics1.Size = new Size(754, 354);
            historyStatistics1.TabIndex = 3;
            // 
            // transactStatistics1
            // 
            transactStatistics1.BackColor = SystemColors.ActiveCaption;
            transactStatistics1.Dock = DockStyle.Fill;
            transactStatistics1.Location = new Point(0, 0);
            transactStatistics1.Margin = new Padding(2, 2, 2, 2);
            transactStatistics1.Name = "transactStatistics1";
            transactStatistics1.Size = new Size(754, 354);
            transactStatistics1.TabIndex = 2;
            // 
            // TrendsButton
            // 
            TrendsButton.Dock = DockStyle.Left;
            TrendsButton.FlatStyle = FlatStyle.Flat;
            TrendsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TrendsButton.Image = Properties.Resources.icons8_hashtag_45;
            TrendsButton.ImageAlign = ContentAlignment.MiddleLeft;
            TrendsButton.Location = new Point(0, 0);
            TrendsButton.Margin = new Padding(3, 2, 3, 2);
            TrendsButton.Name = "TrendsButton";
            TrendsButton.Size = new Size(148, 38);
            TrendsButton.TabIndex = 1;
            TrendsButton.Text = "Trends";
            TrendsButton.TextAlign = ContentAlignment.MiddleRight;
            TrendsButton.UseVisualStyleBackColor = true;
            TrendsButton.Click += TrendsButton_Click;
            // 
            // ChartsButton
            // 
            ChartsButton.Dock = DockStyle.Left;
            ChartsButton.FlatStyle = FlatStyle.Flat;
            ChartsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ChartsButton.Image = Properties.Resources.icons8_graph_45;
            ChartsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ChartsButton.Location = new Point(148, 0);
            ChartsButton.Margin = new Padding(3, 2, 3, 2);
            ChartsButton.Name = "ChartsButton";
            ChartsButton.Size = new Size(148, 38);
            ChartsButton.TabIndex = 0;
            ChartsButton.Text = "Transaction";
            ChartsButton.TextAlign = ContentAlignment.MiddleRight;
            ChartsButton.UseVisualStyleBackColor = true;
            ChartsButton.Click += TransactionsButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_history_45;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(296, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(148, 38);
            button1.TabIndex = 2;
            button1.Text = "History";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doubleBufferedPanel1
            // 
            doubleBufferedPanel1.BackColor = Color.FromArgb(128, 128, 255);
            doubleBufferedPanel1.Controls.Add(button1);
            doubleBufferedPanel1.Controls.Add(ChartsButton);
            doubleBufferedPanel1.Controls.Add(TrendsButton);
            doubleBufferedPanel1.Dock = DockStyle.Top;
            doubleBufferedPanel1.Location = new Point(0, 0);
            doubleBufferedPanel1.Margin = new Padding(3, 2, 3, 2);
            doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            doubleBufferedPanel1.Size = new Size(754, 38);
            doubleBufferedPanel1.TabIndex = 0;
            // 
            // StatisticsDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(doubleBufferedPanel3);
            Controls.Add(doubleBufferedPanel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StatisticsDashboard";
            Size = new Size(754, 392);
            Load += StatisticsDashboard_Load;
            doubleBufferedPanel3.ResumeLayout(false);
            doubleBufferedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Controls.DoubleBufferedPanel doubleBufferedPanel3;
        private Statistics.TrendsStatistics trendsStatistics1;
        private Statistics.TransactStatistics transactStatistics1;
        private Statistics.HistoryStatistics historyStatistics1;
        private Button TrendsButton;
        private Button ChartsButton;
        private Button button1;
        private Controls.DoubleBufferedPanel doubleBufferedPanel1;
    }
}
