namespace LibCheck.Forms.Admin {
    partial class IDResultDialog {
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
            pictureBox1 = new PictureBox();
            SaveImageButton = new Button();
            PrintQueueButton = new Button();
            panel1 = new Panel();
            SFD = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // panel1
            // 
            panel1.Controls.Add(SaveImageButton);
            panel1.Controls.Add(PrintQueueButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 80);
            panel1.TabIndex = 3;
            // 
            // SFD
            // 
            SFD.Filter = "PNG Image|*.png|JPG Image|*.jpg|BMP Image|*.bmp";
            // 
            // IDResultDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(666, 368);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IDResultDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Generated";
            FormClosing += IDResultDialog_FormClosing;
            Load += IDResultDialog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button SaveImageButton;
        private Button PrintQueueButton;
        private Panel panel1;
        private SaveFileDialog SFD;
    }
}