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
            LoginButton = new Button();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            linkForgorPass = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.BackColor = Color.MediumBlue;
            LoginButton.Enabled = false;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.ControlLightLight;
            LoginButton.Location = new Point(127, 269);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(248, 44);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 124);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top;
            usernameTextBox.Location = new Point(127, 121);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(296, 26);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += TextBoxes_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top;
            passwordTextBox.Location = new Point(127, 166);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(296, 26);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += TextBoxes_TextChanged;
            // 
            // linkForgorPass
            // 
            linkForgorPass.Anchor = AnchorStyles.Top;
            linkForgorPass.AutoSize = true;
            linkForgorPass.Location = new Point(280, 204);
            linkForgorPass.Name = "linkForgorPass";
            linkForgorPass.Size = new Size(118, 19);
            linkForgorPass.TabIndex = 4;
            linkForgorPass.TabStop = true;
            linkForgorPass.Text = "Forgot Password?";
            linkForgorPass.LinkClicked += linkForgorPass_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 41);
            label1.Name = "label1";
            label1.Size = new Size(143, 36);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 382);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LOGO_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(LoginButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(linkForgorPass);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(403, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 382);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(0, 357);
            label4.Name = "label4";
            label4.Size = new Size(449, 25);
            label4.TabIndex = 5;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(852, 382);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel2;
        private Label label4;
    }
}