﻿namespace LibCheck.Forms {
    partial class BookInfo {
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
            panel1 = new Panel();
            TitleLabel = new Label();
            OwnedLabel = new Label();
            panel3 = new Panel();
            BorrowBookButton = new Button();
            MarkAsDamageButton = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            GenreLabel = new Label();
            DatePubLabel = new Label();
            ISBNLabel = new Label();
            AuthorLabel = new Label();
            PublisherLabel = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(OwnedLabel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 230);
            panel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(161, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(478, 126);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "---";
            TitleLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // OwnedLabel
            // 
            OwnedLabel.Dock = DockStyle.Bottom;
            OwnedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OwnedLabel.ForeColor = Color.White;
            OwnedLabel.Location = new Point(161, 126);
            OwnedLabel.Name = "OwnedLabel";
            OwnedLabel.Size = new Size(478, 42);
            OwnedLabel.TabIndex = 0;
            OwnedLabel.Text = "---";
            OwnedLabel.TextAlign = ContentAlignment.MiddleLeft;
            OwnedLabel.DoubleClick += OwnedLabel_DoubleClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(BorrowBookButton);
            panel3.Controls.Add(MarkAsDamageButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(161, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 62);
            panel3.TabIndex = 2;
            // 
            // BorrowBookButton
            // 
            BorrowBookButton.BackColor = Color.Lime;
            BorrowBookButton.Dock = DockStyle.Right;
            BorrowBookButton.FlatStyle = FlatStyle.Flat;
            BorrowBookButton.Image = Properties.Resources.icons8_book_borrowed_45;
            BorrowBookButton.Location = new Point(290, 0);
            BorrowBookButton.Name = "BorrowBookButton";
            BorrowBookButton.Size = new Size(94, 62);
            BorrowBookButton.TabIndex = 0;
            BorrowBookButton.UseVisualStyleBackColor = false;
            BorrowBookButton.Click += BorrowBookButton_Click;
            // 
            // MarkAsDamageButton
            // 
            MarkAsDamageButton.BackColor = Color.Red;
            MarkAsDamageButton.Dock = DockStyle.Right;
            MarkAsDamageButton.FlatStyle = FlatStyle.Flat;
            MarkAsDamageButton.ForeColor = Color.White;
            MarkAsDamageButton.Image = Properties.Resources.icons8_book_damage_45;
            MarkAsDamageButton.Location = new Point(384, 0);
            MarkAsDamageButton.Name = "MarkAsDamageButton";
            MarkAsDamageButton.Size = new Size(94, 62);
            MarkAsDamageButton.TabIndex = 2;
            MarkAsDamageButton.UseVisualStyleBackColor = false;
            MarkAsDamageButton.Click += MarkAsDamageButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 247);
            panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(639, 247);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(631, 209);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Description";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(625, 203);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GenreLabel);
            tabPage2.Controls.Add(DatePubLabel);
            tabPage2.Controls.Add(ISBNLabel);
            tabPage2.Controls.Add(AuthorLabel);
            tabPage2.Controls.Add(PublisherLabel);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(631, 214);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Information";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(35, 156);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(62, 25);
            GenreLabel.TabIndex = 5;
            GenreLabel.Text = "Genre:";
            // 
            // DatePubLabel
            // 
            DatePubLabel.AutoSize = true;
            DatePubLabel.Location = new Point(35, 127);
            DatePubLabel.Name = "DatePubLabel";
            DatePubLabel.Size = new Size(135, 25);
            DatePubLabel.TabIndex = 4;
            DatePubLabel.Text = "Date Published:";
            // 
            // ISBNLabel
            // 
            ISBNLabel.AutoSize = true;
            ISBNLabel.Location = new Point(35, 32);
            ISBNLabel.Name = "ISBNLabel";
            ISBNLabel.Size = new Size(54, 25);
            ISBNLabel.TabIndex = 3;
            ISBNLabel.Text = "ISBN:";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(35, 64);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(91, 25);
            AuthorLabel.TabIndex = 1;
            AuthorLabel.Text = "Author/s: ";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(35, 96);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(88, 25);
            PublisherLabel.TabIndex = 2;
            PublisherLabel.Text = "Publisher:";
            // 
            // BookInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(639, 477);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "{n} | Book";
            FormClosing += BookInfo_FormClosing;
            Load += BookInfo_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label OwnedLabel;
        private Label TitleLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label ISBNLabel;
        private Label AuthorLabel;
        private Label PublisherLabel;
        private Label DatePubLabel;
        private RichTextBox richTextBox1;
        private Panel panel3;
        private Button BorrowBookButton;
        private Button MarkAsDamageButton;
        private Label GenreLabel;
        private PictureBox pictureBox1;
    }
}