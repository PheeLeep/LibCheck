namespace LibCheck.Forms.Admin
{
    partial class ChangePasswordDiag
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
        private void InitializeComponent() {
            ChangeButton = new Button();
            oldPassTextBox = new TextBox();
            label3 = new Label();
            newPassTextBox = new TextBox();
            label1 = new Label();
            retypePassTextBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ChangeButton
            // 
            ChangeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ChangeButton.BackColor = Color.SeaShell;
            ChangeButton.Enabled = false;
            ChangeButton.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeButton.Location = new Point(132, 374);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(203, 48);
            ChangeButton.TabIndex = 0;
            ChangeButton.Text = "Change Password";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // oldPassTextBox
            // 
            oldPassTextBox.Location = new Point(29, 111);
            oldPassTextBox.Name = "oldPassTextBox";
            oldPassTextBox.Size = new Size(408, 32);
            oldPassTextBox.TabIndex = 8;
            oldPassTextBox.UseSystemPasswordChar = true;
            oldPassTextBox.TextChanged += passwordTextBoxes_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(29, 81);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 7;
            label3.Text = "Old Password:";
            // 
            // newPassTextBox
            // 
            newPassTextBox.Location = new Point(29, 206);
            newPassTextBox.Name = "newPassTextBox";
            newPassTextBox.Size = new Size(409, 32);
            newPassTextBox.TabIndex = 10;
            newPassTextBox.UseSystemPasswordChar = true;
            newPassTextBox.TextChanged += passwordTextBoxes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(29, 172);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 9;
            label1.Text = "New Password:";
            // 
            // retypePassTextBox
            // 
            retypePassTextBox.Location = new Point(28, 310);
            retypePassTextBox.Name = "retypePassTextBox";
            retypePassTextBox.Size = new Size(408, 32);
            retypePassTextBox.TabIndex = 12;
            retypePassTextBox.UseSystemPasswordChar = true;
            retypePassTextBox.TextChanged += passwordTextBoxes_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 274);
            label2.Name = "label2";
            label2.Size = new Size(166, 27);
            label2.TabIndex = 11;
            label2.Text = "Re-type Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(28, 24);
            label4.Name = "label4";
            label4.Size = new Size(232, 38);
            label4.TabIndex = 13;
            label4.Text = "Change Password";
            // 
            // ChangePasswordDiag
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(461, 434);
            Controls.Add(label4);
            Controls.Add(retypePassTextBox);
            Controls.Add(label2);
            Controls.Add(newPassTextBox);
            Controls.Add(label1);
            Controls.Add(oldPassTextBox);
            Controls.Add(label3);
            Controls.Add(ChangeButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordDiag";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangeButton;
        private TextBox oldPassTextBox;
        private Label label3;
        private TextBox newPassTextBox;
        private Label label1;
        private TextBox retypePassTextBox;
        private Label label2;
        private Label label4;
    }
}