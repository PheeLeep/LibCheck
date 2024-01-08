namespace LibCheck.Forms.Admin
{
    partial class AccountRecoveryDiag
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
            label1 = new Label();
            panel1 = new Panel();
            RemoveButton = new Button();
            GenerateButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(588, 266);
            label1.TabIndex = 0;
            label1.Text = "List of Drives Registered:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(RemoveButton);
            panel1.Controls.Add(GenerateButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 101);
            panel1.TabIndex = 1;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.BackColor = Color.Red;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(176, 30);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(124, 36);
            RemoveButton.TabIndex = 5;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GenerateButton.BackColor = Color.LimeGreen;
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(29, 30);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(133, 36);
            GenerateButton.TabIndex = 4;
            GenerateButton.Text = "Register";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // AccountRecoveryDiag
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(588, 367);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountRecoveryDiag";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Account Recovery";
            Load += AccountRecoveryDiag_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button RemoveButton;
        private Button GenerateButton;
    }
}