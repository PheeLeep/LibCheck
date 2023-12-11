namespace LibCheck.Forms {
    partial class AuthenticateDiag {
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
            passwordTextBox = new TextBox();
            label3 = new Label();
            LoginButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(28, 98);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(408, 27);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 68);
            label3.Name = "label3";
            label3.Size = new Size(314, 20);
            label3.TabIndex = 5;
            label3.Text = "Please enter your password for authentication:";
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.BackColor = SystemColors.ScrollBar;
            LoginButton.Enabled = false;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(277, 149);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(159, 44);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 7;
            label1.Text = "Confirm if it's You.";
            // 
            // AuthenticateDiag
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(460, 209);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(LoginButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthenticateDiag";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authenticate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label3;
        private Button LoginButton;
        private Label label1;
    }
}