namespace LibCheck.Forms {
    partial class MainForm {
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
            components = new System.ComponentModel.Container();
            TimeLabel = new Label();
            ShowAdminButton = new Button();
            pictureBox1 = new PictureBox();
            camComboBox = new ComboBox();
            panel1 = new Panel();
            DateLabel = new Label();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            panel3 = new Panel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(38, 18);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(136, 31);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "00:00:00 PM";
            // 
            // ShowAdminButton
            // 
            ShowAdminButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowAdminButton.Location = new Point(802, 0);
            ShowAdminButton.Margin = new Padding(3, 4, 3, 4);
            ShowAdminButton.Name = "ShowAdminButton";
            ShowAdminButton.Size = new Size(103, 52);
            ShowAdminButton.TabIndex = 1;
            ShowAdminButton.Text = "Open Admin";
            ShowAdminButton.UseVisualStyleBackColor = true;
            ShowAdminButton.Click += ShowAdminButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(38, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // camComboBox
            // 
            camComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            camComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            camComboBox.FormattingEnabled = true;
            camComboBox.Location = new Point(159, 341);
            camComboBox.Name = "camComboBox";
            camComboBox.Size = new Size(330, 28);
            camComboBox.TabIndex = 3;
            camComboBox.SelectedIndexChanged += camComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(ShowAdminButton);
            panel1.Controls.Add(TimeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 93);
            panel1.TabIndex = 4;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(38, 49);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(161, 25);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "mm DD/MM/YYYY";
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 397);
            panel2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(camComboBox);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(905, 397);
            splitContainer1.SplitterDistance = 558;
            splitContainer1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 340);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 4;
            label1.Text = "Input Device:";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.Controls.Add(linkLabel1);
            splitContainer2.Size = new Size(343, 397);
            splitContainer2.SplitterDistance = 75;
            splitContainer2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 75);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 31);
            label2.Name = "label2";
            label2.Size = new Size(314, 174);
            label2.TabIndex = 5;
            label2.Text = "Let the students scan their ID to borrow and return their books.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(114, 225);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Scan not working?";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label TimeLabel;
        private Button ShowAdminButton;
        private PictureBox pictureBox1;
        private ComboBox camComboBox;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timer1;
        private Label DateLabel;
    }
}