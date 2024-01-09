namespace LibCheck.Forms.Admin.UserControls {
    partial class LogsDashboard {
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
            panel2 = new Panel();
            SaveButton = new Button();
            ClearLogButton = new Button();
            RefreshButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            FatalLabel = new CheckBox();
            ErrorCB = new CheckBox();
            WarnCB = new CheckBox();
            InfoLabel = new CheckBox();
            VerboseLabel = new CheckBox();
            panel1 = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            SFD = new SaveFileDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(ClearLogButton);
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 89);
            panel2.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.BackColor = Color.Transparent;
            SaveButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Image = Properties.Resources.save_32px;
            SaveButton.Location = new Point(707, 26);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(32, 32);
            SaveButton.TabIndex = 3;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ClearLogButton
            // 
            ClearLogButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearLogButton.BackColor = Color.Transparent;
            ClearLogButton.BackgroundImageLayout = ImageLayout.Zoom;
            ClearLogButton.FlatAppearance.BorderSize = 0;
            ClearLogButton.FlatStyle = FlatStyle.Flat;
            ClearLogButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearLogButton.Image = Properties.Resources.empty_trash_32px;
            ClearLogButton.Location = new Point(740, 26);
            ClearLogButton.Margin = new Padding(3, 2, 3, 2);
            ClearLogButton.Name = "ClearLogButton";
            ClearLogButton.Size = new Size(32, 32);
            ClearLogButton.TabIndex = 3;
            ClearLogButton.UseVisualStyleBackColor = false;
            ClearLogButton.Click += ClearLogButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RefreshButton.BackColor = Color.Transparent;
            RefreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.Image = Properties.Resources.refresh_32px;
            RefreshButton.Location = new Point(667, 26);
            RefreshButton.Margin = new Padding(3, 2, 3, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(32, 32);
            RefreshButton.TabIndex = 3;
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 19);
            label1.Name = "label1";
            label1.Size = new Size(567, 28);
            label1.TabIndex = 2;
            label1.Text = "Logs are automatically been written to the disk while in runtime.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_log_45;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(48, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 116);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(795, 279);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "All Logs";
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
            dataGridView1.Location = new Point(3, 61);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(789, 216);
            dataGridView1.TabIndex = 8;
            dataGridView1.VirtualMode = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(FatalLabel);
            panel3.Controls.Add(ErrorCB);
            panel3.Controls.Add(WarnCB);
            panel3.Controls.Add(InfoLabel);
            panel3.Controls.Add(VerboseLabel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 26);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(789, 35);
            panel3.TabIndex = 10;
            // 
            // FatalLabel
            // 
            FatalLabel.Checked = true;
            FatalLabel.CheckState = CheckState.Checked;
            FatalLabel.Dock = DockStyle.Left;
            FatalLabel.Image = Properties.Resources.radioactive_24px;
            FatalLabel.ImageAlign = ContentAlignment.MiddleLeft;
            FatalLabel.Location = new Point(352, 0);
            FatalLabel.Margin = new Padding(3, 2, 3, 2);
            FatalLabel.Name = "FatalLabel";
            FatalLabel.Size = new Size(88, 35);
            FatalLabel.TabIndex = 14;
            FatalLabel.Text = "0";
            FatalLabel.TextAlign = ContentAlignment.MiddleRight;
            FatalLabel.UseVisualStyleBackColor = true;
            FatalLabel.CheckedChanged += CBoxCheckedChanged;
            // 
            // ErrorCB
            // 
            ErrorCB.Checked = true;
            ErrorCB.CheckState = CheckState.Checked;
            ErrorCB.Dock = DockStyle.Left;
            ErrorCB.Image = Properties.Resources.cancel_24px;
            ErrorCB.ImageAlign = ContentAlignment.MiddleLeft;
            ErrorCB.Location = new Point(264, 0);
            ErrorCB.Margin = new Padding(3, 2, 3, 2);
            ErrorCB.Name = "ErrorCB";
            ErrorCB.Size = new Size(88, 35);
            ErrorCB.TabIndex = 13;
            ErrorCB.Text = "0";
            ErrorCB.TextAlign = ContentAlignment.MiddleRight;
            ErrorCB.UseVisualStyleBackColor = true;
            ErrorCB.CheckedChanged += CBoxCheckedChanged;
            // 
            // WarnCB
            // 
            WarnCB.Checked = true;
            WarnCB.CheckState = CheckState.Checked;
            WarnCB.Dock = DockStyle.Left;
            WarnCB.Image = Properties.Resources.error_24px;
            WarnCB.ImageAlign = ContentAlignment.MiddleLeft;
            WarnCB.Location = new Point(176, 0);
            WarnCB.Margin = new Padding(3, 2, 3, 2);
            WarnCB.Name = "WarnCB";
            WarnCB.Size = new Size(88, 35);
            WarnCB.TabIndex = 12;
            WarnCB.Text = "0";
            WarnCB.TextAlign = ContentAlignment.MiddleRight;
            WarnCB.UseVisualStyleBackColor = true;
            WarnCB.CheckedChanged += CBoxCheckedChanged;
            // 
            // InfoLabel
            // 
            InfoLabel.Checked = true;
            InfoLabel.CheckState = CheckState.Checked;
            InfoLabel.Dock = DockStyle.Left;
            InfoLabel.Image = Properties.Resources.info_24px;
            InfoLabel.ImageAlign = ContentAlignment.MiddleLeft;
            InfoLabel.Location = new Point(88, 0);
            InfoLabel.Margin = new Padding(3, 2, 3, 2);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(88, 35);
            InfoLabel.TabIndex = 11;
            InfoLabel.Text = "0";
            InfoLabel.TextAlign = ContentAlignment.MiddleRight;
            InfoLabel.UseVisualStyleBackColor = true;
            InfoLabel.CheckedChanged += CBoxCheckedChanged;
            // 
            // VerboseLabel
            // 
            VerboseLabel.Checked = true;
            VerboseLabel.CheckState = CheckState.Checked;
            VerboseLabel.Dock = DockStyle.Left;
            VerboseLabel.Image = Properties.Resources.audio_24px;
            VerboseLabel.ImageAlign = ContentAlignment.MiddleLeft;
            VerboseLabel.Location = new Point(0, 0);
            VerboseLabel.Margin = new Padding(3, 2, 3, 2);
            VerboseLabel.Name = "VerboseLabel";
            VerboseLabel.Size = new Size(88, 35);
            VerboseLabel.TabIndex = 10;
            VerboseLabel.Text = "0";
            VerboseLabel.TextAlign = ContentAlignment.MiddleRight;
            VerboseLabel.UseVisualStyleBackColor = true;
            VerboseLabel.CheckedChanged += CBoxCheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 89);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 27);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(200, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 27);
            button1.TabIndex = 4;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Left;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(88, 0);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(112, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 0;
            label2.Text = "Select Date:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SFD
            // 
            SFD.Filter = "Text File|*.txt";
            // 
            // LogsDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogsDashboard";
            Size = new Size(795, 395);
            Load += LogsDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button RefreshButton;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
        private Panel panel3;
        private CheckBox FatalLabel;
        private CheckBox ErrorCB;
        private CheckBox WarnCB;
        private Button SaveButton;
        private Button ClearLogButton;
        private SaveFileDialog SFD;
        private CheckBox VerboseLabel;
        private CheckBox InfoLabel;
    }
}
