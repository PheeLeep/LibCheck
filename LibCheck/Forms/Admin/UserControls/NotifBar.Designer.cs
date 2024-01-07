namespace LibCheck.Forms.Admin.UserControls {
    partial class NotifBar {
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
            button1 = new Button();
            CaptionLabel = new Label();
            TextLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(819, 0);
            button1.Name = "button1";
            button1.Size = new Size(41, 85);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CaptionLabel
            // 
            CaptionLabel.Dock = DockStyle.Top;
            CaptionLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CaptionLabel.Location = new Point(0, 0);
            CaptionLabel.Name = "CaptionLabel";
            CaptionLabel.Size = new Size(819, 37);
            CaptionLabel.TabIndex = 1;
            CaptionLabel.Text = "(title)";
            CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextLabel
            // 
            TextLabel.AutoEllipsis = true;
            TextLabel.Dock = DockStyle.Fill;
            TextLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextLabel.Location = new Point(0, 37);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(819, 48);
            TextLabel.TabIndex = 2;
            TextLabel.Text = "label1";
            TextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NotifBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            Controls.Add(TextLabel);
            Controls.Add(CaptionLabel);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "NotifBar";
            Size = new Size(860, 85);
            Load += NotifBar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label CaptionLabel;
        private Label TextLabel;
    }
}
