namespace LibCheck.Forms.SearchTools.UserControls
{
    partial class HistorySearchUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BookRestoredCBox = new CheckBox();
            BookLDmgCBox = new CheckBox();
            BookBorrowedCBox = new CheckBox();
            BookReturnedCBox = new CheckBox();
            BookDelCBox = new CheckBox();
            bookModCBox = new CheckBox();
            BookAddedCBox = new CheckBox();
            groupBox2 = new GroupBox();
            keywordTextBox = new TextBox();
            StudentRB = new RadioButton();
            BookRB = new RadioButton();
            BrowseButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BookRestoredCBox);
            groupBox1.Controls.Add(BookLDmgCBox);
            groupBox1.Controls.Add(BookBorrowedCBox);
            groupBox1.Controls.Add(BookReturnedCBox);
            groupBox1.Controls.Add(BookDelCBox);
            groupBox1.Controls.Add(bookModCBox);
            groupBox1.Controls.Add(BookAddedCBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 131);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(400, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search By Category";
            // 
            // BookRestoredCBox
            // 
            BookRestoredCBox.AutoSize = true;
            BookRestoredCBox.Checked = true;
            BookRestoredCBox.CheckState = CheckState.Checked;
            BookRestoredCBox.Location = new Point(43, 191);
            BookRestoredCBox.Margin = new Padding(2);
            BookRestoredCBox.Name = "BookRestoredCBox";
            BookRestoredCBox.Size = new Size(102, 19);
            BookRestoredCBox.TabIndex = 2;
            BookRestoredCBox.Text = "Book Restored";
            BookRestoredCBox.UseVisualStyleBackColor = true;
            BookRestoredCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // BookLDmgCBox
            // 
            BookLDmgCBox.AutoSize = true;
            BookLDmgCBox.Checked = true;
            BookLDmgCBox.CheckState = CheckState.Checked;
            BookLDmgCBox.Location = new Point(43, 167);
            BookLDmgCBox.Margin = new Padding(2);
            BookLDmgCBox.Name = "BookLDmgCBox";
            BookLDmgCBox.Size = new Size(127, 19);
            BookLDmgCBox.TabIndex = 1;
            BookLDmgCBox.Text = "Book Lost/Damage";
            BookLDmgCBox.UseVisualStyleBackColor = true;
            BookLDmgCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // BookBorrowedCBox
            // 
            BookBorrowedCBox.AutoSize = true;
            BookBorrowedCBox.Checked = true;
            BookBorrowedCBox.CheckState = CheckState.Checked;
            BookBorrowedCBox.Location = new Point(43, 119);
            BookBorrowedCBox.Margin = new Padding(2);
            BookBorrowedCBox.Name = "BookBorrowedCBox";
            BookBorrowedCBox.Size = new Size(107, 19);
            BookBorrowedCBox.TabIndex = 1;
            BookBorrowedCBox.Text = "Book Borrowed";
            BookBorrowedCBox.UseVisualStyleBackColor = true;
            BookBorrowedCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // BookReturnedCBox
            // 
            BookReturnedCBox.AutoSize = true;
            BookReturnedCBox.Checked = true;
            BookReturnedCBox.CheckState = CheckState.Checked;
            BookReturnedCBox.Location = new Point(43, 143);
            BookReturnedCBox.Margin = new Padding(2);
            BookReturnedCBox.Name = "BookReturnedCBox";
            BookReturnedCBox.Size = new Size(104, 19);
            BookReturnedCBox.TabIndex = 0;
            BookReturnedCBox.Text = "Book Returned";
            BookReturnedCBox.UseVisualStyleBackColor = true;
            BookReturnedCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // BookDelCBox
            // 
            BookDelCBox.AutoSize = true;
            BookDelCBox.Checked = true;
            BookDelCBox.CheckState = CheckState.Checked;
            BookDelCBox.Location = new Point(43, 95);
            BookDelCBox.Margin = new Padding(2);
            BookDelCBox.Name = "BookDelCBox";
            BookDelCBox.Size = new Size(96, 19);
            BookDelCBox.TabIndex = 0;
            BookDelCBox.Text = "Book Deleted";
            BookDelCBox.UseVisualStyleBackColor = true;
            BookDelCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // bookModCBox
            // 
            bookModCBox.AutoSize = true;
            bookModCBox.Checked = true;
            bookModCBox.CheckState = CheckState.Checked;
            bookModCBox.Location = new Point(43, 73);
            bookModCBox.Margin = new Padding(2);
            bookModCBox.Name = "bookModCBox";
            bookModCBox.Size = new Size(104, 19);
            bookModCBox.TabIndex = 1;
            bookModCBox.Text = "Book Modified";
            bookModCBox.UseVisualStyleBackColor = true;
            bookModCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // BookAddedCBox
            // 
            BookAddedCBox.AutoSize = true;
            BookAddedCBox.Checked = true;
            BookAddedCBox.CheckState = CheckState.Checked;
            BookAddedCBox.Location = new Point(43, 49);
            BookAddedCBox.Margin = new Padding(2);
            BookAddedCBox.Name = "BookAddedCBox";
            BookAddedCBox.Size = new Size(91, 19);
            BookAddedCBox.TabIndex = 0;
            BookAddedCBox.Text = "Book Added";
            BookAddedCBox.UseVisualStyleBackColor = true;
            BookAddedCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(keywordTextBox);
            groupBox2.Controls.Add(StudentRB);
            groupBox2.Controls.Add(BookRB);
            groupBox2.Controls.Add(BrowseButton);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 131);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Keyword";
            // 
            // keywordTextBox
            // 
            keywordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            keywordTextBox.Location = new Point(34, 48);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(254, 23);
            keywordTextBox.TabIndex = 2;
            keywordTextBox.TextChanged += keywordTextBox_TextChanged;
            // 
            // StudentRB
            // 
            StudentRB.AutoSize = true;
            StudentRB.Location = new Point(95, 85);
            StudentRB.Name = "StudentRB";
            StudentRB.Size = new Size(66, 19);
            StudentRB.TabIndex = 1;
            StudentRB.Text = "Student";
            StudentRB.UseVisualStyleBackColor = true;
            StudentRB.CheckedChanged += StudentRB_CheckedChanged;
            // 
            // BookRB
            // 
            BookRB.AutoSize = true;
            BookRB.Checked = true;
            BookRB.Location = new Point(37, 85);
            BookRB.Name = "BookRB";
            BookRB.Size = new Size(52, 19);
            BookRB.TabIndex = 1;
            BookRB.TabStop = true;
            BookRB.Text = "Book";
            BookRB.UseVisualStyleBackColor = true;
            BookRB.CheckedChanged += StudentRB_CheckedChanged;
            // 
            // BrowseButton
            // 
            BrowseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseButton.Location = new Point(294, 47);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(75, 23);
            BrowseButton.TabIndex = 0;
            BrowseButton.Text = "Scan";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // HistorySearchUC
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "HistorySearchUC";
            Size = new Size(400, 411);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox BookAddedCBox;
        private CheckBox bookModCBox;
        private CheckBox BookBorrowedCBox;
        private CheckBox BookDelCBox;
        private CheckBox BookLDmgCBox;
        private CheckBox BookReturnedCBox;
        private CheckBox BookRestoredCBox;
        private GroupBox groupBox2;
        private TextBox keywordTextBox;
        private RadioButton StudentRB;
        private RadioButton BookRB;
        private Button BrowseButton;
    }
}
