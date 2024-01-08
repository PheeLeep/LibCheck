namespace LibCheck.Forms.SearchTools.UserControls {
    partial class HistorySearchUC {
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
            groupBox1 = new GroupBox();
            BookRestoredCBox = new CheckBox();
            BookLDmgCBox = new CheckBox();
            BookBorrowedCBox = new CheckBox();
            BookReturnedCBox = new CheckBox();
            BookDelCBox = new CheckBox();
            bookModCBox = new CheckBox();
            BookAddedCBox = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
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
            groupBox1.Location = new Point(0, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 360);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search By Category";
            // 
            // BookRestoredCBox
            // 
            BookRestoredCBox.AutoSize = true;
            BookRestoredCBox.Checked = true;
            BookRestoredCBox.CheckState = CheckState.Checked;
            BookRestoredCBox.Location = new Point(51, 229);
            BookRestoredCBox.Name = "BookRestoredCBox";
            BookRestoredCBox.Size = new Size(128, 24);
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
            BookLDmgCBox.Location = new Point(51, 199);
            BookLDmgCBox.Name = "BookLDmgCBox";
            BookLDmgCBox.Size = new Size(159, 24);
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
            BookBorrowedCBox.Location = new Point(51, 139);
            BookBorrowedCBox.Name = "BookBorrowedCBox";
            BookBorrowedCBox.Size = new Size(134, 24);
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
            BookReturnedCBox.Location = new Point(51, 169);
            BookReturnedCBox.Name = "BookReturnedCBox";
            BookReturnedCBox.Size = new Size(129, 24);
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
            BookDelCBox.Location = new Point(51, 109);
            BookDelCBox.Name = "BookDelCBox";
            BookDelCBox.Size = new Size(122, 24);
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
            bookModCBox.Location = new Point(51, 82);
            bookModCBox.Name = "bookModCBox";
            bookModCBox.Size = new Size(130, 24);
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
            BookAddedCBox.Location = new Point(51, 52);
            BookAddedCBox.Name = "BookAddedCBox";
            BookAddedCBox.Size = new Size(114, 24);
            BookAddedCBox.TabIndex = 0;
            BookAddedCBox.Text = "Book Added";
            BookAddedCBox.UseVisualStyleBackColor = true;
            BookAddedCBox.CheckedChanged += CBoxCheckChanged;
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search By Keyword";
            // 
            // HistorySearchUC
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "HistorySearchUC";
            Size = new Size(500, 514);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox BookAddedCBox;
        private CheckBox bookModCBox;
        private CheckBox BookBorrowedCBox;
        private CheckBox BookDelCBox;
        private CheckBox BookLDmgCBox;
        private CheckBox BookReturnedCBox;
        private CheckBox BookRestoredCBox;
    }
}
