namespace LibCheck.Forms.Admin {
    partial class StudentDialog {
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
            StudIDTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            DOBDatePicker = new DateTimePicker();
            label11 = new Label();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            LastNameTextBox = new TextBox();
            SuffixCombobox = new ComboBox();
            label4 = new Label();
            MiddleNameTextBox = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            LevelComboBox = new ComboBox();
            EmailAddressTextBox = new TextBox();
            label10 = new Label();
            GradeSecTextBox = new TextBox();
            label7 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            ConfirmButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StudIDTextBox
            // 
            StudIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudIDTextBox.Location = new Point(190, 37);
            StudIDTextBox.Name = "StudIDTextBox";
            StudIDTextBox.Size = new Size(249, 23);
            StudIDTextBox.TabIndex = 5;
            StudIDTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 6;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FirstNameTextBox.Location = new Point(190, 72);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(249, 23);
            FirstNameTextBox.TabIndex = 7;
            FirstNameTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(DOBDatePicker);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(FemaleRadioButton);
            groupBox1.Controls.Add(MaleRadioButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(LastNameTextBox);
            groupBox1.Controls.Add(SuffixCombobox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(MiddleNameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FirstNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(StudIDTextBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 313);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student:";
            // 
            // DOBDatePicker
            // 
            DOBDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DOBDatePicker.Format = DateTimePickerFormat.Short;
            DOBDatePicker.Location = new Point(190, 247);
            DOBDatePicker.Name = "DOBDatePicker";
            DOBDatePicker.Size = new Size(143, 23);
            DOBDatePicker.TabIndex = 20;
            DOBDatePicker.ValueChanged += Controls_ValuesChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 253);
            label11.Name = "label11";
            label11.Size = new Size(40, 17);
            label11.TabIndex = 19;
            label11.Text = "DOB:";
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(264, 214);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(74, 21);
            FemaleRadioButton.TabIndex = 18;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            FemaleRadioButton.CheckedChanged += Controls_ValuesChanged;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(190, 214);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(58, 21);
            MaleRadioButton.TabIndex = 17;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            MaleRadioButton.CheckedChanged += Controls_ValuesChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 216);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 16;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 180);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 15;
            label5.Text = "Suffix:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LastNameTextBox.Location = new Point(190, 142);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(249, 23);
            LastNameTextBox.TabIndex = 11;
            LastNameTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // SuffixCombobox
            // 
            SuffixCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SuffixCombobox.FormattingEnabled = true;
            SuffixCombobox.Items.AddRange(new object[] { "(none)", "JR.", "SR.", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" });
            SuffixCombobox.Location = new Point(190, 177);
            SuffixCombobox.Name = "SuffixCombobox";
            SuffixCombobox.Size = new Size(86, 23);
            SuffixCombobox.TabIndex = 14;
            SuffixCombobox.SelectedValueChanged += Controls_ValuesChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 145);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 12;
            label4.Text = "Last Name:";
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MiddleNameTextBox.Location = new Point(190, 107);
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(249, 23);
            MiddleNameTextBox.TabIndex = 9;
            MiddleNameTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 110);
            label3.Name = "label3";
            label3.Size = new Size(152, 17);
            label3.TabIndex = 10;
            label3.Text = "Middle Name (opt):";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(LevelComboBox);
            groupBox2.Controls.Add(EmailAddressTextBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(GradeSecTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 178);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Information";
            // 
            // LevelComboBox
            // 
            LevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LevelComboBox.FormattingEnabled = true;
            LevelComboBox.Location = new Point(190, 37);
            LevelComboBox.Name = "LevelComboBox";
            LevelComboBox.Size = new Size(249, 23);
            LevelComboBox.TabIndex = 19;
            LevelComboBox.SelectedValueChanged += Controls_ValuesChanged;
            // 
            // EmailAddressTextBox
            // 
            EmailAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailAddressTextBox.Location = new Point(190, 107);
            EmailAddressTextBox.Name = "EmailAddressTextBox";
            EmailAddressTextBox.Size = new Size(249, 23);
            EmailAddressTextBox.TabIndex = 9;
            EmailAddressTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 110);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 10;
            label10.Text = "Email:";
            // 
            // GradeSecTextBox
            // 
            GradeSecTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GradeSecTextBox.Location = new Point(190, 72);
            GradeSecTextBox.Name = "GradeSecTextBox";
            GradeSecTextBox.Size = new Size(249, 23);
            GradeSecTextBox.TabIndex = 7;
            GradeSecTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 40);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 8;
            label7.Text = "Level:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 75);
            label12.Name = "label12";
            label12.Size = new Size(152, 17);
            label12.TabIndex = 8;
            label12.Text = "Grade and Section:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(ConfirmButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 491);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 69);
            panel1.TabIndex = 11;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConfirmButton.BackColor = Color.LimeGreen;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(331, 18);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(107, 37);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Add";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // StudentDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(463, 560);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student";
            Load += StudentDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox StudIDTextBox;
        private Label label1;
        private Label label2;
        private TextBox FirstNameTextBox;
        private GroupBox groupBox1;
        private TextBox MiddleNameTextBox;
        private Label label3;
        private TextBox LastNameTextBox;
        private Label label4;
        private ComboBox SuffixCombobox;
        private Label label5;
        private Label label6;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private GroupBox groupBox2;
        private TextBox EmailAddressTextBox;
        private Label label10;
        private TextBox GradeSecTextBox;
        private Label label12;
        private DateTimePicker DOBDatePicker;
        private Label label11;
        private ComboBox LevelComboBox;
        private Label label7;
        private Panel panel1;
        private Button ConfirmButton;
    }
}