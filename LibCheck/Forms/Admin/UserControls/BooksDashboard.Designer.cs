namespace LibCheck.Forms.Admin.UserControls {
    partial class BooksDashboard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksDashboard));
            panel1 = new Panel();
            SearchButton = new Button();
            PrintLabel = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            DamagedLabel = new Label();
            CurrentlyBorrowedLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(PrintLabel);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 40);
            panel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Right;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Image = Properties.Resources.icons8_search_32;
            SearchButton.Location = new Point(602, 0);
            SearchButton.Margin = new Padding(2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(44, 40);
            SearchButton.TabIndex = 4;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // PrintLabel
            // 
            PrintLabel.Dock = DockStyle.Right;
            PrintLabel.FlatAppearance.BorderSize = 0;
            PrintLabel.FlatStyle = FlatStyle.Flat;
            PrintLabel.Image = (Image)resources.GetObject("PrintLabel.Image");
            PrintLabel.Location = new Point(646, 0);
            PrintLabel.Margin = new Padding(2);
            PrintLabel.Name = "PrintLabel";
            PrintLabel.Size = new Size(44, 40);
            PrintLabel.TabIndex = 3;
            PrintLabel.UseVisualStyleBackColor = true;
            PrintLabel.Click += PrintLabel_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Left;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(88, 0);
            DeleteButton.Margin = new Padding(2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(44, 40);
            DeleteButton.TabIndex = 2;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Left;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Image = (Image)resources.GetObject("UpdateButton.Image");
            UpdateButton.Location = new Point(44, 0);
            UpdateButton.Margin = new Padding(2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(44, 40);
            UpdateButton.TabIndex = 1;
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
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(44, 40);
            AddButton.TabIndex = 0;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
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
            dataGridView1.Location = new Point(0, 135);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(690, 283);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(DamagedLabel);
            panel2.Controls.Add(CurrentlyBorrowedLabel);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 95);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 54);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 19);
            label2.TabIndex = 2;
            label2.Text = "Overdue, Lost, or Damaged";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 2;
            label1.Text = "Currently Borrowed";
            // 
            // DamagedLabel
            // 
            DamagedLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DamagedLabel.Location = new Point(295, 18);
            DamagedLabel.Margin = new Padding(2, 0, 2, 0);
            DamagedLabel.Name = "DamagedLabel";
            DamagedLabel.Size = new Size(151, 36);
            DamagedLabel.TabIndex = 1;
            DamagedLabel.Text = "0";
            DamagedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CurrentlyBorrowedLabel
            // 
            CurrentlyBorrowedLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentlyBorrowedLabel.Location = new Point(85, 18);
            CurrentlyBorrowedLabel.Margin = new Padding(2, 0, 2, 0);
            CurrentlyBorrowedLabel.Name = "CurrentlyBorrowedLabel";
            CurrentlyBorrowedLabel.Size = new Size(151, 36);
            CurrentlyBorrowedLabel.TabIndex = 1;
            CurrentlyBorrowedLabel.Text = "0";
            CurrentlyBorrowedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_book_damage_45;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(254, 18);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_book_borrowed_45;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(44, 18);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BooksDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "BooksDashboard";
            Size = new Size(690, 418);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button PrintLabel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label DamagedLabel;
        private Label CurrentlyBorrowedLabel;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Button SearchButton;
    }
}
