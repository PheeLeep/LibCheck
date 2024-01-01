﻿namespace LibCheck.Forms.Admin.UserControls
{
    partial class BooksDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksDashboard));
            panel1 = new Panel();
            PrintLabel = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            DamagedLabel = new Label();
            CurrentlyBorrowedLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
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
            panel1.Controls.Add(PrintLabel);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 50);
            panel1.TabIndex = 0;
            // 
            // PrintLabel
            // 
            PrintLabel.Dock = DockStyle.Right;
            PrintLabel.FlatAppearance.BorderSize = 0;
            PrintLabel.FlatStyle = FlatStyle.Flat;
            PrintLabel.Image = (Image)resources.GetObject("PrintLabel.Image");
            PrintLabel.Location = new Point(807, 0);
            PrintLabel.Name = "PrintLabel";
            PrintLabel.Size = new Size(55, 50);
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
            DeleteButton.Location = new Point(110, 0);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(55, 50);
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
            UpdateButton.Location = new Point(55, 0);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(55, 50);
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
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(55, 50);
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
            dataGridView1.Location = new Point(0, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(862, 353);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 119);
            panel2.TabIndex = 4;
            // 
            // DamagedLabel
            // 
            DamagedLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DamagedLabel.Location = new Point(369, 22);
            DamagedLabel.Name = "DamagedLabel";
            DamagedLabel.Size = new Size(189, 45);
            DamagedLabel.TabIndex = 1;
            DamagedLabel.Text = "0";
            DamagedLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_book_damage_45;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(318, 22);
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
            pictureBox1.Location = new Point(55, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 67);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 2;
            label1.Text = "Currently Borrowed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(369, 67);
            label2.Name = "label2";
            label2.Size = new Size(219, 23);
            label2.TabIndex = 2;
            label2.Text = "Overdue, Lost, or Damaged";
            // 
            // BooksDashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "BooksDashboard";
            Size = new Size(862, 522);
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
    }
}
