namespace LibCheck.Forms {
    partial class AdminForm {
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
            ChangePasswordButton = new Button();
            panel1 = new Panel();
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
            AccountRecoveryButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            StagePanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangePasswordButton.Location = new Point(785, 3);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(90, 39);
            ChangePasswordButton.TabIndex = 2;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(AccountRecoveryButton);
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(ChangePasswordButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 81);
            panel1.TabIndex = 3;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(34, 20);
            WelcomeLabel.Margin = new Padding(2, 0, 2, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(50, 20);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "label1";
            // 
            // EmailsButton
            // 
            EmailsButton.Dock = DockStyle.Top;
            EmailsButton.Location = new Point(0, 208);
            EmailsButton.Margin = new Padding(2);
            EmailsButton.Name = "EmailsButton";
            EmailsButton.Size = new Size(193, 52);
            EmailsButton.TabIndex = 4;
            EmailsButton.Text = "Emails";
            EmailsButton.UseVisualStyleBackColor = true;
            // 
            // StatsButton
            // 
            StatsButton.Dock = DockStyle.Top;
            StatsButton.Location = new Point(0, 156);
            StatsButton.Margin = new Padding(2);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(193, 52);
            StatsButton.TabIndex = 3;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            // 
            // StudentsButton
            // 
            StudentsButton.Dock = DockStyle.Top;
            StudentsButton.Location = new Point(0, 104);
            StudentsButton.Margin = new Padding(2);
            StudentsButton.Name = "StudentsButton";
            StudentsButton.Size = new Size(193, 52);
            StudentsButton.TabIndex = 2;
            StudentsButton.Text = "Students";
            StudentsButton.UseVisualStyleBackColor = true;
            // 
            // BooksButton
            // 
            BooksButton.Dock = DockStyle.Top;
            BooksButton.Location = new Point(0, 52);
            BooksButton.Margin = new Padding(2);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(193, 52);
            BooksButton.TabIndex = 1;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            BooksButton.Click += BooksButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Dock = DockStyle.Top;
            HomeButton.Location = new Point(0, 0);
            HomeButton.Margin = new Padding(2);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(193, 52);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // booksDashboard1
            // 
            booksDashboard1.Dock = DockStyle.Fill;
            booksDashboard1.Location = new Point(0, 0);
            booksDashboard1.Name = "booksDashboard1";
            booksDashboard1.Size = new Size(689, 418);
            booksDashboard1.TabIndex = 4;
            // 
            // homeDashboard1
            // 
            homeDashboard1.Dock = DockStyle.Fill;
            homeDashboard1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            homeDashboard1.Location = new Point(0, 0);
            homeDashboard1.Name = "homeDashboard1";
            homeDashboard1.Size = new Size(689, 418);
            homeDashboard1.TabIndex = 0;
            // 
            // LogsButton
            // 
            LogsButton.Dock = DockStyle.Top;
            LogsButton.Location = new Point(0, 260);
            LogsButton.Margin = new Padding(2);
            LogsButton.Name = "LogsButton";
            LogsButton.Size = new Size(193, 52);
            LogsButton.TabIndex = 5;
            LogsButton.Text = "Logs";
            LogsButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(StagePanel);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 418);
            panel2.TabIndex = 4;
            // 
            // StagePanel
            // 
            StagePanel.Controls.Add(homeDashboard1);
            StagePanel.Controls.Add(booksDashboard1);
            StagePanel.Dock = DockStyle.Fill;
            StagePanel.Location = new Point(193, 0);
            StagePanel.Name = "StagePanel";
            StagePanel.Size = new Size(689, 418);
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
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 418);
            panel3.TabIndex = 4;
            // 
            // AccountRecoveryButton
            // 
            AccountRecoveryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AccountRecoveryButton.Location = new Point(689, 3);
            AccountRecoveryButton.Name = "AccountRecoveryButton";
            AccountRecoveryButton.Size = new Size(90, 39);
            AccountRecoveryButton.TabIndex = 4;
            AccountRecoveryButton.Text = "Account Recovery";
            AccountRecoveryButton.UseVisualStyleBackColor = true;
            AccountRecoveryButton.Click += AccountRecoveryButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(882, 499);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}