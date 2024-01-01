﻿using LibCheck.Database.Tables;
using LibCheck.Modules;
using static LibCheck.Modules.Miscellaneous;

namespace LibCheck.Forms.Admin {
    public partial class BooksDialog : Form {
        private Books book = new Books();
        private DatabaseMode mode;
        private bool _isEdited = false;
        public BooksDialog(DatabaseMode mode, string isbn = "") {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.mode = mode;
            if (mode != DatabaseMode.Add) {
                if (string.IsNullOrWhiteSpace(isbn) || Database.Database.Read(out List<Books>? r, whereCond: $"ISBN = '{isbn}'") < 1)
                    throw new InvalidOperationException("No ISBN provided.");
                if (r == null)
                    throw new InvalidOperationException("No data provided.");
                book = r[0];
            }
        }

        protected override CreateParams CreateParams {
            get {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void BooksDialog_Load(object sender, EventArgs e) {
            if (mode == DatabaseMode.Read) {
                TitleTextBox.ReadOnly = true;
                AuthorTextBox.ReadOnly = true;
                PublisherTextBox.ReadOnly = true;
                DescTextBox.ReadOnly = true;
                DatePublishedDatePicker.Enabled = false;
            }
            if (mode != DatabaseMode.Add) {
                ISBNTextBox.ReadOnly = true;
                ISBNTextBox.Text = book.ISBN;
                TitleTextBox.Text = book.Title;
                AuthorTextBox.Text = book.Author;
                PublisherTextBox.Text = book.Publisher;
                DescTextBox.Text = book.Description;
                DatePublishedDatePicker.Value = book.DatePublished;

                ConfirmButton.Text = mode == DatabaseMode.Update ? "Update" : "OK";
                _isEdited = false;
                return;
            }
            book.IsLostOrDamaged = false;
            book.StudentID = "(none)";
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (_isEdited) {
                if (!CheckInformation()) return;
                book.ISBN = ISBNTextBox.Text;
                book.Title = TitleTextBox.Text;
                book.Author = AuthorTextBox.Text;
                book.Publisher = PublisherTextBox.Text;
                book.DatePublished = DatePublishedDatePicker.Value;
                book.Description = DescTextBox.Text;

                if (!(mode == DatabaseMode.Add ? Database.Database.Insert(book) : Database.Database.Update(book))) {
                    MessageBox.Show(this, "Failed to execute a database.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                MessageBox.Show(this, "Database execution completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Controls_ValuesChanged(object sender, EventArgs e) {
            if (!_isEdited)
                _isEdited = true;
        }

        private bool CheckInformation() {
            try {
                if (!Regexes.IsValidISBN(ISBNTextBox.Text.Replace("-", ""))) throw new InvalidOperationException("Invalid ISBN provided.");
                if (string.IsNullOrWhiteSpace(TitleTextBox.Text)) throw new InvalidOperationException("Title is empty.");
                if (string.IsNullOrWhiteSpace(AuthorTextBox.Text)) throw new InvalidOperationException("Author is empty.");
                if (string.IsNullOrWhiteSpace(PublisherTextBox.Text)) throw new InvalidOperationException("Publisher is empty.");
                if (string.IsNullOrWhiteSpace(DescTextBox.Text)) DescTextBox.Text = "(no information provided.)";
                return true;
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }
    }
}
