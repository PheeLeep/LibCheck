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
            doubleBufferedPanel1 = new Controls.DoubleBufferedPanel();
            ChartsButton = new Button();
            TrendsButton = new Button();
            doubleBufferedPanel3 = new Controls.DoubleBufferedPanel();
            trendsStatistics1 = new Statistics.TrendsStatistics();
            transactStatistics1 = new Statistics.TransactStatistics();
            doubleBufferedPanel1.SuspendLayout();
            doubleBufferedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // doubleBufferedPanel1
            // 
            doubleBufferedPanel1.BackColor = Color.FromArgb(128, 128, 255);
            doubleBufferedPanel1.Controls.Add(ChartsButton);
            doubleBufferedPanel1.Controls.Add(TrendsButton);
            doubleBufferedPanel1.Dock = DockStyle.Top;
            doubleBufferedPanel1.Location = new Point(0, 0);
            doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            doubleBufferedPanel1.Size = new Size(862, 50);
            doubleBufferedPanel1.TabIndex = 0;
            // 
            // ChartsButton
            // 
            ChartsButton.Dock = DockStyle.Left;
            ChartsButton.FlatStyle = FlatStyle.Flat;
            ChartsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ChartsButton.Image = Properties.Resources.icons8_graph_45;
            ChartsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ChartsButton.Location = new Point(169, 0);
            ChartsButton.Name = "ChartsButton";
            ChartsButton.Size = new Size(169, 50);
            ChartsButton.TabIndex = 0;
            ChartsButton.Text = "Transaction";
            ChartsButton.TextAlign = ContentAlignment.MiddleRight;
            ChartsButton.UseVisualStyleBackColor = true;
            ChartsButton.Click += TransactionsButton_Click;
            // 
            // TrendsButton
            // 
            TrendsButton.Dock = DockStyle.Left;
            TrendsButton.FlatStyle = FlatStyle.Flat;
            TrendsButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TrendsButton.Image = Properties.Resources.icons8_hashtag_45;
            TrendsButton.ImageAlign = ContentAlignment.MiddleLeft;
            TrendsButton.Location = new Point(0, 0);
            TrendsButton.Name = "TrendsButton";
            TrendsButton.Size = new Size(169, 50);
            TrendsButton.TabIndex = 1;
            TrendsButton.Text = "Trends";
            TrendsButton.TextAlign = ContentAlignment.MiddleRight;
            TrendsButton.UseVisualStyleBackColor = true;
            TrendsButton.Click += TrendsButton_Click;
            // 
            // doubleBufferedPanel3
            // 
            doubleBufferedPanel3.Controls.Add(trendsStatistics1);
            doubleBufferedPanel3.Controls.Add(transactStatistics1);
            doubleBufferedPanel3.Dock = DockStyle.Fill;
            doubleBufferedPanel3.Location = new Point(0, 50);
            doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            doubleBufferedPanel3.Size = new Size(862, 472);
            doubleBufferedPanel3.TabIndex = 2;
            // 
            // trendsStatistics1
            // 
            trendsStatistics1.BackColor = SystemColors.ActiveCaption;
            trendsStatistics1.Dock = DockStyle.Fill;
            trendsStatistics1.Location = new Point(0, 0);
            trendsStatistics1.Name = "trendsStatistics1";
            trendsStatistics1.Size = new Size(862, 472);
            trendsStatistics1.TabIndex = 5;
            // 
            // transactStatistics1
            // 
            transactStatistics1.BackColor = SystemColors.ActiveCaption;
            transactStatistics1.Dock = DockStyle.Fill;
            transactStatistics1.Location = new Point(0, 0);
            transactStatistics1.Name = "transactStatistics1";
            transactStatistics1.Size = new Size(862, 472);
            transactStatistics1.TabIndex = 2;
            // 
            // StatisticsDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(doubleBufferedPanel3);
            Controls.Add(doubleBufferedPanel1);
            DoubleBuffered = true;
            Name = "StatisticsDashboard";
            Size = new Size(862, 522);
            Load += StatisticsDashboard_Load;
            doubleBufferedPanel1.ResumeLayout(false);
            doubleBufferedPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.DoubleBufferedPanel doubleBufferedPanel1;
        private Button ChartsButton;
        private Button TrendsButton;
        private Controls.DoubleBufferedPanel doubleBufferedPanel3;
        private Statistics.TrendsStatistics trendsStatistics1;
        private Statistics.TransactStatistics transactStatistics1;
    }
}
