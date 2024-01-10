namespace LibCheck.Forms.Admin.UserControls {
    partial class EmailDashboard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel2 = new Panel();
            EmailSignUpButton = new Button();
            label1 = new Label();
            EmailQueueLabel = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ComposeButton = new Button();
            groupBox1 = new GroupBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(EmailSignUpButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(EmailQueueLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 95);
            panel2.TabIndex = 5;
            // 
            // EmailSignUpButton
            // 
            EmailSignUpButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailSignUpButton.FlatAppearance.BorderSize = 0;
            EmailSignUpButton.FlatStyle = FlatStyle.Flat;
            EmailSignUpButton.Image = Properties.Resources.error_40px;
            EmailSignUpButton.Location = new Point(613, 23);
            EmailSignUpButton.Margin = new Padding(2);
            EmailSignUpButton.Name = "EmailSignUpButton";
            EmailSignUpButton.Size = new Size(44, 40);
            EmailSignUpButton.TabIndex = 1;
            EmailSignUpButton.UseVisualStyleBackColor = true;
            EmailSignUpButton.Click += EmailSignUpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 2;
            label1.Text = "Emails on Queue";
            // 
            // EmailQueueLabel
            // 
            EmailQueueLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailQueueLabel.Location = new Point(93, 18);
            EmailQueueLabel.Margin = new Padding(2, 0, 2, 0);
            EmailQueueLabel.Name = "EmailQueueLabel";
            EmailQueueLabel.Size = new Size(143, 36);
            EmailQueueLabel.TabIndex = 1;
            EmailQueueLabel.Text = "0";
            EmailQueueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_email_queue_45;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(44, 18);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(2, 26);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(686, 255);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ComposeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 40);
            panel1.TabIndex = 6;
            // 
            // ComposeButton
            // 
            ComposeButton.Dock = DockStyle.Left;
            ComposeButton.FlatAppearance.BorderSize = 0;
            ComposeButton.FlatStyle = FlatStyle.Flat;
            ComposeButton.Image = Properties.Resources.icons8_compose_40;
            ComposeButton.Location = new Point(0, 0);
            ComposeButton.Margin = new Padding(2);
            ComposeButton.Name = "ComposeButton";
            ComposeButton.Size = new Size(44, 40);
            ComposeButton.TabIndex = 0;
            ComposeButton.UseVisualStyleBackColor = true;
            ComposeButton.Click += ComposeButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 135);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(690, 283);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recent Emails";
            // 
            // EmailDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "EmailDashboard";
            Size = new Size(690, 418);
            Load += EmailDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label EmailQueueLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button ComposeButton;
        private GroupBox groupBox1;
        private Button EmailSignUpButton;
    }
}
