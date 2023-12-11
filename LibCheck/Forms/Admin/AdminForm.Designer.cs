namespace LibCheck.Forms {
    partial class AdminForm {
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
            ChangePasswordButton = new Button();
            SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(698, 12);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(90, 39);
            ChangePasswordButton.TabIndex = 2;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangePasswordButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ChangePasswordButton;
    }
}