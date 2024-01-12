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
            ISBNComboBox = new ComboBox();
            BookTitleLabel = new Label();
            BookBrowseBtn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            studIDComboBox = new ComboBox();
            StudNameLabel = new Label();
            StudBrowseBtn = new Button();
            label3 = new Label();
            panel1 = new Panel();
            ExecuteButton = new Button();
            OptionsPanel = new Panel();
            BorrowPanel = new Panel();
            label2 = new Label();
            DateBorrowDTP = new DateTimePicker();
            ReturnPanel = new Panel();
            ReturnLabel = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            BookGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            OptionsPanel.SuspendLayout();
            BorrowPanel.SuspendLayout();
            ReturnPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BookGroupBox
            // 
            BookGroupBox.BackColor = Color.CornflowerBlue;
            BookGroupBox.Controls.Add(ISBNComboBox);
            BookGroupBox.Controls.Add(BookTitleLabel);
            BookGroupBox.Controls.Add(BookBrowseBtn);
            BookGroupBox.Controls.Add(label1);
            BookGroupBox.Dock = DockStyle.Top;
            BookGroupBox.Location = new Point(0, 0);
            BookGroupBox.Name = "BookGroupBox";
            BookGroupBox.Size = new Size(537, 147);
            BookGroupBox.TabIndex = 0;
            BookGroupBox.TabStop = false;
            BookGroupBox.Text = "Book";
            // 
            // ISBNComboBox
            // 
            ISBNComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ISBNComboBox.FormattingEnabled = true;
            ISBNComboBox.Location = new Point(95, 50);
            ISBNComboBox.Name = "ISBNComboBox";
            ISBNComboBox.Size = new Size(315, 26);
            ISBNComboBox.TabIndex = 4;
            ISBNComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            BookBrowseBtn.BackColor = Color.LimeGreen;
            BookBrowseBtn.FlatStyle = FlatStyle.Flat;
            BookBrowseBtn.ForeColor = Color.White;
            BookBrowseBtn.Location = new Point(416, 50);
            BookBrowseBtn.Name = "BookBrowseBtn";
            BookBrowseBtn.Size = new Size(109, 31);
            BookBrowseBtn.TabIndex = 2;
            BookBrowseBtn.Text = "Browse";
            BookBrowseBtn.UseVisualStyleBackColor = false;
            BookBrowseBtn.Click += BookBrowseBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(studIDComboBox);
            groupBox1.Controls.Add(StudNameLabel);
            groupBox1.Controls.Add(StudBrowseBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 147);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student";
            // 
            // studIDComboBox
            // 
            studIDComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studIDComboBox.FormattingEnabled = true;
            studIDComboBox.Location = new Point(95, 50);
            studIDComboBox.Name = "studIDComboBox";
            studIDComboBox.Size = new Size(315, 26);
            studIDComboBox.TabIndex = 4;
            studIDComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            StudBrowseBtn.BackColor = Color.LimeGreen;
            StudBrowseBtn.FlatStyle = FlatStyle.Flat;
            StudBrowseBtn.ForeColor = Color.White;
            StudBrowseBtn.Location = new Point(416, 50);
            StudBrowseBtn.Name = "StudBrowseBtn";
            StudBrowseBtn.Size = new Size(109, 31);
            StudBrowseBtn.TabIndex = 2;
            StudBrowseBtn.Text = "Browse";
            StudBrowseBtn.UseVisualStyleBackColor = false;
            StudBrowseBtn.Click += StudBrowseBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 53);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(ExecuteButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 607);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 71);
            panel1.TabIndex = 2;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExecuteButton.BackColor = Color.LimeGreen;
            ExecuteButton.FlatStyle = FlatStyle.Flat;
            ExecuteButton.ForeColor = Color.White;
            ExecuteButton.Location = new Point(404, 18);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(109, 37);
            ExecuteButton.TabIndex = 3;
            ExecuteButton.Text = "Borrow";
            ExecuteButton.UseVisualStyleBackColor = false;
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
            // BorrowPanel
            // 
            BorrowPanel.BackColor = Color.CornflowerBlue;
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
            label2.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(376, 17);
            label2.TabIndex = 1;
            label2.Text = "Date to Return (max: 30 days, except sundays):";
            // 
            // DateBorrowDTP
            // 
            DateBorrowDTP.Location = new Point(81, 55);
            DateBorrowDTP.Name = "DateBorrowDTP";
            DateBorrowDTP.Size = new Size(316, 25);
            DateBorrowDTP.TabIndex = 0;
            DateBorrowDTP.ValueChanged += DateBorrowDTP_ValueChanged;
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
            richTextBox1.Location = new Point(3, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(531, 175);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BorrowReturnDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(537, 678);
            Controls.Add(OptionsPanel);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(BookGroupBox);
            DoubleBuffered = true;
            Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
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
            BorrowPanel.ResumeLayout(false);
            BorrowPanel.PerformLayout();
            ReturnPanel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BookGroupBox;
        private Label label1;
        private Button BookBrowseBtn;
        private Label BookTitleLabel;
        private GroupBox groupBox1;
        private Label StudNameLabel;
        private Button StudBrowseBtn;
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
        private ComboBox ISBNComboBox;
        private ComboBox studIDComboBox;
    }
}