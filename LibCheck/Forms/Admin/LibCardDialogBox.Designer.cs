namespace LibCheck.Forms.Admin {
    partial class LibCardDialogBox {
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
            SaveImageButton = new Button();
            PrintQueueButton = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            BackPicBox = new PictureBox();
            groupBox1 = new GroupBox();
            FrontPicBox = new PictureBox();
            SFD = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackPicBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FrontPicBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SaveImageButton);
            panel1.Controls.Add(PrintQueueButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 86);
            panel1.TabIndex = 4;
            // 
            // SaveImageButton
            // 
            SaveImageButton.Location = new Point(43, 20);
            SaveImageButton.Name = "SaveImageButton";
            SaveImageButton.Size = new Size(124, 40);
            SaveImageButton.TabIndex = 1;
            SaveImageButton.Text = "Save Image";
            SaveImageButton.UseVisualStyleBackColor = true;
            SaveImageButton.Click += SaveImageButton_Click;
            // 
            // PrintQueueButton
            // 
            PrintQueueButton.Location = new Point(173, 20);
            PrintQueueButton.Name = "PrintQueueButton";
            PrintQueueButton.Size = new Size(159, 40);
            PrintQueueButton.TabIndex = 2;
            PrintQueueButton.Text = "Add to Print Queue";
            PrintQueueButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 520);
            panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BackPicBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(543, 260);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Back";
            // 
            // BackPicBox
            // 
            BackPicBox.Dock = DockStyle.Fill;
            BackPicBox.Location = new Point(3, 23);
            BackPicBox.Margin = new Padding(3, 4, 3, 4);
            BackPicBox.Name = "BackPicBox";
            BackPicBox.Size = new Size(537, 234);
            BackPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            BackPicBox.TabIndex = 1;
            BackPicBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FrontPicBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Front";
            // 
            // FrontPicBox
            // 
            FrontPicBox.Dock = DockStyle.Fill;
            FrontPicBox.Location = new Point(3, 23);
            FrontPicBox.Margin = new Padding(3, 4, 3, 4);
            FrontPicBox.Name = "FrontPicBox";
            FrontPicBox.Size = new Size(537, 234);
            FrontPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            FrontPicBox.TabIndex = 1;
            FrontPicBox.TabStop = false;
            // 
            // SFD
            // 
            SFD.Filter = "PNG Image|*.png|JPG Image|*.jpg|BMP Image|*.bmp";
            // 
            // LibCardDialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 606);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LibCardDialogBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Card Generated";
            FormClosing += LibCardDialogBox_FormClosing;
            Load += LibCardDialogBox_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BackPicBox).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FrontPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button SaveImageButton;
        private Button PrintQueueButton;
        private Panel panel2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private PictureBox BackPicBox;
        private PictureBox FrontPicBox;
        private SaveFileDialog SFD;
    }
}