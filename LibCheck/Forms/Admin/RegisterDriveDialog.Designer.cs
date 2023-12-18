namespace LibCheck.Forms.Admin {
    partial class RegisterDriveDialog {
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
            RegisterButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegisterButton.Location = new Point(365, 284);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(107, 31);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 32);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 1;
            label1.Text = "Please insert a USB Flash Drive";
            // 
            // RegisterDriveDialog
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(484, 327);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterDriveDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register a Drive";
            FormClosing += RegisterDriveDialog_FormClosing;
            Load += RegisterDriveDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Label label1;
    }
}