namespace LibCheck.Forms.SearchTools {
    partial class SearchDialog {
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
            pictureBox1 = new PictureBox();
            camComboBox = new ComboBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            AltPanel = new Controls.DoubleBufferedPanel();
            groupBox1 = new GroupBox();
            SearchStudentRButton = new RadioButton();
            SearchBookRButton = new RadioButton();
            SearchTextBox = new TextBox();
            ManualSearchButton = new Button();
            BackButton = new Button();
            CamPanel = new Controls.DoubleBufferedPanel();
            doubleBufferedPanel3 = new Controls.DoubleBufferedPanel();
            doubleBufferedPanel2 = new Controls.DoubleBufferedPanel();
            doubleBufferedPanel4 = new Controls.DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            AltPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            CamPanel.SuspendLayout();
            doubleBufferedPanel3.SuspendLayout();
            doubleBufferedPanel2.SuspendLayout();
            doubleBufferedPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 59);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(866, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // camComboBox
            // 
            camComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            camComboBox.FormattingEnabled = true;
            camComboBox.Location = new Point(118, 24);
            camComboBox.Margin = new Padding(3, 2, 3, 2);
            camComboBox.Name = "camComboBox";
            camComboBox.Size = new Size(235, 28);
            camComboBox.TabIndex = 3;
            camComboBox.SelectedIndexChanged += camComboBox_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(371, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Scan not working?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 4;
            label1.Text = "Camera:";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(128, 128, 255);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(866, 59);
            label2.TabIndex = 5;
            label2.Text = "Let the students scan their ID or book they're about to borrow or return.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.Portrait_Mode_Scanning_50px;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // AltPanel
            // 
            AltPanel.BackColor = Color.Transparent;
            AltPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AltPanel.Controls.Add(groupBox1);
            AltPanel.Controls.Add(BackButton);
            AltPanel.Dock = DockStyle.Fill;
            AltPanel.ForeColor = Color.White;
            AltPanel.Location = new Point(0, 0);
            AltPanel.Name = "AltPanel";
            AltPanel.Size = new Size(866, 468);
            AltPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(SearchStudentRButton);
            groupBox1.Controls.Add(SearchBookRButton);
            groupBox1.Controls.Add(SearchTextBox);
            groupBox1.Controls.Add(ManualSearchButton);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(79, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 374);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manual Search";
            // 
            // SearchStudentRButton
            // 
            SearchStudentRButton.AutoSize = true;
            SearchStudentRButton.Location = new Point(102, 195);
            SearchStudentRButton.Name = "SearchStudentRButton";
            SearchStudentRButton.Size = new Size(300, 32);
            SearchStudentRButton.TabIndex = 3;
            SearchStudentRButton.Text = "Search by Student (Student ID)";
            SearchStudentRButton.UseVisualStyleBackColor = true;
            // 
            // SearchBookRButton
            // 
            SearchBookRButton.AutoSize = true;
            SearchBookRButton.Checked = true;
            SearchBookRButton.Location = new Point(102, 157);
            SearchBookRButton.Name = "SearchBookRButton";
            SearchBookRButton.Size = new Size(227, 32);
            SearchBookRButton.TabIndex = 2;
            SearchBookRButton.TabStop = true;
            SearchBookRButton.Text = "Search by Book (ISBN)";
            SearchBookRButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchTextBox.Location = new Point(39, 90);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(655, 34);
            SearchTextBox.TabIndex = 1;
            // 
            // ManualSearchButton
            // 
            ManualSearchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ManualSearchButton.BackColor = Color.Silver;
            ManualSearchButton.FlatStyle = FlatStyle.Flat;
            ManualSearchButton.ForeColor = Color.Black;
            ManualSearchButton.Location = new Point(562, 302);
            ManualSearchButton.Name = "ManualSearchButton";
            ManualSearchButton.Size = new Size(128, 49);
            ManualSearchButton.TabIndex = 0;
            ManualSearchButton.Text = "Search";
            ManualSearchButton.UseVisualStyleBackColor = false;
            ManualSearchButton.Click += ManualSearchButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ActiveCaptionText;
            BackButton.Image = Properties.Resources.back_to_50px;
            BackButton.Location = new Point(8, 9);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(50, 50);
            BackButton.TabIndex = 2;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CamPanel
            // 
            CamPanel.BackColor = Color.Transparent;
            CamPanel.BackgroundImageLayout = ImageLayout.Stretch;
            CamPanel.Controls.Add(pictureBox1);
            CamPanel.Controls.Add(doubleBufferedPanel3);
            CamPanel.Controls.Add(doubleBufferedPanel2);
            CamPanel.Dock = DockStyle.Fill;
            CamPanel.Location = new Point(0, 0);
            CamPanel.Name = "CamPanel";
            CamPanel.Size = new Size(866, 468);
            CamPanel.TabIndex = 7;
            // 
            // doubleBufferedPanel3
            // 
            doubleBufferedPanel3.BackColor = Color.Transparent;
            doubleBufferedPanel3.Controls.Add(label1);
            doubleBufferedPanel3.Controls.Add(linkLabel1);
            doubleBufferedPanel3.Controls.Add(camComboBox);
            doubleBufferedPanel3.Dock = DockStyle.Bottom;
            doubleBufferedPanel3.Location = new Point(0, 390);
            doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            doubleBufferedPanel3.Size = new Size(866, 78);
            doubleBufferedPanel3.TabIndex = 7;
            // 
            // doubleBufferedPanel2
            // 
            doubleBufferedPanel2.BackColor = Color.Transparent;
            doubleBufferedPanel2.Controls.Add(pictureBox2);
            doubleBufferedPanel2.Controls.Add(label2);
            doubleBufferedPanel2.Dock = DockStyle.Top;
            doubleBufferedPanel2.Location = new Point(0, 0);
            doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            doubleBufferedPanel2.Size = new Size(866, 59);
            doubleBufferedPanel2.TabIndex = 7;
            // 
            // doubleBufferedPanel4
            // 
            doubleBufferedPanel4.BackgroundImage = Properties.Resources.bg;
            doubleBufferedPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            doubleBufferedPanel4.Controls.Add(CamPanel);
            doubleBufferedPanel4.Controls.Add(AltPanel);
            doubleBufferedPanel4.Dock = DockStyle.Fill;
            doubleBufferedPanel4.Location = new Point(0, 0);
            doubleBufferedPanel4.Name = "doubleBufferedPanel4";
            doubleBufferedPanel4.Size = new Size(866, 468);
            doubleBufferedPanel4.TabIndex = 8;
            // 
            // SearchDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Blue;
            ClientSize = new Size(866, 468);
            Controls.Add(doubleBufferedPanel4);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += SearchDialog_FormClosing;
            Load += SearchDialog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            AltPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            CamPanel.ResumeLayout(false);
            doubleBufferedPanel3.ResumeLayout(false);
            doubleBufferedPanel3.PerformLayout();
            doubleBufferedPanel2.ResumeLayout(false);
            doubleBufferedPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ComboBox camComboBox;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Controls.DoubleBufferedPanel AltPanel;
        private GroupBox groupBox1;
        private RadioButton SearchStudentRButton;
        private RadioButton SearchBookRButton;
        private TextBox SearchTextBox;
        private Button ManualSearchButton;
        private Button BackButton;
        private Controls.DoubleBufferedPanel CamPanel;
        private Controls.DoubleBufferedPanel doubleBufferedPanel3;
        private Controls.DoubleBufferedPanel doubleBufferedPanel2;
        private Controls.DoubleBufferedPanel doubleBufferedPanel4;
    }
}