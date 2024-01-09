namespace LibCheck.Forms.Admin
{
    partial class ComposeDiag
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
            groupBox1 = new GroupBox();
            SubjectTextBox = new TextBox();
            ToComboxBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BodyTextBox = new RichTextBox();
            panel1 = new Panel();
            ComposeBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(SubjectTextBox);
            groupBox1.Controls.Add(ToComboxBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(581, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student";
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Location = new Point(158, 78);
            SubjectTextBox.Margin = new Padding(4);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(393, 25);
            SubjectTextBox.TabIndex = 2;
            // 
            // ToComboxBox
            // 
            ToComboxBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToComboxBox.FormattingEnabled = true;
            ToComboxBox.Location = new Point(158, 40);
            ToComboxBox.Margin = new Padding(4);
            ToComboxBox.Name = "ToComboxBox";
            ToComboxBox.Size = new Size(393, 26);
            ToComboxBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 0;
            label2.Text = "Subject:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 18);
            label1.TabIndex = 0;
            label1.Text = "To:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BodyTextBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 133);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(581, 218);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Text";
            // 
            // BodyTextBox
            // 
            BodyTextBox.Dock = DockStyle.Fill;
            BodyTextBox.Location = new Point(4, 22);
            BodyTextBox.Margin = new Padding(4);
            BodyTextBox.Name = "BodyTextBox";
            BodyTextBox.Size = new Size(573, 192);
            BodyTextBox.TabIndex = 1;
            BodyTextBox.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(ComposeBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 351);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 67);
            panel1.TabIndex = 0;
            // 
            // ComposeBtn
            // 
            ComposeBtn.BackColor = Color.DodgerBlue;
            ComposeBtn.FlatStyle = FlatStyle.Flat;
            ComposeBtn.ForeColor = Color.White;
            ComposeBtn.Location = new Point(434, 18);
            ComposeBtn.Margin = new Padding(4);
            ComposeBtn.Name = "ComposeBtn";
            ComposeBtn.Size = new Size(118, 32);
            ComposeBtn.TabIndex = 0;
            ComposeBtn.Text = "Compose";
            ComposeBtn.UseVisualStyleBackColor = false;
            ComposeBtn.Click += ComposeLabel_Click;
            // 
            // ComposeDiag
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(581, 418);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ComposeDiag";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compose";
            Load += ComposeDiag_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button ComposeBtn;
        private RichTextBox BodyTextBox;
        private Label label1;
        private ComboBox ToComboxBox;
        private Label label2;
        private TextBox SubjectTextBox;
    }
}