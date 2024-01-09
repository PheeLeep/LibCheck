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
            genreComboBox = new ComboBox();
            DatePublishedDatePicker = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            PublisherTextBox = new TextBox();
            tabPage3 = new TabPage();
            DescTextBox = new TextBox();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            RemoveImageButton = new Button();
            AddImgButton = new Button();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConfirmButton.BackColor = Color.LimeGreen;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(271, 8);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(107, 37);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "Add";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ISBNTextBox.Location = new Point(24, 44);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(335, 29);
            ISBNTextBox.TabIndex = 1;
            ISBNTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 2;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 4;
            label2.Text = "Title:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleTextBox.Location = new Point(24, 109);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(335, 29);
            TitleTextBox.TabIndex = 3;
            TitleTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 149);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 6;
            label3.Text = "Author:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AuthorTextBox.Location = new Point(23, 172);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(335, 29);
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
            tabControl1.Size = new Size(393, 478);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(genreComboBox);
            tabPage1.Controls.Add(DatePublishedDatePicker);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(PublisherTextBox);
            tabPage1.Controls.Add(ISBNTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(AuthorTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(TitleTextBox);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(385, 444);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            // 
            // genreComboBox
            // 
            genreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(90, 282);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(269, 29);
            genreComboBox.TabIndex = 11;
            genreComboBox.SelectedIndexChanged += Controls_ValuesChanged;
            // 
            // DatePublishedDatePicker
            // 
            DatePublishedDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatePublishedDatePicker.Format = DateTimePickerFormat.Short;
            DatePublishedDatePicker.Location = new Point(152, 343);
            DatePublishedDatePicker.Name = "DatePublishedDatePicker";
            DatePublishedDatePicker.Size = new Size(143, 29);
            DatePublishedDatePicker.TabIndex = 10;
            DatePublishedDatePicker.ValueChanged += Controls_ValuesChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 348);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 9;
            label5.Text = "Date Published:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 285);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 8;
            label6.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 213);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 8;
            label4.Text = "Publisher:";
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PublisherTextBox.Location = new Point(23, 236);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Size = new Size(335, 29);
            PublisherTextBox.TabIndex = 7;
            PublisherTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DescTextBox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(385, 445);
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
            DescTextBox.Size = new Size(379, 439);
            DescTextBox.TabIndex = 0;
            DescTextBox.TextChanged += Controls_ValuesChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(385, 444);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(RemoveImageButton);
            panel3.Controls.Add(AddImgButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 45);
            panel3.TabIndex = 2;
            // 
            // RemoveImageButton
            // 
            RemoveImageButton.Location = new Point(124, 6);
            RemoveImageButton.Name = "RemoveImageButton";
            RemoveImageButton.Size = new Size(141, 36);
            RemoveImageButton.TabIndex = 0;
            RemoveImageButton.Text = "Remove Image";
            RemoveImageButton.UseVisualStyleBackColor = true;
            RemoveImageButton.Click += RemoveImageButton_Click;
            // 
            // AddImgButton
            // 
            AddImgButton.Location = new Point(3, 6);
            AddImgButton.Name = "AddImgButton";
            AddImgButton.Size = new Size(115, 36);
            AddImgButton.TabIndex = 0;
            AddImgButton.Text = "Add Image";
            AddImgButton.UseVisualStyleBackColor = true;
            AddImgButton.Click += AddImgButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(ConfirmButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 56);
            panel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // BooksDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(393, 534);
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
            FormClosing += BooksDialog_FormClosing;
            Load += BooksDialog_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
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
        private Label label4;
        private TextBox PublisherTextBox;
        private TabPage tabPage3;
        private DateTimePicker DatePublishedDatePicker;
        private Label label5;
        private TextBox DescTextBox;
        private Panel panel1;
        private Label label6;
        private ComboBox genreComboBox;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button RemoveImageButton;
        private Button AddImgButton;
        private OpenFileDialog openFileDialog1;
    }
}