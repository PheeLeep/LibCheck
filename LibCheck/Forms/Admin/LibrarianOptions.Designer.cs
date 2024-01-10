namespace LibCheck.Forms.Admin {
    partial class LibrarianOptions {
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            LastLoggedInLabel = new Label();
            UsernameLabel = new Label();
            label15 = new Label();
            BDatePicker = new DateTimePicker();
            GenderCBox = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            LNameTxtBox = new TextBox();
            label12 = new Label();
            MNameTxtBox = new TextBox();
            label11 = new Label();
            FNameTxtBox = new TextBox();
            NextButton = new Button();
            tabPage2 = new TabPage();
            button1 = new Button();
            label1 = new Label();
            PesoAccureTextBox = new TextBox();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            GenerateLabel = new Label();
            GenerateButton = new Button();
            RemoveCodesButton = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ChangePassButton = new Button();
            tabPage4 = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            MitLinkLabel = new LinkLabel();
            linkLabel3 = new LinkLabel();
            PheeLeepLabel = new LinkLabel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SchoolNameLabel = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(521, 445);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LastLoggedInLabel);
            tabPage1.Controls.Add(UsernameLabel);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(BDatePicker);
            tabPage1.Controls.Add(GenderCBox);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(LNameTxtBox);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(MNameTxtBox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(FNameTxtBox);
            tabPage1.Controls.Add(NextButton);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(513, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LastLoggedInLabel
            // 
            LastLoggedInLabel.AutoSize = true;
            LastLoggedInLabel.BackColor = Color.Transparent;
            LastLoggedInLabel.Location = new Point(38, 60);
            LastLoggedInLabel.Name = "LastLoggedInLabel";
            LastLoggedInLabel.Size = new Size(126, 23);
            LastLoggedInLabel.TabIndex = 24;
            LastLoggedInLabel.Text = "Last Logged In:";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Location = new Point(38, 33);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(91, 23);
            UsernameLabel.TabIndex = 24;
            UsernameLabel.Text = "Username:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(38, 279);
            label15.Name = "label15";
            label15.Size = new Size(70, 23);
            label15.TabIndex = 23;
            label15.Text = "Gender:";
            // 
            // BDatePicker
            // 
            BDatePicker.Format = DateTimePickerFormat.Short;
            BDatePicker.Location = new Point(223, 240);
            BDatePicker.Name = "BDatePicker";
            BDatePicker.Size = new Size(240, 30);
            BDatePicker.TabIndex = 22;
            BDatePicker.ValueChanged += Controls_ValueChanged;
            // 
            // GenderCBox
            // 
            GenderCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderCBox.FormattingEnabled = true;
            GenderCBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderCBox.Location = new Point(223, 276);
            GenderCBox.Name = "GenderCBox";
            GenderCBox.Size = new Size(240, 31);
            GenderCBox.TabIndex = 21;
            GenderCBox.SelectedIndexChanged += Controls_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(38, 246);
            label14.Name = "label14";
            label14.Size = new Size(91, 23);
            label14.TabIndex = 20;
            label14.Text = "Birth Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(38, 207);
            label13.Name = "label13";
            label13.Size = new Size(178, 23);
            label13.TabIndex = 19;
            label13.Text = "Last Name (Required):";
            // 
            // LNameTxtBox
            // 
            LNameTxtBox.Location = new Point(223, 204);
            LNameTxtBox.Name = "LNameTxtBox";
            LNameTxtBox.Size = new Size(240, 30);
            LNameTxtBox.TabIndex = 18;
            LNameTxtBox.TextChanged += Controls_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(38, 171);
            label12.Name = "label12";
            label12.Size = new Size(117, 23);
            label12.TabIndex = 17;
            label12.Text = "Middle Name:";
            // 
            // MNameTxtBox
            // 
            MNameTxtBox.Location = new Point(223, 168);
            MNameTxtBox.Name = "MNameTxtBox";
            MNameTxtBox.Size = new Size(240, 30);
            MNameTxtBox.TabIndex = 16;
            MNameTxtBox.TextChanged += Controls_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(38, 135);
            label11.Name = "label11";
            label11.Size = new Size(179, 23);
            label11.TabIndex = 15;
            label11.Text = "First Name (Required):";
            // 
            // FNameTxtBox
            // 
            FNameTxtBox.Location = new Point(223, 132);
            FNameTxtBox.Name = "FNameTxtBox";
            FNameTxtBox.Size = new Size(240, 30);
            FNameTxtBox.TabIndex = 14;
            FNameTxtBox.TextChanged += Controls_ValueChanged;
            // 
            // NextButton
            // 
            NextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NextButton.BackColor = Color.FromArgb(0, 192, 0);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(334, 342);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(159, 44);
            NextButton.TabIndex = 13;
            NextButton.Text = "Update";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(PesoAccureTextBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(513, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Accure Due";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(319, 90);
            button1.Name = "button1";
            button1.Size = new Size(159, 44);
            button1.TabIndex = 18;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NextButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(336, 23);
            label1.TabIndex = 17;
            label1.Text = "Set the amount per overdue (in Phil. Peso):";
            // 
            // PesoAccureTextBox
            // 
            PesoAccureTextBox.Location = new Point(373, 41);
            PesoAccureTextBox.Name = "PesoAccureTextBox";
            PesoAccureTextBox.Size = new Size(105, 30);
            PesoAccureTextBox.TabIndex = 16;
            PesoAccureTextBox.TextChanged += Controls_ValueChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(513, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Security";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GenerateLabel);
            groupBox2.Controls.Add(GenerateButton);
            groupBox2.Controls.Add(RemoveCodesButton);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 176);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Recovery";
            // 
            // GenerateLabel
            // 
            GenerateLabel.Dock = DockStyle.Top;
            GenerateLabel.Location = new Point(3, 26);
            GenerateLabel.Name = "GenerateLabel";
            GenerateLabel.Padding = new Padding(10);
            GenerateLabel.Size = new Size(501, 79);
            GenerateLabel.TabIndex = 2;
            GenerateLabel.Text = "It is recommended to change password often. Account recovery codes were not affected when the password changes.";
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(261, 125);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(105, 29);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // RemoveCodesButton
            // 
            RemoveCodesButton.Location = new Point(372, 125);
            RemoveCodesButton.Name = "RemoveCodesButton";
            RemoveCodesButton.Size = new Size(105, 29);
            RemoveCodesButton.TabIndex = 0;
            RemoveCodesButton.Text = "Remove";
            RemoveCodesButton.UseVisualStyleBackColor = true;
            RemoveCodesButton.Click += RemoveCodesButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ChangePassButton);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Password";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(501, 79);
            label2.TabIndex = 1;
            label2.Text = "It is recommended to change password often. Account recovery codes were not affected when the password changes.";
            // 
            // ChangePassButton
            // 
            ChangePassButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ChangePassButton.Location = new Point(372, 108);
            ChangePassButton.Name = "ChangePassButton";
            ChangePassButton.Size = new Size(105, 31);
            ChangePassButton.TabIndex = 0;
            ChangePassButton.Text = "Change";
            ChangePassButton.UseVisualStyleBackColor = true;
            ChangePassButton.Click += ChangePassButton_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel1);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(513, 409);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "About";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(SchoolNameLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 244);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(MitLinkLabel);
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(PheeLeepLabel);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 178);
            panel2.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(223, 71);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(112, 23);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "CAMIILA0508";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(223, 43);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 23);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ajaxel8";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MitLinkLabel
            // 
            MitLinkLabel.AutoSize = true;
            MitLinkLabel.Location = new Point(193, 140);
            MitLinkLabel.Name = "MitLinkLabel";
            MitLinkLabel.Size = new Size(99, 23);
            MitLinkLabel.TabIndex = 3;
            MitLinkLabel.TabStop = true;
            MitLinkLabel.Text = "MIT License";
            MitLinkLabel.LinkClicked += MitLinkLabel_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(223, 115);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(91, 23);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "(click here)";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // PheeLeepLabel
            // 
            PheeLeepLabel.AutoSize = true;
            PheeLeepLabel.Location = new Point(223, 16);
            PheeLeepLabel.Name = "PheeLeepLabel";
            PheeLeepLabel.Size = new Size(84, 23);
            PheeLeepLabel.TabIndex = 3;
            PheeLeepLabel.TabStop = true;
            PheeLeepLabel.Text = "PheeLeep";
            PheeLeepLabel.LinkClicked += PheeLeepLabel_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 140);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 2;
            label7.Text = "This repo is under ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 115);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 2;
            label6.Text = "Repo Link:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 71);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 2;
            label5.Text = "Documentation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 43);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 1;
            label4.Text = "Designer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 16);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 1;
            label3.Text = "Programmer:";
            // 
            // SchoolNameLabel
            // 
            SchoolNameLabel.Dock = DockStyle.Top;
            SchoolNameLabel.Location = new Point(0, 0);
            SchoolNameLabel.Name = "SchoolNameLabel";
            SchoolNameLabel.Padding = new Padding(5);
            SchoolNameLabel.Size = new Size(507, 66);
            SchoolNameLabel.TabIndex = 0;
            SchoolNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LOGO_removebg_preview;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LibrarianOptions
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(521, 445);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LibrarianOptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            FormClosing += LibrarianOptions_FormClosing;
            Load += LibrarianOptions_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label15;
        private DateTimePicker BDatePicker;
        private ComboBox GenderCBox;
        private Label label14;
        private Label label13;
        private TextBox LNameTxtBox;
        private Label label12;
        private TextBox MNameTxtBox;
        private Label label11;
        private TextBox FNameTxtBox;
        private Button NextButton;
        private Label UsernameLabel;
        private Label LastLoggedInLabel;
        private Label label1;
        private TextBox PesoAccureTextBox;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button RemoveCodesButton;
        private Button ChangePassButton;
        private Label label2;
        private Button GenerateButton;
        private Label GenerateLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label SchoolNameLabel;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel PheeLeepLabel;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label6;
        private LinkLabel MitLinkLabel;
        private LinkLabel linkLabel3;
    }
}