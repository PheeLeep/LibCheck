using LibCheck.Forms.Admin.UserControls;

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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            SettingsButton = new Button();
            panel1 = new Panel();
            WelcomeLabel = new Label();
            AccountRecoveryButton = new Button();
            EmailsButton = new Button();
            StatsButton = new Button();
            StudentsButton = new Button();
            BooksButton = new Button();
            HomeButton = new Button();
            booksDashboard1 = new BooksDashboard();
            homeDashboard1 = new HomeDashboard();
            studentsDashboard1 = new StudentsDashboard();
            LogsButton = new Button();
            panel2 = new Panel();
            StagePanel = new Panel();
            emailDashboard1 = new EmailDashboard();
            panel3 = new Panel();
            cMS1 = new ContextMenuStrip(components);
            securityToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            accountRecoveryToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            StagePanel.SuspendLayout();
            panel3.SuspendLayout();
            cMS1.SuspendLayout();
            SuspendLayout();
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SettingsButton.BackColor = Color.Transparent;
            SettingsButton.BackgroundImageLayout = ImageLayout.Zoom;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.Image = Properties.Resources.settings;
            SettingsButton.Location = new Point(1049, 25);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(32, 32);
            SettingsButton.TabIndex = 2;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.MouseClick += SettingsButton_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(SettingsButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 102);
            panel1.TabIndex = 3;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = SystemColors.Control;
            WelcomeLabel.Location = new Point(42, 25);
            WelcomeLabel.Margin = new Padding(2, 0, 2, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(109, 46);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "label1";
            // 
            // AccountRecoveryButton
            // 
            AccountRecoveryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AccountRecoveryButton.Location = new Point(861, 4);
            AccountRecoveryButton.Margin = new Padding(4);
            AccountRecoveryButton.Name = "AccountRecoveryButton";
            AccountRecoveryButton.Size = new Size(112, 49);
            AccountRecoveryButton.TabIndex = 4;
            AccountRecoveryButton.Text = "Account Recovery";
            AccountRecoveryButton.UseVisualStyleBackColor = true;
            AccountRecoveryButton.Click += AccountRecoveryButton_Click;
            // 
            // EmailsButton
            // 
            EmailsButton.Dock = DockStyle.Top;
            EmailsButton.FlatStyle = FlatStyle.Flat;
            EmailsButton.Image = (Image)resources.GetObject("EmailsButton.Image");
            EmailsButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmailsButton.Location = new Point(0, 260);
            EmailsButton.Margin = new Padding(2);
            EmailsButton.Name = "EmailsButton";
            EmailsButton.Size = new Size(242, 65);
            EmailsButton.TabIndex = 4;
            EmailsButton.Text = "Emails";
            EmailsButton.UseVisualStyleBackColor = true;
            EmailsButton.Click += EmailsButton_Click;
            // 
            // StatsButton
            // 
            StatsButton.Dock = DockStyle.Top;
            StatsButton.FlatStyle = FlatStyle.Flat;
            StatsButton.Image = (Image)resources.GetObject("StatsButton.Image");
            StatsButton.ImageAlign = ContentAlignment.MiddleLeft;
            StatsButton.Location = new Point(0, 195);
            StatsButton.Margin = new Padding(2);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(242, 65);
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
            StudentsButton.Location = new Point(0, 130);
            StudentsButton.Margin = new Padding(2);
            StudentsButton.Name = "StudentsButton";
            StudentsButton.Size = new Size(242, 65);
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
            BooksButton.Location = new Point(0, 65);
            BooksButton.Margin = new Padding(2);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(242, 65);
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
            HomeButton.Margin = new Padding(2);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(242, 65);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // booksDashboard1
            // 
            booksDashboard1.Dock = DockStyle.Fill;
            booksDashboard1.Location = new Point(0, 0);
            booksDashboard1.Margin = new Padding(5);
            booksDashboard1.Name = "booksDashboard1";
            booksDashboard1.Size = new Size(860, 521);
            booksDashboard1.TabIndex = 4;
            // 
            // homeDashboard1
            // 
            homeDashboard1.BackColor = SystemColors.ActiveCaption;
            homeDashboard1.Dock = DockStyle.Fill;
            homeDashboard1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            homeDashboard1.Location = new Point(0, 0);
            homeDashboard1.Margin = new Padding(5);
            homeDashboard1.Name = "homeDashboard1";
            homeDashboard1.Size = new Size(860, 521);
            homeDashboard1.TabIndex = 0;
            // 
            // studentsDashboard1
            // 
            studentsDashboard1.Dock = DockStyle.Fill;
            studentsDashboard1.Location = new Point(0, 0);
            studentsDashboard1.Margin = new Padding(5);
            studentsDashboard1.Name = "studentsDashboard1";
            studentsDashboard1.Size = new Size(860, 521);
            studentsDashboard1.TabIndex = 4;
            // 
            // LogsButton
            // 
            LogsButton.Dock = DockStyle.Top;
            LogsButton.FlatStyle = FlatStyle.Flat;
            LogsButton.Image = (Image)resources.GetObject("LogsButton.Image");
            LogsButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogsButton.Location = new Point(0, 325);
            LogsButton.Margin = new Padding(2);
            LogsButton.Name = "LogsButton";
            LogsButton.Size = new Size(242, 65);
            LogsButton.TabIndex = 5;
            LogsButton.Text = "Logs";
            LogsButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(StagePanel);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 521);
            panel2.TabIndex = 4;
            // 
            // StagePanel
            // 
            StagePanel.Controls.Add(homeDashboard1);
            StagePanel.Controls.Add(emailDashboard1);
            StagePanel.Controls.Add(booksDashboard1);
            StagePanel.Controls.Add(studentsDashboard1);
            StagePanel.Dock = DockStyle.Fill;
            StagePanel.Location = new Point(242, 0);
            StagePanel.Name = "StagePanel";
            StagePanel.Size = new Size(860, 521);
            StagePanel.TabIndex = 4;
            // 
            // emailDashboard1
            // 
            emailDashboard1.Dock = DockStyle.Fill;
            emailDashboard1.Location = new Point(0, 0);
            emailDashboard1.Name = "emailDashboard1";
            emailDashboard1.Size = new Size(860, 521);
            emailDashboard1.TabIndex = 5;
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
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 521);
            panel3.TabIndex = 4;
            // 
            // cMS1
            // 
            cMS1.ImageScalingSize = new Size(20, 20);
            cMS1.Items.AddRange(new ToolStripItem[] { securityToolStripMenuItem });
            cMS1.Name = "contextMenuStrip1";
            cMS1.Size = new Size(131, 28);
            // 
            // securityToolStripMenuItem
            // 
            securityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, accountRecoveryToolStripMenuItem });
            securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            securityToolStripMenuItem.Size = new Size(130, 24);
            securityToolStripMenuItem.Text = "Security";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(210, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // accountRecoveryToolStripMenuItem
            // 
            accountRecoveryToolStripMenuItem.Name = "accountRecoveryToolStripMenuItem";
            accountRecoveryToolStripMenuItem.Size = new Size(210, 26);
            accountRecoveryToolStripMenuItem.Text = "Account Recovery";
            accountRecoveryToolStripMenuItem.Click += accountRecoveryToolStripMenuItem_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1102, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Mode";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            StagePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            cMS1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button SettingsButton;
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
        private ContextMenuStrip cMS1;
        private ToolStripMenuItem securityToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem accountRecoveryToolStripMenuItem;
        private EmailDashboard emailDashboard1;
    }
}