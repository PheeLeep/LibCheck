namespace LibCheck.Forms.Admin.UserControls.Statistics {
    partial class HistoryStatistics {
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
            groupBox3 = new GroupBox();
            ChartsRefreshButton = new Button();
            TransactComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            SaveButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 128, 255);
            groupBox3.Controls.Add(SaveButton);
            groupBox3.Controls.Add(ChartsRefreshButton);
            groupBox3.Controls.Add(TransactComboBox);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(862, 98);
            groupBox3.TabIndex = 2;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(862, 374);
            dataGridView1.TabIndex = 9;
            dataGridView1.VirtualMode = true;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Transparent;
            SaveButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Image = Properties.Resources.save_32px;
            SaveButton.Location = new Point(407, 40);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(32, 32);
            SaveButton.TabIndex = 5;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Comma-separated values|*.csv";
            // 
            // HistoryStatistics
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Name = "HistoryStatistics";
            Size = new Size(862, 472);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button ChartsRefreshButton;
        private ComboBox TransactComboBox;
        private DataGridView dataGridView1;
        private Button SaveButton;
        private SaveFileDialog saveFileDialog1;
    }
}
