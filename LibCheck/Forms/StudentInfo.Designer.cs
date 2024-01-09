namespace LibCheck.Forms {
    partial class StudentInfo {
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
            panel1 = new Panel();
            StudentLabel = new Label();
            StudentIDLabel = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            ReturnBookButton = new Button();
            tabPage2 = new TabPage();
            EmailAddressLabel = new Label();
            DOBLabel = new Label();
            GenderLabel = new Label();
            LevelGradeSecLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(StudentLabel);
            panel1.Controls.Add(StudentIDLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 149);
            panel1.TabIndex = 1;
            // 
            // StudentLabel
            // 
            StudentLabel.Dock = DockStyle.Fill;
            StudentLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            StudentLabel.ForeColor = Color.White;
            StudentLabel.Location = new Point(0, 0);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(720, 107);
            StudentLabel.TabIndex = 1;
            StudentLabel.Text = "---";
            StudentLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.Dock = DockStyle.Bottom;
            StudentIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIDLabel.ForeColor = Color.White;
            StudentIDLabel.Location = new Point(0, 107);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new Size(720, 42);
            StudentIDLabel.TabIndex = 0;
            StudentIDLabel.Text = "---";
            StudentIDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 228);
            panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 228);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(712, 190);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books Borrowed";
            tabPage1.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(706, 152);
            dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(ReturnBookButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 32);
            panel3.TabIndex = 3;
            // 
            // ReturnBookButton
            // 
            ReturnBookButton.BackColor = Color.Lime;
            ReturnBookButton.Dock = DockStyle.Right;
            ReturnBookButton.FlatStyle = FlatStyle.Flat;
            ReturnBookButton.Location = new Point(530, 0);
            ReturnBookButton.Name = "ReturnBookButton";
            ReturnBookButton.Size = new Size(176, 32);
            ReturnBookButton.TabIndex = 3;
            ReturnBookButton.Text = "Return Book";
            ReturnBookButton.UseVisualStyleBackColor = false;
            ReturnBookButton.Click += ReturnBookButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(EmailAddressLabel);
            tabPage2.Controls.Add(DOBLabel);
            tabPage2.Controls.Add(GenderLabel);
            tabPage2.Controls.Add(LevelGradeSecLabel);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(712, 190);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Information";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EmailAddressLabel
            // 
            EmailAddressLabel.AutoSize = true;
            EmailAddressLabel.Location = new Point(38, 130);
            EmailAddressLabel.Name = "EmailAddressLabel";
            EmailAddressLabel.Size = new Size(128, 25);
            EmailAddressLabel.TabIndex = 4;
            EmailAddressLabel.Text = "Email Address:";
            EmailAddressLabel.DoubleClick += EmailAddressLabel_DoubleClick;
            // 
            // DOBLabel
            // 
            DOBLabel.AutoSize = true;
            DOBLabel.Location = new Point(38, 35);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(94, 25);
            DOBLabel.TabIndex = 3;
            DOBLabel.Text = "Birth Date:";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(38, 67);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(73, 25);
            GenderLabel.TabIndex = 1;
            GenderLabel.Text = "Gender:";
            // 
            // LevelGradeSecLabel
            // 
            LevelGradeSecLabel.AutoSize = true;
            LevelGradeSecLabel.Location = new Point(38, 99);
            LevelGradeSecLabel.Name = "LevelGradeSecLabel";
            LevelGradeSecLabel.Size = new Size(209, 25);
            LevelGradeSecLabel.TabIndex = 2;
            LevelGradeSecLabel.Text = "Level, Grade and Section:";
            // 
            // StudentInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(720, 377);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentInfo";
            FormClosing += StudentInfo_FormClosing;
            Load += StudentInfo_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label StudentLabel;
        private Label StudentIDLabel;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label EmailAddressLabel;
        private Label DOBLabel;
        private Label GenderLabel;
        private Label LevelGradeSecLabel;
        private DataGridView dataGridView1;
        private Button ReturnBookButton;
        private Panel panel3;
    }
}