﻿namespace LibCheck.Forms {
    partial class ForgotPasswordDiag {
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
            retypePassTextBox = new TextBox();
            label2 = new Label();
            newPassTextBox = new TextBox();
            label1 = new Label();
            recoveryTextBox = new TextBox();
            label3 = new Label();
            RecoverButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // retypePassTextBox
            // 
            retypePassTextBox.Location = new Point(31, 300);
            retypePassTextBox.Name = "retypePassTextBox";
            retypePassTextBox.Size = new Size(408, 31);
            retypePassTextBox.TabIndex = 20;
            retypePassTextBox.UseSystemPasswordChar = true;
            retypePassTextBox.TextChanged += passwordTextBoxes_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 270);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 19;
            label2.Text = "Re-type Password:";
            // 
            // newPassTextBox
            // 
            newPassTextBox.Location = new Point(31, 227);
            newPassTextBox.Name = "newPassTextBox";
            newPassTextBox.Size = new Size(408, 31);
            newPassTextBox.TabIndex = 18;
            newPassTextBox.UseSystemPasswordChar = true;
            newPassTextBox.TextChanged += passwordTextBoxes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 197);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 17;
            label1.Text = "New Password:";
            // 
            // recoveryTextBox
            // 
            recoveryTextBox.Location = new Point(207, 125);
            recoveryTextBox.MaxLength = 6;
            recoveryTextBox.Name = "recoveryTextBox";
            recoveryTextBox.Size = new Size(172, 31);
            recoveryTextBox.TabIndex = 16;
            recoveryTextBox.TextAlign = HorizontalAlignment.Center;
            recoveryTextBox.TextChanged += passwordTextBoxes_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 128);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 15;
            label3.Text = "Recovery Code:";
            // 
            // RecoverButton
            // 
            RecoverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RecoverButton.Enabled = false;
            RecoverButton.Location = new Point(319, 354);
            RecoverButton.Name = "RecoverButton";
            RecoverButton.Size = new Size(120, 35);
            RecoverButton.TabIndex = 14;
            RecoverButton.Text = "Recover";
            RecoverButton.UseVisualStyleBackColor = true;
            RecoverButton.Click += RecoverButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(440, 95);
            label4.TabIndex = 21;
            label4.Text = "Please enter one of the recovery codes provided during generation, then add a new password to recover your account.";
            // 
            // ForgotPasswordDiag
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(464, 414);
            Controls.Add(label4);
            Controls.Add(retypePassTextBox);
            Controls.Add(label2);
            Controls.Add(newPassTextBox);
            Controls.Add(label1);
            Controls.Add(recoveryTextBox);
            Controls.Add(label3);
            Controls.Add(RecoverButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordDiag";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Recovery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox retypePassTextBox;
        private Label label2;
        private TextBox newPassTextBox;
        private Label label1;
        private TextBox recoveryTextBox;
        private Label label3;
        private Button RecoverButton;
        private Label label4;
    }
}