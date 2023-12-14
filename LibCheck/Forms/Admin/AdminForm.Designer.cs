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
            splitContainer1 = new SplitContainer();
            StatsButton = new Button();
            StudentsButton = new Button();
            BooksButton = new Button();
            HomeButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(821, 4);
            ChangePasswordButton.Margin = new Padding(4);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(112, 49);
            ChangePasswordButton.TabIndex = 2;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(ChangePasswordButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 86);
            panel1.TabIndex = 3;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(44, 28);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(59, 25);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "label1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 86);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(StatsButton);
            splitContainer1.Panel1.Controls.Add(StudentsButton);
            splitContainer1.Panel1.Controls.Add(BooksButton);
            splitContainer1.Panel1.Controls.Add(HomeButton);
            splitContainer1.Size = new Size(937, 479);
            splitContainer1.SplitterDistance = 236;
            splitContainer1.TabIndex = 4;
            // 
            // StatsButton
            // 
            StatsButton.Dock = DockStyle.Top;
            StatsButton.Location = new Point(0, 195);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(236, 65);
            StatsButton.TabIndex = 3;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            // 
            // StudentsButton
            // 
            StudentsButton.Dock = DockStyle.Top;
            StudentsButton.Location = new Point(0, 130);
            StudentsButton.Name = "StudentsButton";
            StudentsButton.Size = new Size(236, 65);
            StudentsButton.TabIndex = 2;
            StudentsButton.Text = "Students";
            StudentsButton.UseVisualStyleBackColor = true;
            // 
            // BooksButton
            // 
            BooksButton.Dock = DockStyle.Top;
            BooksButton.Location = new Point(0, 65);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(236, 65);
            BooksButton.TabIndex = 1;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.Dock = DockStyle.Top;
            HomeButton.Location = new Point(0, 0);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(236, 65);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(937, 565);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ChangePasswordButton;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label WelcomeLabel;
        private Button HomeButton;
        private Button BooksButton;
        private Button StudentsButton;
        private Button StatsButton;
    }
}