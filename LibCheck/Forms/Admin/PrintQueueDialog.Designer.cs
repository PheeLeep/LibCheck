namespace LibCheck.Forms.Admin {
    partial class PrintQueueDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintQueueDialog));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            QueueLabel = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            DeleteButton = new Button();
            PrintLabel = new Button();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(QueueLabel);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 127);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_print_queue_45;
            pictureBox3.Location = new Point(24, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // QueueLabel
            // 
            QueueLabel.AutoSize = true;
            QueueLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            QueueLabel.ForeColor = Color.Black;
            QueueLabel.Location = new Point(72, 43);
            QueueLabel.Name = "QueueLabel";
            QueueLabel.Size = new Size(38, 46);
            QueueLabel.TabIndex = 5;
            QueueLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 96);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 4;
            label4.Text = "Queued Images";
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
            dataGridView1.Location = new Point(0, 167);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(509, 313);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(PrintLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 127);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 40);
            panel2.TabIndex = 3;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Right;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(421, 0);
            DeleteButton.Margin = new Padding(2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(44, 40);
            DeleteButton.TabIndex = 2;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // PrintLabel
            // 
            PrintLabel.Dock = DockStyle.Right;
            PrintLabel.FlatAppearance.BorderSize = 0;
            PrintLabel.FlatStyle = FlatStyle.Flat;
            PrintLabel.Image = (Image)resources.GetObject("PrintLabel.Image");
            PrintLabel.Location = new Point(465, 0);
            PrintLabel.Margin = new Padding(2);
            PrintLabel.Name = "PrintLabel";
            PrintLabel.Size = new Size(44, 40);
            PrintLabel.TabIndex = 3;
            PrintLabel.UseVisualStyleBackColor = true;
            PrintLabel.Click += PrintLabel_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // PrintQueueDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(509, 480);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrintQueueDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Print Queue";
            Load += PrintQueueDialog_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private Label QueueLabel;
        private Label label4;
        private Panel panel2;
        private Button DeleteButton;
        private Button PrintLabel;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}