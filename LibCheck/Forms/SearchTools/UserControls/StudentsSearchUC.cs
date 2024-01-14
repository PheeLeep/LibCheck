using LibCheck.Database.Tables;

namespace LibCheck.Forms.SearchTools.UserControls {
    public partial class StudentsSearchUC : UserControl {
        private readonly object _lock = new object();
        private bool isLoaded = false;
        private readonly List<Students>? query_snapshot;
        public StudentsSearchUC() {
            InitializeComponent();
            Database.Database.Read(out query_snapshot);
        }

        private void StudentsSearchUC_Load(object sender, EventArgs e) {
            LevelComboBox.Items.AddRange(Modules.Miscellaneous.Levels);
            LevelComboBox.SelectedIndex = 0;
            isLoaded = true;
            CriteriaRB_CheckedChanged(sender, e);
        }

        private void ScanButton_Click(object sender, EventArgs e) {
            if (!StudentIDRB.Checked)
                return;
            using (SearchDialog sd = new SearchDialog(SearchDialog.SearchType.Student, false, true)) {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value))
                    return;
                keywordTextBox.Text = sd.Value;
            }
        }

        private void GenderCheckBoxes(object sender, EventArgs e) {
            if (!MaleCBox.Checked && !FemaleCBox.Checked) {
                MaleCBox.Checked = true;
                FemaleCBox.Checked = true;
                return;
            }
            Compose();
        }

        private void Compose() {
            lock (_lock) {
                if (ParentForm is SearchWindow sw) {
                    List<Students>? s = query_snapshot?.ToList();
                    if (s != null) {
                        if (KeywordRB.Checked && !string.IsNullOrWhiteSpace(keywordTextBox.Text)) {
                            if (StudentIDRB.Checked) {
                                s = s.Where(ss => !string.IsNullOrWhiteSpace(ss.StudentID) &&
                                           ss.StudentID.Contains(keywordTextBox.Text)).ToList();
                            } else if (FNameRB.Checked) {
                                s = s.Where(ss => !string.IsNullOrWhiteSpace(ss.FirstName) &&
                                                  ss.FirstName.Contains(keywordTextBox.Text)).ToList();
                            } else if (LastNameRB.Checked) {
                                s = s.Where(ss => !string.IsNullOrWhiteSpace(ss.LastName) &&
                                                   ss.LastName.Contains(keywordTextBox.Text)).ToList();
                            }
                        }


                        if (CategoryRB.Checked) {
                            if (MaleCBox.Checked)
                                s = s.Where(ss => !ss.IsFemale).ToList();
                            if (FemaleCBox.Checked)
                                s = s.Where(ss => ss.IsFemale).ToList();
                            if (LevelCBox.Checked) {
                                int idx = LevelComboBox.SelectedIndex;

                                if (idx != -1)
                                    s = s.Where(ss => ss.Level == idx).ToList();
                            }

                        }
                    }

                    sw.PassOffWhereCond(s);
                }
            }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) {
            keywordTextBox.Clear();
        }

        private void LevelCBox_CheckedChanged(object sender, EventArgs e) {
            LevelComboBox.Enabled = LevelCBox.Checked;
            Compose();
        }

        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (!isLoaded)
                return;
            Compose();
        }

        private void keywordTextBox_TextChanged(object sender, EventArgs e) {
            Compose();
        }

        private void CriteriaRB_CheckedChanged(object sender, EventArgs e) {
            groupBox2.Enabled = KeywordRB.Checked;
            groupBox1.Enabled = CategoryRB.Checked;
            Compose();
        }
    }

}
