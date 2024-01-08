namespace LibCheck.Forms.SearchTools.UserControls
{
    partial class BooksSearchUC
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
            BookLDmgCbox = new CheckBox();
            BookBorrowedCBox = new CheckBox();
            genreComboBox = new ComboBox();
            GenreCBox = new CheckBox();
            groupBox2 = new GroupBox();
            ScanButton = new Button();
            AuthorRB = new RadioButton();
            TitleRB = new RadioButton();
            IsbnRB = new RadioButton();
            keywordTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BookLDmgCbox);
            groupBox1.Controls.Add(BookBorrowedCBox);
            groupBox1.Controls.Add(genreComboBox);
            groupBox1.Controls.Add(GenreCBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 133);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(400, 278);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search By Category";
            // 
            // BookLDmgCbox
            // 
            BookLDmgCbox.AutoSize = true;
            BookLDmgCbox.Location = new Point(34, 72);
            BookLDmgCbox.Margin = new Padding(2);
            BookLDmgCbox.Name = "BookLDmgCbox";
            BookLDmgCbox.Size = new Size(165, 24);
            BookLDmgCbox.TabIndex = 14;
            BookLDmgCbox.Text = "Book Lost/Damaged";
            BookLDmgCbox.UseVisualStyleBackColor = true;
            BookLDmgCbox.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // BookBorrowedCBox
            // 
            BookBorrowedCBox.AutoSize = true;
            BookBorrowedCBox.Location = new Point(34, 42);
            BookBorrowedCBox.Margin = new Padding(2);
            BookBorrowedCBox.Name = "BookBorrowedCBox";
            BookBorrowedCBox.Size = new Size(131, 24);
            BookBorrowedCBox.TabIndex = 13;
            BookBorrowedCBox.Text = "Book Borrowed";
            BookBorrowedCBox.UseVisualStyleBackColor = true;
            BookBorrowedCBox.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // genreComboBox
            // 
            genreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genreComboBox.Enabled = false;
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(70, 123);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(250, 28);
            genreComboBox.TabIndex = 12;
            genreComboBox.SelectedIndexChanged += genreComboBox_SelectedIndexChanged;
            // 
            // GenreCBox
            // 
            GenreCBox.AutoSize = true;
            GenreCBox.Location = new Point(34, 100);
            GenreCBox.Margin = new Padding(2);
            GenreCBox.Name = "GenreCBox";
            GenreCBox.Size = new Size(67, 24);
            GenreCBox.TabIndex = 0;
            GenreCBox.Text = "Genre";
            GenreCBox.UseVisualStyleBackColor = true;
            GenreCBox.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ScanButton);
            groupBox2.Controls.Add(AuthorRB);
            groupBox2.Controls.Add(TitleRB);
            groupBox2.Controls.Add(IsbnRB);
            groupBox2.Controls.Add(keywordTextBox);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 133);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Keyword";
            // 
            // ScanButton
            // 
            ScanButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScanButton.Location = new Point(302, 48);
            ScanButton.Name = "ScanButton";
            ScanButton.Size = new Size(82, 27);
            ScanButton.TabIndex = 6;
            ScanButton.Text = "Scan";
            ScanButton.UseVisualStyleBackColor = true;
            ScanButton.Click += BrowseButton_Click;
            // 
            // AuthorRB
            // 
            AuthorRB.AutoSize = true;
            AuthorRB.Location = new Point(161, 77);
            AuthorRB.Name = "AuthorRB";
            AuthorRB.Size = new Size(72, 24);
            AuthorRB.TabIndex = 5;
            AuthorRB.Text = "Author";
            AuthorRB.UseVisualStyleBackColor = true;
            AuthorRB.CheckedChanged += RadioButtonsCheckedChanged;
            // 
            // TitleRB
            // 
            TitleRB.AutoSize = true;
            TitleRB.Location = new Point(99, 77);
            TitleRB.Name = "TitleRB";
            TitleRB.Size = new Size(56, 24);
            TitleRB.TabIndex = 3;
            TitleRB.Text = "Title";
            TitleRB.UseVisualStyleBackColor = true;
            TitleRB.CheckedChanged += RadioButtonsCheckedChanged;
            // 
            // IsbnRB
            // 
            IsbnRB.AutoSize = true;
            IsbnRB.Checked = true;
            IsbnRB.Location = new Point(34, 77);
            IsbnRB.Name = "IsbnRB";
            IsbnRB.Size = new Size(59, 24);
            IsbnRB.TabIndex = 4;
            IsbnRB.TabStop = true;
            IsbnRB.Text = "ISBN";
            IsbnRB.UseVisualStyleBackColor = true;
            IsbnRB.CheckedChanged += RadioButtonsCheckedChanged;
            // 
            // keywordTextBox
            // 
            keywordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            keywordTextBox.Location = new Point(34, 48);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(262, 27);
            keywordTextBox.TabIndex = 2;
            // 
            // BooksSearchUC
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "BooksSearchUC";
            Size = new Size(400, 411);
            Load += BooksSearchUC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox GenreCBox;
        private GroupBox groupBox2;
        private TextBox keywordTextBox;
        private RadioButton TitleRB;
        private RadioButton IsbnRB;
        private ComboBox genreComboBox;
        private CheckBox BookLDmgCbox;
        private CheckBox BookBorrowedCBox;
        private RadioButton AuthorRB;
        private Button ScanButton;
    }
}
