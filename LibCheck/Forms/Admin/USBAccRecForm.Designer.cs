namespace LibCheck.Forms.Admin {
    partial class USBAccRecForm {
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
            drivesList = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)drivesList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "List of Drives Registered:";
            // 
            // drivesList
            // 
            drivesList.AllowUserToAddRows = false;
            drivesList.AllowUserToDeleteRows = false;
            drivesList.AllowUserToResizeRows = false;
            drivesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drivesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drivesList.Location = new Point(12, 56);
            drivesList.Name = "drivesList";
            drivesList.ReadOnly = true;
            drivesList.RowTemplate.Height = 25;
            drivesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            drivesList.Size = new Size(564, 206);
            drivesList.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(26, 279);
            button1.Name = "button1";
            button1.Size = new Size(119, 36);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(151, 279);
            button2.Name = "button2";
            button2.Size = new Size(119, 36);
            button2.TabIndex = 3;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // USBAccRecForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(588, 367);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(drivesList);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "USBAccRecForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Account Recovery";
            ((System.ComponentModel.ISupportInitialize)drivesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView drivesList;
        private Button button1;
        private Button button2;
    }
}