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
            components = new System.ComponentModel.Container();
            TimeLabel = new Label();
            ShowAdminButton = new Button();
            panel1 = new Panel();
            DateLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            StagePanel = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.White;
            TimeLabel.Location = new Point(32, 9);
            TimeLabel.Margin = new Padding(2, 0, 2, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(136, 31);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "00:00:00 PM";
            // 
            // ShowAdminButton
            // 
            ShowAdminButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowAdminButton.BackColor = Color.Transparent;
            ShowAdminButton.FlatAppearance.BorderSize = 0;
            ShowAdminButton.FlatStyle = FlatStyle.Flat;
            ShowAdminButton.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowAdminButton.ForeColor = SystemColors.ActiveCaptionText;
            ShowAdminButton.Image = Properties.Resources.Librarian_Settings;
            ShowAdminButton.Location = new Point(718, 9);
            ShowAdminButton.Margin = new Padding(2);
            ShowAdminButton.Name = "ShowAdminButton";
            ShowAdminButton.Size = new Size(50, 50);
            ShowAdminButton.TabIndex = 1;
            ShowAdminButton.UseVisualStyleBackColor = false;
            ShowAdminButton.Click += ShowAdminButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(ShowAdminButton);
            panel1.Controls.Add(TimeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 71);
            panel1.TabIndex = 4;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(32, 38);
            DateLabel.Margin = new Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(149, 23);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "mm DD/MM/YYYY";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // StagePanel
            // 
            StagePanel.Dock = DockStyle.Fill;
            StagePanel.Location = new Point(0, 71);
            StagePanel.Margin = new Padding(2);
            StagePanel.Name = "StagePanel";
            StagePanel.Size = new Size(790, 398);
            StagePanel.TabIndex = 7;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Navy;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 469);
            Controls.Add(StagePanel);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            MinimumSize = new Size(806, 508);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibCheck";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TimeLabel;
        private Button ShowAdminButton;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label DateLabel;
        private Panel StagePanel;
        private System.Windows.Forms.Timer timer2;
    }
}