namespace LibCheck.Forms.Admin.UserControls.Statistics {
    partial class TransactStatistics {
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
            TransactionsPanel = new Controls.DoubleBufferedPanel();
            ChartsPlot = new ScottPlot.FormsPlot();
            doubleBufferedPanel4 = new Controls.DoubleBufferedPanel();
            groupBox3 = new GroupBox();
            ChartsRefreshButton = new Button();
            TransactComboBox = new ComboBox();
            BorrowCBox = new CheckBox();
            ReturnCBox = new CheckBox();
            TransactionsPanel.SuspendLayout();
            doubleBufferedPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // TransactionsPanel
            // 
            TransactionsPanel.Controls.Add(ChartsPlot);
            TransactionsPanel.Controls.Add(doubleBufferedPanel4);
            TransactionsPanel.Dock = DockStyle.Fill;
            TransactionsPanel.Location = new Point(0, 0);
            TransactionsPanel.Name = "TransactionsPanel";
            TransactionsPanel.Size = new Size(862, 472);
            TransactionsPanel.TabIndex = 3;
            // 
            // ChartsPlot
            // 
            ChartsPlot.Dock = DockStyle.Fill;
            ChartsPlot.Location = new Point(0, 98);
            ChartsPlot.Margin = new Padding(5, 4, 5, 4);
            ChartsPlot.Name = "ChartsPlot";
            ChartsPlot.Size = new Size(862, 374);
            ChartsPlot.TabIndex = 1;
            // 
            // doubleBufferedPanel4
            // 
            doubleBufferedPanel4.BackColor = Color.FromArgb(128, 128, 255);
            doubleBufferedPanel4.Controls.Add(groupBox3);
            doubleBufferedPanel4.Dock = DockStyle.Top;
            doubleBufferedPanel4.Location = new Point(0, 0);
            doubleBufferedPanel4.Name = "doubleBufferedPanel4";
            doubleBufferedPanel4.Size = new Size(862, 98);
            doubleBufferedPanel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ReturnCBox);
            groupBox3.Controls.Add(BorrowCBox);
            groupBox3.Controls.Add(ChartsRefreshButton);
            groupBox3.Controls.Add(TransactComboBox);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(862, 98);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Date Range";
            // 
            // ChartsRefreshButton
            // 
            ChartsRefreshButton.BackColor = Color.Transparent;
            ChartsRefreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            ChartsRefreshButton.FlatAppearance.BorderSize = 0;
            ChartsRefreshButton.FlatStyle = FlatStyle.Flat;
            ChartsRefreshButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChartsRefreshButton.Image = Properties.Resources.refresh_32px;
            ChartsRefreshButton.Location = new Point(28, 42);
            ChartsRefreshButton.Name = "ChartsRefreshButton";
            ChartsRefreshButton.Size = new Size(32, 32);
            ChartsRefreshButton.TabIndex = 4;
            ChartsRefreshButton.UseVisualStyleBackColor = false;
            ChartsRefreshButton.Click += ChartsRefreshButton_Click;
            // 
            // TransactComboBox
            // 
            TransactComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactComboBox.FormattingEnabled = true;
            TransactComboBox.Items.AddRange(new object[] { "7 days", "14 days", "1 month", "All Time", "Custom" });
            TransactComboBox.Location = new Point(71, 42);
            TransactComboBox.Name = "TransactComboBox";
            TransactComboBox.Size = new Size(255, 33);
            TransactComboBox.TabIndex = 0;
            TransactComboBox.SelectedIndexChanged += TransactComboBox_SelectedIndexChanged;
            // 
            // BorrowCBox
            // 
            BorrowCBox.Image = Properties.Resources.icons8_book_borrowed_45;
            BorrowCBox.ImageAlign = ContentAlignment.MiddleLeft;
            BorrowCBox.Location = new Point(337, 26);
            BorrowCBox.Name = "BorrowCBox";
            BorrowCBox.Size = new Size(152, 61);
            BorrowCBox.TabIndex = 5;
            BorrowCBox.Text = "Borrow";
            BorrowCBox.TextAlign = ContentAlignment.MiddleRight;
            BorrowCBox.TextImageRelation = TextImageRelation.ImageBeforeText;
            BorrowCBox.UseVisualStyleBackColor = true;
            BorrowCBox.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // ReturnCBox
            // 
            ReturnCBox.Image = Properties.Resources.icons8_bookreturned_45;
            ReturnCBox.ImageAlign = ContentAlignment.MiddleLeft;
            ReturnCBox.Location = new Point(495, 26);
            ReturnCBox.Name = "ReturnCBox";
            ReturnCBox.Size = new Size(152, 61);
            ReturnCBox.TabIndex = 5;
            ReturnCBox.Text = "Return";
            ReturnCBox.TextAlign = ContentAlignment.MiddleRight;
            ReturnCBox.TextImageRelation = TextImageRelation.ImageBeforeText;
            ReturnCBox.UseVisualStyleBackColor = true;
            ReturnCBox.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // TransactStatistics
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(TransactionsPanel);
            Name = "TransactStatistics";
            Size = new Size(862, 472);
            TransactionsPanel.ResumeLayout(false);
            doubleBufferedPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.DoubleBufferedPanel TransactionsPanel;
        private ScottPlot.FormsPlot ChartsPlot;
        private Controls.DoubleBufferedPanel doubleBufferedPanel4;
        private GroupBox groupBox3;
        private Button ChartsRefreshButton;
        private ComboBox TransactComboBox;
        private CheckBox ReturnCBox;
        private CheckBox BorrowCBox;
    }
}
