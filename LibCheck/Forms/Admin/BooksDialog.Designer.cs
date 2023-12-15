namespace LibCheck.Forms.Admin {
    partial class BooksDialog {
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
            ConfirmButton = new Button();
            ISBNTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TitleTextBox = new TextBox();
            label3 = new Label();
            AuthorTextBox = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DatePublishedDatePicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            PublisherTextBox = new TextBox();
            tabPage3 = new TabPage();
            DescTextBox = new TextBox();
            tabPage2 = new TabPage();
            LookupButton = new Button();
            BorrowedLabel = new Label();
            label8 = new Label();
            IsDamagedLabel = new Label();
            label6 = new Label();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConfirmButton.Location = new Point(271, 8);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(107, 37);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "Add";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ISBNTextBox.Location = new Point(24, 44);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(335, 25);
            ISBNTextBox.TabIndex = 1;
            ISBNTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 2;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 4;
            label2.Text = "Title:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleTextBox.Location = new Point(24, 109);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(335, 25);
            TitleTextBox.TabIndex = 3;
            TitleTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 149);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 6;
            label3.Text = "Author:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AuthorTextBox.Location = new Point(23, 172);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(335, 25);
            AuthorTextBox.TabIndex = 5;
            AuthorTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(393, 421);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DatePublishedDatePicker);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(PublisherTextBox);
            tabPage1.Controls.Add(ISBNTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(AuthorTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(TitleTextBox);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(385, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DatePublishedDatePicker
            // 
            DatePublishedDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatePublishedDatePicker.Format = DateTimePickerFormat.Short;
            DatePublishedDatePicker.Location = new Point(142, 287);
            DatePublishedDatePicker.Name = "DatePublishedDatePicker";
            DatePublishedDatePicker.Size = new Size(143, 25);
            DatePublishedDatePicker.TabIndex = 10;
            DatePublishedDatePicker.ValueChanged += Controls_ValuesChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 292);
            label5.Name = "label5";
            label5.Size = new Size(98, 17);
            label5.TabIndex = 9;
            label5.Text = "Date Published:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 213);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 8;
            label4.Text = "Publisher:";
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PublisherTextBox.Location = new Point(23, 236);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Size = new Size(335, 25);
            PublisherTextBox.TabIndex = 7;
            PublisherTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DescTextBox);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(385, 391);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Description";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DescTextBox
            // 
            DescTextBox.Dock = DockStyle.Fill;
            DescTextBox.Location = new Point(3, 3);
            DescTextBox.Multiline = true;
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(379, 385);
            DescTextBox.TabIndex = 0;
            DescTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(LookupButton);
            tabPage2.Controls.Add(BorrowedLabel);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(IsDamagedLabel);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(385, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Status";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LookupButton
            // 
            LookupButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LookupButton.Location = new Point(117, 104);
            LookupButton.Name = "LookupButton";
            LookupButton.Size = new Size(107, 37);
            LookupButton.TabIndex = 1;
            LookupButton.Text = "Lookup";
            LookupButton.UseVisualStyleBackColor = true;
            // 
            // BorrowedLabel
            // 
            BorrowedLabel.AutoSize = true;
            BorrowedLabel.Location = new Point(117, 70);
            BorrowedLabel.Name = "BorrowedLabel";
            BorrowedLabel.Size = new Size(45, 17);
            BorrowedLabel.TabIndex = 2;
            BorrowedLabel.Text = "(none)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 70);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 1;
            label8.Text = "Borrowed:";
            // 
            // IsDamagedLabel
            // 
            IsDamagedLabel.AutoSize = true;
            IsDamagedLabel.Location = new Point(132, 42);
            IsDamagedLabel.Name = "IsDamagedLabel";
            IsDamagedLabel.Size = new Size(26, 17);
            IsDamagedLabel.TabIndex = 0;
            IsDamagedLabel.Text = "No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 42);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 0;
            label6.Text = "Is Damaged:";
            // 
            // panel1
            // 
            panel1.Controls.Add(ConfirmButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 56);
            panel1.TabIndex = 1;
            // 
            // BooksDialog
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(393, 477);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BooksDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            Load += BooksDialog_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ConfirmButton;
        private TextBox ISBNTextBox;
        private Label label1;
        private Label label2;
        private TextBox TitleTextBox;
        private Label label3;
        private TextBox AuthorTextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private TextBox PublisherTextBox;
        private TabPage tabPage3;
        private DateTimePicker DatePublishedDatePicker;
        private Label label5;
        private TextBox DescTextBox;
        private Panel panel1;
        private Label label6;
        private Label IsDamagedLabel;
        private Label label8;
        private Label BorrowedLabel;
        private Button LookupButton;
    }
}