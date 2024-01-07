namespace LibCheck.Forms.Admin.UserControls {
    partial class HomeDashboard {
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            NBBLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            NBRLabel = new Label();
            label2 = new Label();
            doubleBufferedPanel1 = new Controls.DoubleBufferedPanel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            NotifsLabel = new Label();
            label4 = new Label();
            notifPanel = new Controls.DoubleBufferedPanel();
            doubleBufferedPanel3 = new Controls.DoubleBufferedPanel();
            ClearLogButton = new Button();
            CheckNotifLatestCBox = new CheckBox();
            BackButton = new Button();
            MainPanel = new Controls.DoubleBufferedPanel();
            groupBox1 = new GroupBox();
            doubleBufferedPanel2 = new Controls.DoubleBufferedPanel();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            StudentsLabel = new Label();
            label7 = new Label();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            BooksLabel = new Label();
            label9 = new Label();
            NotifPanelMain = new Controls.DoubleBufferedPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            doubleBufferedPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            doubleBufferedPanel3.SuspendLayout();
            MainPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            doubleBufferedPanel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            NotifPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(NBBLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_book_borrowed_45;
            pictureBox2.Location = new Point(21, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // NBBLabel
            // 
            NBBLabel.AutoSize = true;
            NBBLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NBBLabel.Location = new Point(69, 35);
            NBBLabel.Name = "NBBLabel";
            NBBLabel.Size = new Size(38, 46);
            NBBLabel.TabIndex = 1;
            NBBLabel.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(21, 99);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Books Borrowed today";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(NBRLabel);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 132);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_bookreturned_45;
            pictureBox1.Location = new Point(21, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // NBRLabel
            // 
            NBRLabel.AutoSize = true;
            NBRLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NBRLabel.Location = new Point(69, 35);
            NBRLabel.Name = "NBRLabel";
            NBRLabel.Size = new Size(38, 46);
            NBRLabel.TabIndex = 2;
            NBRLabel.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(21, 99);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 1;
            label2.Text = "Books Returned today";
            // 
            // doubleBufferedPanel1
            // 
            doubleBufferedPanel1.Controls.Add(panel3);
            doubleBufferedPanel1.Controls.Add(panel2);
            doubleBufferedPanel1.Controls.Add(panel1);
            doubleBufferedPanel1.Dock = DockStyle.Top;
            doubleBufferedPanel1.Location = new Point(0, 0);
            doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            doubleBufferedPanel1.Size = new Size(860, 132);
            doubleBufferedPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(NotifsLabel);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(496, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 132);
            panel3.TabIndex = 1;
            panel3.Click += NotifControls_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_notification_45;
            pictureBox3.Location = new Point(21, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += NotifControls_Click;
            // 
            // NotifsLabel
            // 
            NotifsLabel.AutoSize = true;
            NotifsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NotifsLabel.Location = new Point(69, 35);
            NotifsLabel.Name = "NotifsLabel";
            NotifsLabel.Size = new Size(38, 46);
            NotifsLabel.TabIndex = 2;
            NotifsLabel.Text = "0";
            NotifsLabel.Click += NotifControls_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(21, 99);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 1;
            label4.Text = "Notifications";
            label4.Click += NotifControls_Click;
            // 
            // notifPanel
            // 
            notifPanel.AutoSize = true;
            notifPanel.Dock = DockStyle.Fill;
            notifPanel.Location = new Point(0, 42);
            notifPanel.Name = "notifPanel";
            notifPanel.Size = new Size(860, 479);
            notifPanel.TabIndex = 2;
            // 
            // doubleBufferedPanel3
            // 
            doubleBufferedPanel3.Controls.Add(ClearLogButton);
            doubleBufferedPanel3.Controls.Add(CheckNotifLatestCBox);
            doubleBufferedPanel3.Controls.Add(BackButton);
            doubleBufferedPanel3.Dock = DockStyle.Top;
            doubleBufferedPanel3.Location = new Point(0, 0);
            doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            doubleBufferedPanel3.Size = new Size(860, 42);
            doubleBufferedPanel3.TabIndex = 3;
            // 
            // ClearLogButton
            // 
            ClearLogButton.BackColor = Color.Transparent;
            ClearLogButton.BackgroundImageLayout = ImageLayout.Zoom;
            ClearLogButton.Dock = DockStyle.Right;
            ClearLogButton.FlatAppearance.BorderSize = 0;
            ClearLogButton.FlatStyle = FlatStyle.Flat;
            ClearLogButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearLogButton.Image = Properties.Resources.empty_trash_32px;
            ClearLogButton.Location = new Point(799, 0);
            ClearLogButton.Name = "ClearLogButton";
            ClearLogButton.Size = new Size(61, 42);
            ClearLogButton.TabIndex = 4;
            ClearLogButton.UseVisualStyleBackColor = false;
            ClearLogButton.Click += ClearLogButton_Click;
            // 
            // CheckNotifLatestCBox
            // 
            CheckNotifLatestCBox.AutoSize = true;
            CheckNotifLatestCBox.Dock = DockStyle.Left;
            CheckNotifLatestCBox.Location = new Point(37, 0);
            CheckNotifLatestCBox.Name = "CheckNotifLatestCBox";
            CheckNotifLatestCBox.Padding = new Padding(10, 0, 0, 0);
            CheckNotifLatestCBox.Size = new Size(253, 42);
            CheckNotifLatestCBox.TabIndex = 0;
            CheckNotifLatestCBox.Text = "Check Latest Notification";
            CheckNotifLatestCBox.UseVisualStyleBackColor = true;
            CheckNotifLatestCBox.CheckedChanged += CheckNotifLatestCBox_CheckedChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.Dock = DockStyle.Left;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(37, 42);
            BackButton.TabIndex = 5;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(groupBox1);
            MainPanel.Controls.Add(doubleBufferedPanel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(860, 521);
            MainPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(doubleBufferedPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 389);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summary";
            // 
            // doubleBufferedPanel2
            // 
            doubleBufferedPanel2.Controls.Add(panel5);
            doubleBufferedPanel2.Controls.Add(panel6);
            doubleBufferedPanel2.Dock = DockStyle.Top;
            doubleBufferedPanel2.Location = new Point(3, 28);
            doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            doubleBufferedPanel2.Size = new Size(854, 132);
            doubleBufferedPanel2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(StudentsLabel);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(248, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 132);
            panel5.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_users_45;
            pictureBox5.Location = new Point(21, 36);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            StudentsLabel.Location = new Point(69, 35);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new Size(38, 46);
            StudentsLabel.TabIndex = 2;
            StudentsLabel.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(21, 99);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 1;
            label7.Text = "Students";
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(BooksLabel);
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 132);
            panel6.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_books_45;
            pictureBox6.Location = new Point(21, 36);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // BooksLabel
            // 
            BooksLabel.AutoSize = true;
            BooksLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BooksLabel.Location = new Point(69, 35);
            BooksLabel.Name = "BooksLabel";
            BooksLabel.Size = new Size(38, 46);
            BooksLabel.TabIndex = 1;
            BooksLabel.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(21, 99);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 0;
            label9.Text = "Books";
            // 
            // NotifPanelMain
            // 
            NotifPanelMain.Controls.Add(notifPanel);
            NotifPanelMain.Controls.Add(doubleBufferedPanel3);
            NotifPanelMain.Dock = DockStyle.Fill;
            NotifPanelMain.Location = new Point(0, 0);
            NotifPanelMain.Name = "NotifPanelMain";
            NotifPanelMain.Size = new Size(860, 521);
            NotifPanelMain.TabIndex = 2;
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(MainPanel);
            Controls.Add(NotifPanelMain);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "HomeDashboard";
            Size = new Size(860, 521);
            Load += HomeDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            doubleBufferedPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            doubleBufferedPanel3.ResumeLayout(false);
            doubleBufferedPanel3.PerformLayout();
            MainPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            doubleBufferedPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            NotifPanelMain.ResumeLayout(false);
            NotifPanelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label NBBLabel;
        private Label NBRLabel;
        private Controls.DoubleBufferedPanel doubleBufferedPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label NotifsLabel;
        private Label label4;
        private Controls.DoubleBufferedPanel notifPanel;
        private Controls.DoubleBufferedPanel doubleBufferedPanel3;
        private CheckBox CheckNotifLatestCBox;
        private Button ClearLogButton;
        private Button BackButton;
        private Controls.DoubleBufferedPanel MainPanel;
        private Controls.DoubleBufferedPanel NotifPanelMain;
        private GroupBox groupBox1;
        private Controls.DoubleBufferedPanel doubleBufferedPanel2;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label StudentsLabel;
        private Label label7;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Label BooksLabel;
        private Label label9;
    }
}
