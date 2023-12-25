namespace LibCheck.Forms.Admin {
    partial class SaveCodeDialog {
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
            label2 = new Label();
            listBox1 = new ListBox();
            SaveButton = new Button();
            SFD = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(528, 25);
            label1.TabIndex = 0;
            label1.Text = "Code generated. Please save the code and keep it in a safe space.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 67);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Codes below:";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(18, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(528, 179);
            listBox1.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(432, 304);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(104, 34);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SFD
            // 
            SFD.Filter = "Text File|*.txt";
            // 
            // SaveCodeDialog
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(563, 354);
            Controls.Add(SaveButton);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaveCodeDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Save Code";
            FormClosing += SaveCodeDialog_FormClosing;
            Load += SaveCodeDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button SaveButton;
        private SaveFileDialog SFD;
    }
}