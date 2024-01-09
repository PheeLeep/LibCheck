namespace LibCheck.Forms {
    partial class RegisterLib {
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
            LowerPanel = new Panel();
            DescLabel = new Label();
            BulletProgressLabel = new Label();
            PrevButton = new Button();
            NextButton = new Button();
            StagePanel = new Panel();
            BasicInfoPanel = new Panel();
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
            label9 = new Label();
            label10 = new Label();
            PasswordPanel = new Panel();
            label19 = new Label();
            passReTypeTxtBox = new TextBox();
            label18 = new Label();
            ShowPassButton = new Button();
            passTxtBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            FinishPanel = new Panel();
            label16 = new Label();
            label17 = new Label();
            UsernamePanel = new Panel();
            usernameTxtBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SchoolPanel = new Panel();
            SchoolNameTextBox = new TextBox();
            label8 = new Label();
            WelcomePanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            LowerPanel.SuspendLayout();
            StagePanel.SuspendLayout();
            BasicInfoPanel.SuspendLayout();
            PasswordPanel.SuspendLayout();
            FinishPanel.SuspendLayout();
            UsernamePanel.SuspendLayout();
            SchoolPanel.SuspendLayout();
            WelcomePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LowerPanel
            // 
            LowerPanel.BackColor = Color.LavenderBlush;
            LowerPanel.Controls.Add(DescLabel);
            LowerPanel.Controls.Add(BulletProgressLabel);
            LowerPanel.Controls.Add(PrevButton);
            LowerPanel.Controls.Add(NextButton);
            LowerPanel.Dock = DockStyle.Bottom;
            LowerPanel.Location = new Point(0, 389);
            LowerPanel.Name = "LowerPanel";
            LowerPanel.Size = new Size(833, 94);
            LowerPanel.TabIndex = 0;
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Location = new Point(27, 47);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new Size(64, 18);
            DescLabel.TabIndex = 3;
            DescLabel.Text = "Welcome";
            // 
            // BulletProgressLabel
            // 
            BulletProgressLabel.AutoSize = true;
            BulletProgressLabel.Location = new Point(27, 22);
            BulletProgressLabel.Name = "BulletProgressLabel";
            BulletProgressLabel.Size = new Size(16, 18);
            BulletProgressLabel.TabIndex = 2;
            BulletProgressLabel.Text = "•";
            // 
            // PrevButton
            // 
            PrevButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrevButton.BackColor = SystemColors.ScrollBar;
            PrevButton.FlatAppearance.BorderSize = 0;
            PrevButton.FlatStyle = FlatStyle.Flat;
            PrevButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrevButton.Location = new Point(596, 28);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(44, 44);
            PrevButton.TabIndex = 1;
            PrevButton.Text = "<";
            PrevButton.UseVisualStyleBackColor = false;
            PrevButton.Click += PrevButton_Click;
            // 
            // NextButton
            // 
            NextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NextButton.BackColor = Color.FromArgb(0, 192, 0);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(651, 28);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(159, 44);
            NextButton.TabIndex = 0;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // StagePanel
            // 
            StagePanel.BackgroundImage = Properties.Resources.bg;
            StagePanel.Controls.Add(BasicInfoPanel);
            StagePanel.Controls.Add(PasswordPanel);
            StagePanel.Controls.Add(FinishPanel);
            StagePanel.Controls.Add(UsernamePanel);
            StagePanel.Controls.Add(SchoolPanel);
            StagePanel.Controls.Add(WelcomePanel);
            StagePanel.Dock = DockStyle.Fill;
            StagePanel.Location = new Point(0, 0);
            StagePanel.Name = "StagePanel";
            StagePanel.Size = new Size(833, 389);
            StagePanel.TabIndex = 1;
            // 
            // BasicInfoPanel
            // 
            BasicInfoPanel.BackColor = Color.Transparent;
            BasicInfoPanel.Controls.Add(label15);
            BasicInfoPanel.Controls.Add(BDatePicker);
            BasicInfoPanel.Controls.Add(GenderCBox);
            BasicInfoPanel.Controls.Add(label14);
            BasicInfoPanel.Controls.Add(label13);
            BasicInfoPanel.Controls.Add(LNameTxtBox);
            BasicInfoPanel.Controls.Add(label12);
            BasicInfoPanel.Controls.Add(MNameTxtBox);
            BasicInfoPanel.Controls.Add(label11);
            BasicInfoPanel.Controls.Add(FNameTxtBox);
            BasicInfoPanel.Controls.Add(label9);
            BasicInfoPanel.Controls.Add(label10);
            BasicInfoPanel.Dock = DockStyle.Fill;
            BasicInfoPanel.Location = new Point(0, 0);
            BasicInfoPanel.Name = "BasicInfoPanel";
            BasicInfoPanel.Size = new Size(833, 389);
            BasicInfoPanel.TabIndex = 4;
            BasicInfoPanel.Tag = "Basic Information";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(297, 214);
            label15.Name = "label15";
            label15.Size = new Size(96, 18);
            label15.TabIndex = 12;
            label15.Text = "Birth Date:";
            // 
            // BDatePicker
            // 
            BDatePicker.Format = DateTimePickerFormat.Short;
            BDatePicker.Location = new Point(51, 242);
            BDatePicker.Name = "BDatePicker";
            BDatePicker.Size = new Size(240, 25);
            BDatePicker.TabIndex = 11;
            // 
            // GenderCBox
            // 
            GenderCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderCBox.FormattingEnabled = true;
            GenderCBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderCBox.Location = new Point(297, 244);
            GenderCBox.Name = "GenderCBox";
            GenderCBox.Size = new Size(240, 26);
            GenderCBox.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(51, 214);
            label14.Name = "label14";
            label14.Size = new Size(96, 18);
            label14.TabIndex = 9;
            label14.Text = "Birth Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(543, 141);
            label13.Name = "label13";
            label13.Size = new Size(176, 18);
            label13.TabIndex = 7;
            label13.Text = "Last Name (Required):";
            // 
            // LNameTxtBox
            // 
            LNameTxtBox.Location = new Point(543, 169);
            LNameTxtBox.Name = "LNameTxtBox";
            LNameTxtBox.Size = new Size(240, 25);
            LNameTxtBox.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(297, 141);
            label12.Name = "label12";
            label12.Size = new Size(104, 18);
            label12.TabIndex = 5;
            label12.Text = "Middle Name:";
            // 
            // MNameTxtBox
            // 
            MNameTxtBox.Location = new Point(297, 169);
            MNameTxtBox.Name = "MNameTxtBox";
            MNameTxtBox.Size = new Size(240, 25);
            MNameTxtBox.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(48, 141);
            label11.Name = "label11";
            label11.Size = new Size(184, 18);
            label11.TabIndex = 3;
            label11.Text = "First Name (Required):";
            // 
            // FNameTxtBox
            // 
            FNameTxtBox.Location = new Point(51, 169);
            FNameTxtBox.Name = "FNameTxtBox";
            FNameTxtBox.Size = new Size(240, 25);
            FNameTxtBox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(51, 92);
            label9.Name = "label9";
            label9.Size = new Size(312, 18);
            label9.TabIndex = 1;
            label9.Text = "This requires for knowing who you are.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(45, 39);
            label10.Name = "label10";
            label10.Size = new Size(239, 32);
            label10.TabIndex = 0;
            label10.Text = "Setup Your Basic Info";
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.Transparent;
            PasswordPanel.Controls.Add(label19);
            PasswordPanel.Controls.Add(passReTypeTxtBox);
            PasswordPanel.Controls.Add(label18);
            PasswordPanel.Controls.Add(ShowPassButton);
            PasswordPanel.Controls.Add(passTxtBox);
            PasswordPanel.Controls.Add(label5);
            PasswordPanel.Controls.Add(label6);
            PasswordPanel.Dock = DockStyle.Fill;
            PasswordPanel.Location = new Point(0, 0);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(833, 389);
            PasswordPanel.TabIndex = 2;
            PasswordPanel.Tag = "Setup Password";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(90, 230);
            label19.Name = "label19";
            label19.Size = new Size(176, 18);
            label19.TabIndex = 6;
            label19.Text = "Re-type New Password:";
            // 
            // passReTypeTxtBox
            // 
            passReTypeTxtBox.Location = new Point(90, 258);
            passReTypeTxtBox.MaxLength = 64;
            passReTypeTxtBox.Name = "passReTypeTxtBox";
            passReTypeTxtBox.Size = new Size(550, 25);
            passReTypeTxtBox.TabIndex = 5;
            passReTypeTxtBox.UseSystemPasswordChar = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(90, 153);
            label18.Name = "label18";
            label18.Size = new Size(112, 18);
            label18.TabIndex = 4;
            label18.Text = "New Password:";
            // 
            // ShowPassButton
            // 
            ShowPassButton.BackColor = SystemColors.ScrollBar;
            ShowPassButton.FlatAppearance.BorderSize = 0;
            ShowPassButton.FlatStyle = FlatStyle.Flat;
            ShowPassButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPassButton.Image = Properties.Resources.Reg_ShowPass;
            ShowPassButton.Location = new Point(651, 181);
            ShowPassButton.Name = "ShowPassButton";
            ShowPassButton.Size = new Size(50, 32);
            ShowPassButton.TabIndex = 3;
            ShowPassButton.UseVisualStyleBackColor = false;
            ShowPassButton.MouseDown += ShowPassButton_MouseDown;
            ShowPassButton.MouseUp += ShowPassButton_MouseUp;
            // 
            // passTxtBox
            // 
            passTxtBox.Location = new Point(90, 181);
            passTxtBox.MaxLength = 64;
            passTxtBox.Name = "passTxtBox";
            passTxtBox.Size = new Size(550, 25);
            passTxtBox.TabIndex = 2;
            passTxtBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 92);
            label5.Name = "label5";
            label5.Size = new Size(432, 18);
            label5.TabIndex = 1;
            label5.Text = "Setup your password. (at least 8 characters required)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 39);
            label6.Name = "label6";
            label6.Size = new Size(234, 32);
            label6.TabIndex = 0;
            label6.Text = "Setup Your Password";
            // 
            // FinishPanel
            // 
            FinishPanel.BackColor = Color.Transparent;
            FinishPanel.Controls.Add(label16);
            FinishPanel.Controls.Add(label17);
            FinishPanel.Dock = DockStyle.Fill;
            FinishPanel.Location = new Point(0, 0);
            FinishPanel.Name = "FinishPanel";
            FinishPanel.Size = new Size(833, 389);
            FinishPanel.TabIndex = 5;
            FinishPanel.Tag = "Finish";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(51, 92);
            label16.Name = "label16";
            label16.Size = new Size(656, 18);
            label16.TabIndex = 1;
            label16.Text = "You're now ready to use LibCheck! Click Finish to setup, login, and ready to go! ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(45, 39);
            label17.Name = "label17";
            label17.Size = new Size(162, 32);
            label17.TabIndex = 0;
            label17.Text = "You're All Set!";
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.Transparent;
            UsernamePanel.Controls.Add(usernameTxtBox);
            UsernamePanel.Controls.Add(label3);
            UsernamePanel.Controls.Add(label4);
            UsernamePanel.Dock = DockStyle.Fill;
            UsernamePanel.Location = new Point(0, 0);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(833, 389);
            UsernamePanel.TabIndex = 1;
            UsernamePanel.Tag = "Username";
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(90, 158);
            usernameTxtBox.MaxLength = 64;
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(550, 25);
            usernameTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 92);
            label3.Name = "label3";
            label3.Size = new Size(320, 18);
            label3.TabIndex = 1;
            label3.Text = "Setup your own username as a librarian.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 39);
            label4.Name = "label4";
            label4.Size = new Size(244, 32);
            label4.TabIndex = 0;
            label4.Text = "Setup Your Username";
            // 
            // SchoolPanel
            // 
            SchoolPanel.BackColor = Color.Transparent;
            SchoolPanel.Controls.Add(SchoolNameTextBox);
            SchoolPanel.Controls.Add(label8);
            SchoolPanel.Dock = DockStyle.Fill;
            SchoolPanel.Location = new Point(0, 0);
            SchoolPanel.Name = "SchoolPanel";
            SchoolPanel.Size = new Size(833, 389);
            SchoolPanel.TabIndex = 6;
            SchoolPanel.Tag = "School";
            // 
            // SchoolNameTextBox
            // 
            SchoolNameTextBox.Location = new Point(90, 158);
            SchoolNameTextBox.MaxLength = 64;
            SchoolNameTextBox.Name = "SchoolNameTextBox";
            SchoolNameTextBox.Size = new Size(550, 25);
            SchoolNameTextBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(45, 39);
            label8.Name = "label8";
            label8.Size = new Size(273, 32);
            label8.TabIndex = 0;
            label8.Text = "Enter Your School Name";
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.Transparent;
            WelcomePanel.Controls.Add(label2);
            WelcomePanel.Controls.Add(label1);
            WelcomePanel.Dock = DockStyle.Fill;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(833, 389);
            WelcomePanel.TabIndex = 0;
            WelcomePanel.Tag = "Welcome";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.Location = new Point(51, 92);
            label2.Name = "label2";
            label2.Size = new Size(732, 259);
            label2.TabIndex = 1;
            label2.Text = "Thank you for choosing LibCheck! In this procedure, you'll take steps on setting up information as a librarian before you use this program for the first time.\r\n\r\nClick 'Next' to continue.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // RegisterLib
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(833, 483);
            Controls.Add(StagePanel);
            Controls.Add(LowerPanel);
            DoubleBuffered = true;
            Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterLib";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome! | LibCheck";
            FormClosing += RegisterLib_FormClosing;
            Load += RegisterLib_Load;
            LowerPanel.ResumeLayout(false);
            LowerPanel.PerformLayout();
            StagePanel.ResumeLayout(false);
            BasicInfoPanel.ResumeLayout(false);
            BasicInfoPanel.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            FinishPanel.ResumeLayout(false);
            FinishPanel.PerformLayout();
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            SchoolPanel.ResumeLayout(false);
            SchoolPanel.PerformLayout();
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LowerPanel;
        private Panel StagePanel;
        private Button NextButton;
        private Button PrevButton;
        private Panel WelcomePanel;
        private Label label1;
        private Label label2;
        private Label BulletProgressLabel;
        private Label DescLabel;
        private Panel UsernamePanel;
        private Label label4;
        private TextBox usernameTxtBox;
        private Label label3;
        private Panel PasswordPanel;
        private TextBox passTxtBox;
        private Label label5;
        private Label label6;
        private Button ShowPassButton;
        private Panel BasicInfoPanel;
        private TextBox FNameTxtBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private TextBox LNameTxtBox;
        private Label label12;
        private TextBox MNameTxtBox;
        private Label label14;
        private DateTimePicker BDatePicker;
        private ComboBox GenderCBox;
        private Label label15;
        private Panel FinishPanel;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox passReTypeTxtBox;
        private Panel SchoolPanel;
        private TextBox SchoolNameTextBox;
        private Label label8;
    }
}