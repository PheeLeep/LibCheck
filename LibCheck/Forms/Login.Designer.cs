namespace LibCheck.Forms
{
    partial class Login
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
            LoginButton = new Button();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            linkForgorPass = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.BackColor = Color.DimGray;
            LoginButton.Enabled = false;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.ControlLightLight;
            LoginButton.Location = new Point(569, 297);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(248, 44);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 154);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(548, 151);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(296, 35);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += TextBoxes_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 199);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(548, 196);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(296, 35);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += TextBoxes_TextChanged;
            // 
            // linkForgorPass
            // 
            linkForgorPass.AutoSize = true;
            linkForgorPass.Location = new Point(681, 234);
            linkForgorPass.Name = "linkForgorPass";
            linkForgorPass.Size = new Size(174, 30);
            linkForgorPass.TabIndex = 4;
            linkForgorPass.TabStop = true;
            linkForgorPass.Text = "Forgot Password?";
            linkForgorPass.LinkClicked += linkForgorPass_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 49);
            label1.Name = "label1";
            label1.Size = new Size(209, 51);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 532);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LOGO_removebg_preview;
            pictureBox1.Location = new Point(-2, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            ClientSize = new Size(914, 382);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(linkForgorPass);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login | LibCheck";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginButton;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private LinkLabel linkForgorPass;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}