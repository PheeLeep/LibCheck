namespace LibCheck.Forms.SearchTools.UserControls {
    partial class StudentsSearchUC {
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
            groupBox1 = new GroupBox();
            LevelComboBox = new ComboBox();
            LevelCBox = new CheckBox();
            label1 = new Label();
            FemaleCBox = new CheckBox();
            MaleCBox = new CheckBox();
            groupBox2 = new GroupBox();
            ScanButton = new Button();
            LastNameRB = new RadioButton();
            FNameRB = new RadioButton();
            StudentIDRB = new RadioButton();
            keywordTextBox = new TextBox();
            groupBox3 = new GroupBox();
            CategoryRB = new RadioButton();
            KeywordRB = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LevelComboBox);
            groupBox1.Controls.Add(LevelCBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FemaleCBox);
            groupBox1.Controls.Add(MaleCBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(0, 252);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(400, 159);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search By Category";
            // 
            // LevelComboBox
            // 
            LevelComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LevelComboBox.Enabled = false;
            LevelComboBox.FormattingEnabled = true;
            LevelComboBox.Location = new Point(99, 79);
            LevelComboBox.Name = "LevelComboBox";
            LevelComboBox.Size = new Size(213, 31);
            LevelComboBox.TabIndex = 17;
            LevelComboBox.SelectedIndexChanged += LevelComboBox_SelectedIndexChanged;
            // 
            // LevelCBox
            // 
            LevelCBox.AutoSize = true;
            LevelCBox.Location = new Point(25, 81);
            LevelCBox.Margin = new Padding(2);
            LevelCBox.Name = "LevelCBox";
            LevelCBox.Size = new Size(74, 27);
            LevelCBox.TabIndex = 16;
            LevelCBox.Text = "Level:";
            LevelCBox.UseVisualStyleBackColor = true;
            LevelCBox.CheckedChanged += LevelCBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 15;
            label1.Text = "Gender:";
            // 
            // FemaleCBox
            // 
            FemaleCBox.AutoSize = true;
            FemaleCBox.Checked = true;
            FemaleCBox.CheckState = CheckState.Checked;
            FemaleCBox.Location = new Point(181, 46);
            FemaleCBox.Margin = new Padding(2);
            FemaleCBox.Name = "FemaleCBox";
            FemaleCBox.Size = new Size(86, 27);
            FemaleCBox.TabIndex = 13;
            FemaleCBox.Text = "Female";
            FemaleCBox.UseVisualStyleBackColor = true;
            FemaleCBox.CheckedChanged += GenderCheckBoxes;
            // 
            // MaleCBox
            // 
            MaleCBox.AutoSize = true;
            MaleCBox.Checked = true;
            MaleCBox.CheckState = CheckState.Checked;
            MaleCBox.Location = new Point(108, 46);
            MaleCBox.Margin = new Padding(2);
            MaleCBox.Name = "MaleCBox";
            MaleCBox.Size = new Size(69, 27);
            MaleCBox.TabIndex = 13;
            MaleCBox.Text = "Male";
            MaleCBox.UseVisualStyleBackColor = true;
            MaleCBox.CheckedChanged += GenderCheckBoxes;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ScanButton);
            groupBox2.Controls.Add(LastNameRB);
            groupBox2.Controls.Add(FNameRB);
            groupBox2.Controls.Add(StudentIDRB);
            groupBox2.Controls.Add(keywordTextBox);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 133);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search By Keyword";
            // 
            // ScanButton
            // 
            ScanButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScanButton.Location = new Point(311, 48);
            ScanButton.Name = "ScanButton";
            ScanButton.Size = new Size(75, 27);
            ScanButton.TabIndex = 7;
            ScanButton.Text = "Scan";
            ScanButton.UseVisualStyleBackColor = true;
            ScanButton.Click += ScanButton_Click;
            // 
            // LastNameRB
            // 
            LastNameRB.AutoSize = true;
            LastNameRB.Location = new Point(198, 80);
            LastNameRB.Name = "LastNameRB";
            LastNameRB.Size = new Size(112, 27);
            LastNameRB.TabIndex = 5;
            LastNameRB.Text = "Last Name";
            LastNameRB.UseVisualStyleBackColor = true;
            LastNameRB.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // FNameRB
            // 
            FNameRB.AutoSize = true;
            FNameRB.Location = new Point(83, 80);
            FNameRB.Name = "FNameRB";
            FNameRB.Size = new Size(113, 27);
            FNameRB.TabIndex = 3;
            FNameRB.Text = "First Name";
            FNameRB.UseVisualStyleBackColor = true;
            FNameRB.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // StudentIDRB
            // 
            StudentIDRB.AutoSize = true;
            StudentIDRB.Checked = true;
            StudentIDRB.Location = new Point(34, 80);
            StudentIDRB.Name = "StudentIDRB";
            StudentIDRB.Size = new Size(48, 27);
            StudentIDRB.TabIndex = 4;
            StudentIDRB.TabStop = true;
            StudentIDRB.Text = "ID";
            StudentIDRB.UseVisualStyleBackColor = true;
            StudentIDRB.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // keywordTextBox
            // 
            keywordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            keywordTextBox.Location = new Point(34, 48);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(271, 30);
            keywordTextBox.TabIndex = 2;
            keywordTextBox.TextChanged += keywordTextBox_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CategoryRB);
            groupBox3.Controls.Add(KeywordRB);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 119);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search Criteria";
            // 
            // CategoryRB
            // 
            CategoryRB.AutoSize = true;
            CategoryRB.Location = new Point(34, 66);
            CategoryRB.Name = "CategoryRB";
            CategoryRB.Size = new Size(179, 27);
            CategoryRB.TabIndex = 5;
            CategoryRB.Text = "Search by Category";
            CategoryRB.UseVisualStyleBackColor = true;
            CategoryRB.CheckedChanged += CriteriaRB_CheckedChanged;
            // 
            // KeywordRB
            // 
            KeywordRB.AutoSize = true;
            KeywordRB.Checked = true;
            KeywordRB.Location = new Point(34, 36);
            KeywordRB.Name = "KeywordRB";
            KeywordRB.Size = new Size(175, 27);
            KeywordRB.TabIndex = 4;
            KeywordRB.TabStop = true;
            KeywordRB.Text = "Search by Keyword";
            KeywordRB.UseVisualStyleBackColor = true;
            KeywordRB.CheckedChanged += CriteriaRB_CheckedChanged;
            // 
            // StudentsSearchUC
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "StudentsSearchUC";
            Size = new Size(400, 411);
            Load += StudentsSearchUC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox MaleCBox;
        private GroupBox groupBox2;
        private RadioButton LastNameRB;
        private RadioButton FNameRB;
        private RadioButton StudentIDRB;
        private TextBox keywordTextBox;
        private Label label1;
        private CheckBox FemaleCBox;
        private ComboBox LevelComboBox;
        private CheckBox LevelCBox;
        private Button ScanButton;
        private GroupBox groupBox3;
        private RadioButton CategoryRB;
        private RadioButton KeywordRB;
    }
}
