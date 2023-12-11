namespace LibCheck.Forms {
    partial class MainForm {
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
            WelcomeLabel = new Label();
            ShowAdminButton = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(54, 29);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(50, 20);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "label1";
            // 
            // ShowAdminButton
            // 
            ShowAdminButton.Location = new Point(617, 12);
            ShowAdminButton.Name = "ShowAdminButton";
            ShowAdminButton.Size = new Size(90, 39);
            ShowAdminButton.TabIndex = 1;
            ShowAdminButton.Text = "Open Admin";
            ShowAdminButton.UseVisualStyleBackColor = true;
            ShowAdminButton.Click += ShowAdminButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 394);
            Controls.Add(ShowAdminButton);
            Controls.Add(WelcomeLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Button ShowAdminButton;
    }
}