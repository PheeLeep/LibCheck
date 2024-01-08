namespace LibCheck.Forms.Admin
{
    partial class IDResultDialog
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
        private void InitializeComponent()
        {
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
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SaveImageButton
            // 
            SaveImageButton.BackColor = Color.RoyalBlue;
            SaveImageButton.ForeColor = Color.White;
            SaveImageButton.Location = new Point(52, 24);
            SaveImageButton.Margin = new Padding(4);
            SaveImageButton.Name = "SaveImageButton";
            SaveImageButton.Size = new Size(149, 48);
            SaveImageButton.TabIndex = 1;
            SaveImageButton.Text = "Save Image";
            SaveImageButton.UseVisualStyleBackColor = false;
            SaveImageButton.Click += SaveImageButton_Click;
            // 
            // PrintQueueButton
            // 
            PrintQueueButton.BackColor = Color.FromArgb(0, 192, 0);
            PrintQueueButton.ForeColor = Color.White;
            PrintQueueButton.Location = new Point(209, 24);
            PrintQueueButton.Margin = new Padding(4);
            PrintQueueButton.Name = "PrintQueueButton";
            PrintQueueButton.Size = new Size(208, 48);
            PrintQueueButton.TabIndex = 2;
            PrintQueueButton.Text = "Add to Print Queue";
            PrintQueueButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(SaveImageButton);
            panel1.Controls.Add(PrintQueueButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 346);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 96);
            panel1.TabIndex = 3;
            // 
            // SFD
            // 
            SFD.Filter = "PNG Image|*.png|JPG Image|*.jpg|BMP Image|*.bmp";
            // 
            // IDResultDialog
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(799, 442);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
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