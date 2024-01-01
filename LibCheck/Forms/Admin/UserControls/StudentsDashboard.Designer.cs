namespace LibCheck.Forms.Admin.UserControls {
    partial class StudentsDashboard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsDashboard));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            PrintLabel = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            CurrentlyBorrowedLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(0, 169);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(861, 353);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(PrintLabel);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 119);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 50);
            panel1.TabIndex = 2;
            // 
            // PrintLabel
            // 
            PrintLabel.Dock = DockStyle.Right;
            PrintLabel.FlatAppearance.BorderSize = 0;
            PrintLabel.FlatStyle = FlatStyle.Flat;
            PrintLabel.Image = (Image)resources.GetObject("PrintLabel.Image");
            PrintLabel.Location = new Point(806, 0);
            PrintLabel.Name = "PrintLabel";
            PrintLabel.Size = new Size(55, 50);
            PrintLabel.TabIndex = 7;
            PrintLabel.UseVisualStyleBackColor = true;
            PrintLabel.Click += PrintLabel_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Left;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(110, 0);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(55, 50);
            DeleteButton.TabIndex = 6;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Left;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Image = (Image)resources.GetObject("UpdateButton.Image");
            UpdateButton.Location = new Point(55, 0);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(55, 50);
            UpdateButton.TabIndex = 5;
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Left;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(0, 0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(55, 50);
            AddButton.TabIndex = 4;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CurrentlyBorrowedLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 119);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 67);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 2;
            label1.Text = "Students Registered";
            // 
            // CurrentlyBorrowedLabel
            // 
            CurrentlyBorrowedLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentlyBorrowedLabel.Location = new Point(106, 22);
            CurrentlyBorrowedLabel.Name = "CurrentlyBorrowedLabel";
            CurrentlyBorrowedLabel.Size = new Size(189, 45);
            CurrentlyBorrowedLabel.TabIndex = 1;
            CurrentlyBorrowedLabel.Text = "0";
            CurrentlyBorrowedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_student_45;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(55, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StudentsDashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "StudentsDashboard";
            Size = new Size(861, 522);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button PrintLabel;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private Panel panel2;
        private Label label1;
        private Label CurrentlyBorrowedLabel;
        private PictureBox pictureBox1;
    }
}
