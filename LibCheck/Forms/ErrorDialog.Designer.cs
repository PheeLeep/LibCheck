namespace LibCheck.Forms
{
    partial class ErrorDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ErrorLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            CrashSaveInfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ErrorDiag_Icon;
            pictureBox1.Location = new Point(34, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 28);
            label1.Name = "label1";
            label1.Size = new Size(472, 84);
            label1.TabIndex = 1;
            label1.Text = "Sorry. But the program is experiencing a fatal error and it needs to close to prevent further damage.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.Location = new Point(34, 118);
            label2.Name = "label2";
            label2.Size = new Size(542, 48);
            label2.TabIndex = 2;
            label2.Text = "Raise an issue to LibCheck's Github for assistance, and provide with a stack trace below.";
            // 
            // ErrorLabel
            // 
            ErrorLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ErrorLabel.AutoEllipsis = true;
            ErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel.Location = new Point(104, 170);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(472, 25);
            ErrorLabel.TabIndex = 3;
            ErrorLabel.Text = "{err}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 170);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Error:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 214);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 5;
            label4.Text = "Additional Info:";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(34, 237);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(542, 186);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(482, 512);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CrashSaveInfoLabel
            // 
            CrashSaveInfoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CrashSaveInfoLabel.AutoEllipsis = true;
            CrashSaveInfoLabel.Location = new Point(34, 426);
            CrashSaveInfoLabel.Name = "CrashSaveInfoLabel";
            CrashSaveInfoLabel.Size = new Size(542, 83);
            CrashSaveInfoLabel.TabIndex = 8;
            CrashSaveInfoLabel.Text = "The error was saved to the 'crash' folder. Thank you and sorry for inconvenience.";
            // 
            // ErrorDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(609, 553);
            Controls.Add(CrashSaveInfoLabel);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ErrorLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRASHED!";
            Load += ErrorDialog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label ErrorLabel;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label CrashSaveInfoLabel;
    }
}