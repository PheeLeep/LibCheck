namespace LibCheck.Forms {
    partial class Login {
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
            label1 = new Label();
            LoginButton = new Button();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            linkForgorPass = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(138, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.BackColor = SystemColors.ScrollBar;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(304, 243);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(159, 44);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(158, 90);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(296, 30);
            usernameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 138);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(158, 135);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(296, 30);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // linkForgorPass
            // 
            linkForgorPass.AutoSize = true;
            linkForgorPass.Location = new Point(158, 183);
            linkForgorPass.Name = "linkForgorPass";
            linkForgorPass.Size = new Size(143, 23);
            linkForgorPass.TabIndex = 4;
            linkForgorPass.TabStop = true;
            linkForgorPass.Text = "Forgot Password?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(490, 313);
            Controls.Add(linkForgorPass);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login | LibCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoginButton;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private LinkLabel linkForgorPass;
    }
}