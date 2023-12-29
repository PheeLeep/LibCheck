namespace LibCheck.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            ChangePasswordButton = new Button();
            panel1 = new Panel();
            AccountRecoveryButton = new Button();
            WelcomeLabel = new Label();
            EmailsButton = new Button();
            StatsButton = new Button();
            StudentsButton = new Button();
            BooksButton = new Button();
            HomeButton = new Button();
            booksDashboard1 = new Admin.UserControls.BooksDashboard();
            homeDashboard1 = new Admin.UserControls.HomeDashboard();
            LogsButton = new Button();
            panel2 = new Panel();
            StagePanel = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            StagePanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangePasswordButton.BackColor = SystemColors.Control;
            ChangePasswordButton.FlatStyle = FlatStyle.Flat;
            ChangePasswordButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChangePasswordButton.Location = new Point(1145, 39);
            ChangePasswordButton.Margin = new Padding(4);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(165, 45);
            ChangePasswordButton.TabIndex = 2;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.UseVisualStyleBackColor = false;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(ChangePasswordButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 122);
            panel1.TabIndex = 3;
            // 
            // AccountRecoveryButton
            // 
            AccountRecoveryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AccountRecoveryButton.Location = new Point(861, 4);
            AccountRecoveryButton.Margin = new Padding(4, 4, 4, 4);
            AccountRecoveryButton.Name = "AccountRecoveryButton";
            AccountRecoveryButton.Size = new Size(112, 49);
            AccountRecoveryButton.TabIndex = 4;
            AccountRecoveryButton.Text = "Account Recovery";
            AccountRecoveryButton.UseVisualStyleBackColor = true;
            AccountRecoveryButton.Click += AccountRecoveryButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = SystemColors.Control;
            WelcomeLabel.Location = new Point(51, 30);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(128, 54);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "label1";
            // 
            // EmailsButton
            // 
            EmailsButton.Dock = DockStyle.Top;
            EmailsButton.FlatStyle = FlatStyle.Flat;
            EmailsButton.Image = (Image)resources.GetObject("EmailsButton.Image");
            EmailsButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmailsButton.Location = new Point(0, 312);
            EmailsButton.Name = "EmailsButton";
            EmailsButton.Size = new Size(290, 78);
            EmailsButton.TabIndex = 4;
            EmailsButton.Text = "Emails";
            EmailsButton.UseVisualStyleBackColor = true;
            // 
            // StatsButton
            // 
            StatsButton.Dock = DockStyle.Top;
            StatsButton.FlatStyle = FlatStyle.Flat;
            StatsButton.Image = (Image)resources.GetObject("StatsButton.Image");
            StatsButton.ImageAlign = ContentAlignment.MiddleLeft;
            StatsButton.Location = new Point(0, 234);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(290, 78);
            StatsButton.TabIndex = 3;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            // 
            // StudentsButton
            // 
            StudentsButton.Dock = DockStyle.Top;
            StudentsButton.FlatStyle = FlatStyle.Flat;
            StudentsButton.Image = (Image)resources.GetObject("StudentsButton.Image");
            StudentsButton.ImageAlign = ContentAlignment.MiddleLeft;
            StudentsButton.Location = new Point(0, 156);
            StudentsButton.Name = "StudentsButton";
            StudentsButton.Size = new Size(290, 78);
            StudentsButton.TabIndex = 2;
            StudentsButton.Text = "Students";
            StudentsButton.UseVisualStyleBackColor = true;
            StudentsButton.Click += StudentsButton_Click;
            // 
            // BooksButton
            // 
            BooksButton.Dock = DockStyle.Top;
            BooksButton.FlatStyle = FlatStyle.Flat;
            BooksButton.Image = (Image)resources.GetObject("BooksButton.Image");
            BooksButton.ImageAlign = ContentAlignment.MiddleLeft;
            BooksButton.Location = new Point(0, 78);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(290, 78);
            BooksButton.TabIndex = 1;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            BooksButton.Click += BooksButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Dock = DockStyle.Top;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(0, 0);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(290, 78);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // booksDashboard1
            // 
            booksDashboard1.Dock = DockStyle.Fill;
            booksDashboard1.Location = new Point(0, 0);
            booksDashboard1.Margin = new Padding(6);
            booksDashboard1.Name = "booksDashboard1";
            booksDashboard1.Size = new Size(1033, 626);
            booksDashboard1.TabIndex = 4;
            // 
            // homeDashboard1
            // 
            homeDashboard1.BackColor = SystemColors.ActiveCaption;
            homeDashboard1.Dock = DockStyle.Fill;
            homeDashboard1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            homeDashboard1.Location = new Point(0, 0);
            homeDashboard1.Margin = new Padding(6);
            homeDashboard1.Name = "homeDashboard1";
            homeDashboard1.Size = new Size(1033, 626);
            homeDashboard1.TabIndex = 0;
            homeDashboard1.Load += homeDashboard1_Load;
            // 
            // LogsButton
            // 
            LogsButton.Dock = DockStyle.Top;
            LogsButton.FlatStyle = FlatStyle.Flat;
            LogsButton.Image = (Image)resources.GetObject("LogsButton.Image");
            LogsButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogsButton.Location = new Point(0, 390);
            LogsButton.Name = "LogsButton";
            LogsButton.Size = new Size(290, 78);
            LogsButton.TabIndex = 5;
            LogsButton.Text = "Logs";
            LogsButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(StagePanel);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 122);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1323, 626);
            panel2.TabIndex = 4;
            // 
            // StagePanel
            // 
            StagePanel.Controls.Add(homeDashboard1);
            StagePanel.Controls.Add(booksDashboard1);
            StagePanel.Dock = DockStyle.Fill;
            StagePanel.Location = new Point(290, 0);
            StagePanel.Margin = new Padding(4);
            StagePanel.Name = "StagePanel";
            StagePanel.Size = new Size(1033, 626);
            StagePanel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(LogsButton);
            panel3.Controls.Add(EmailsButton);
            panel3.Controls.Add(StatsButton);
            panel3.Controls.Add(StudentsButton);
            panel3.Controls.Add(BooksButton);
            panel3.Controls.Add(HomeButton);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 626);
            panel3.TabIndex = 4;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1323, 748);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            StagePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ChangePasswordButton;
        private Panel panel1;
        private Label WelcomeLabel;
        private Button HomeButton;
        private Button BooksButton;
        private Button StudentsButton;
        private Button StatsButton;
        private Button EmailsButton;
        private Admin.UserControls.HomeDashboard homeDashboard1;
        private Admin.UserControls.BooksDashboard booksDashboard1;
        private Button LogsButton;
        private Panel panel2;
        private Panel StagePanel;
        private Panel panel3;
        private Button AccountRecoveryButton;
        private Admin.UserControls.StudentsDashboard studentsDashboard1;
    }
}