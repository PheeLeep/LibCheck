namespace LibCheck.Forms.Admin.UserControls {
    partial class HomeDashboard {
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
            panel1 = new Panel();
            NBBLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            NBRLabel = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(NBBLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 112);
            panel1.TabIndex = 0;
            // 
            // NBBLabel
            // 
            NBBLabel.AutoSize = true;
            NBBLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NBBLabel.Location = new Point(25, 31);
            NBBLabel.Name = "NBBLabel";
            NBBLabel.Size = new Size(38, 46);
            NBBLabel.TabIndex = 1;
            NBBLabel.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(11, 82);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Books Borrowed today";
            // 
            // panel2
            // 
            panel2.Controls.Add(NBRLabel);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(292, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 112);
            panel2.TabIndex = 0;
            // 
            // NBRLabel
            // 
            NBRLabel.AutoSize = true;
            NBRLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            NBRLabel.Location = new Point(25, 31);
            NBRLabel.Name = "NBRLabel";
            NBRLabel.Size = new Size(38, 46);
            NBRLabel.TabIndex = 2;
            NBRLabel.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 1;
            label2.Text = "Books Returned today";
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "HomeDashboard";
            Size = new Size(860, 521);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label NBBLabel;
        private Label NBRLabel;
    }
}
