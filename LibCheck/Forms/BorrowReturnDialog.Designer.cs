namespace LibCheck.Forms {
    partial class BorrowReturnDialog {
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
            BookGroupBox = new GroupBox();
            BookTitleLabel = new Label();
            BookBrowseBtn = new Button();
            ISBNTextBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            StudNameLabel = new Label();
            StudBrowseBtn = new Button();
            StudIDTextBox = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            ExecuteButton = new Button();
            OptionsPanel = new Panel();
            ReturnPanel = new Panel();
            ReturnLabel = new Label();
            BorrowPanel = new Panel();
            label2 = new Label();
            DateBorrowDTP = new DateTimePicker();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            BookGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            OptionsPanel.SuspendLayout();
            ReturnPanel.SuspendLayout();
            BorrowPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BookGroupBox
            // 
            BookGroupBox.Controls.Add(BookTitleLabel);
            BookGroupBox.Controls.Add(BookBrowseBtn);
            BookGroupBox.Controls.Add(ISBNTextBox);
            BookGroupBox.Controls.Add(label1);
            BookGroupBox.Dock = DockStyle.Top;
            BookGroupBox.Location = new Point(0, 0);
            BookGroupBox.Name = "BookGroupBox";
            BookGroupBox.Size = new Size(537, 147);
            BookGroupBox.TabIndex = 0;
            BookGroupBox.TabStop = false;
            BookGroupBox.Text = "Book";
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BookTitleLabel.AutoEllipsis = true;
            BookTitleLabel.Location = new Point(35, 95);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new Size(490, 25);
            BookTitleLabel.TabIndex = 3;
            BookTitleLabel.Text = "Title:";
            // 
            // BookBrowseBtn
            // 
            BookBrowseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BookBrowseBtn.Location = new Point(416, 50);
            BookBrowseBtn.Name = "BookBrowseBtn";
            BookBrowseBtn.Size = new Size(109, 31);
            BookBrowseBtn.TabIndex = 2;
            BookBrowseBtn.Text = "Browse";
            BookBrowseBtn.UseVisualStyleBackColor = true;
            BookBrowseBtn.Click += BookBrowseBtn_Click;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ISBNTextBox.Location = new Point(95, 50);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.ReadOnly = true;
            ISBNTextBox.Size = new Size(315, 31);
            ISBNTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StudNameLabel);
            groupBox1.Controls.Add(StudBrowseBtn);
            groupBox1.Controls.Add(StudIDTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 147);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student";
            // 
            // StudNameLabel
            // 
            StudNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudNameLabel.AutoEllipsis = true;
            StudNameLabel.Location = new Point(35, 95);
            StudNameLabel.Name = "StudNameLabel";
            StudNameLabel.Size = new Size(490, 25);
            StudNameLabel.TabIndex = 3;
            StudNameLabel.Text = "Name:";
            // 
            // StudBrowseBtn
            // 
            StudBrowseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StudBrowseBtn.Location = new Point(416, 50);
            StudBrowseBtn.Name = "StudBrowseBtn";
            StudBrowseBtn.Size = new Size(109, 31);
            StudBrowseBtn.TabIndex = 2;
            StudBrowseBtn.Text = "Browse";
            StudBrowseBtn.UseVisualStyleBackColor = true;
            StudBrowseBtn.Click += StudBrowseBtn_Click;
            // 
            // StudIDTextBox
            // 
            StudIDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudIDTextBox.Location = new Point(95, 50);
            StudIDTextBox.Name = "StudIDTextBox";
            StudIDTextBox.ReadOnly = true;
            StudIDTextBox.Size = new Size(315, 31);
            StudIDTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 53);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(ExecuteButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 607);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 71);
            panel1.TabIndex = 2;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExecuteButton.Location = new Point(403, 24);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(109, 31);
            ExecuteButton.TabIndex = 3;
            ExecuteButton.Text = "Borrow";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // OptionsPanel
            // 
            OptionsPanel.Controls.Add(BorrowPanel);
            OptionsPanel.Controls.Add(ReturnPanel);
            OptionsPanel.Dock = DockStyle.Fill;
            OptionsPanel.Location = new Point(0, 294);
            OptionsPanel.Name = "OptionsPanel";
            OptionsPanel.Size = new Size(537, 114);
            OptionsPanel.TabIndex = 3;
            // 
            // ReturnPanel
            // 
            ReturnPanel.Controls.Add(ReturnLabel);
            ReturnPanel.Dock = DockStyle.Fill;
            ReturnPanel.Location = new Point(0, 0);
            ReturnPanel.Name = "ReturnPanel";
            ReturnPanel.Size = new Size(537, 114);
            ReturnPanel.TabIndex = 1;
            // 
            // ReturnLabel
            // 
            ReturnLabel.AutoEllipsis = true;
            ReturnLabel.BackColor = Color.Blue;
            ReturnLabel.Dock = DockStyle.Fill;
            ReturnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnLabel.ForeColor = Color.White;
            ReturnLabel.Location = new Point(0, 0);
            ReturnLabel.Name = "ReturnLabel";
            ReturnLabel.Size = new Size(537, 114);
            ReturnLabel.TabIndex = 1;
            ReturnLabel.Text = "Please scan the book first.";
            ReturnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BorrowPanel
            // 
            BorrowPanel.Controls.Add(label2);
            BorrowPanel.Controls.Add(DateBorrowDTP);
            BorrowPanel.Dock = DockStyle.Fill;
            BorrowPanel.Location = new Point(0, 0);
            BorrowPanel.Name = "BorrowPanel";
            BorrowPanel.Size = new Size(537, 114);
            BorrowPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 15);
            label2.Name = "label2";
            label2.Size = new Size(380, 25);
            label2.TabIndex = 1;
            label2.Text = "Date to Return (max: 30 days, except sundays):";
            // 
            // DateBorrowDTP
            // 
            DateBorrowDTP.Location = new Point(81, 55);
            DateBorrowDTP.Name = "DateBorrowDTP";
            DateBorrowDTP.Size = new Size(316, 31);
            DateBorrowDTP.TabIndex = 0;
            DateBorrowDTP.ValueChanged += DateBorrowDTP_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 408);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(537, 199);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Notes";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(3, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(531, 169);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BorrowReturnDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(537, 678);
            Controls.Add(OptionsPanel);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(BookGroupBox);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BorrowReturnDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Borrow/Return";
            Load += BorrowReturnDialog_Load;
            BookGroupBox.ResumeLayout(false);
            BookGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            OptionsPanel.ResumeLayout(false);
            ReturnPanel.ResumeLayout(false);
            BorrowPanel.ResumeLayout(false);
            BorrowPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BookGroupBox;
        private Label label1;
        private TextBox ISBNTextBox;
        private Button BookBrowseBtn;
        private Label BookTitleLabel;
        private GroupBox groupBox1;
        private Label StudNameLabel;
        private Button StudBrowseBtn;
        private TextBox StudIDTextBox;
        private Label label3;
        private Panel panel1;
        private Button ExecuteButton;
        private Panel OptionsPanel;
        private Panel BorrowPanel;
        private DateTimePicker DateBorrowDTP;
        private Label label2;
        private Panel ReturnPanel;
        private Label ReturnLabel;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
    }
}