using LibCheck.Modules;
using System.Text;

namespace LibCheck.Forms.SearchTools.UserControls
{
    public partial class StudentsSearchUC : UserControl
    {
        private readonly object _lock = new object();
        private bool isLoaded = false;
        public StudentsSearchUC()
        {
            InitializeComponent();
        }

        private void StudentsSearchUC_Load(object sender, EventArgs e)
        {
            LevelComboBox.Items.AddRange(Modules.Miscellaneous.Levels);
            LevelComboBox.SelectedIndex = 0;
            isLoaded = true;
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (!StudentIDRB.Checked) return;
            using (SearchDialog sd = new SearchDialog(SearchDialog.SearchType.Student, false))
            {
                sd.ShowDialog(this);
                if (string.IsNullOrWhiteSpace(sd.Value)) return;
                keywordTextBox.Text = sd.Value;
            }
        }

        private void GenderCheckBoxes(object sender, EventArgs e)
        {
            if (!MaleCBox.Checked && !FemaleCBox.Checked)
            {
                MaleCBox.Checked = true;
                FemaleCBox.Checked = true;
                return;
            }
            Compose();
        }

        private void Compose()
        {
            lock (_lock)
            {
                if (ParentForm is SearchWindow sw)
                {
                    List<string> queries = new List<string>();
                    StringBuilder sb = new StringBuilder();
                    if (!string.IsNullOrWhiteSpace(keywordTextBox.Text))
                    {
                        if (StudentIDRB.Checked)
                        {
                            if (Regexes.IsValidStudentID(keywordTextBox.Text))
                                queries.Add($"StudentID LIKE '%{keywordTextBox.Text}%'");
                        }
                        else if (FNameRB.Checked)
                        {
                            if (Regexes.IsValidAlphabet(keywordTextBox.Text))
                                queries.Add($"FirstName LIKE '%{keywordTextBox.Text}%'");
                        }
                        else if (LastNameRB.Checked)
                        {
                            if (Regexes.IsValidAlphanumSpace(keywordTextBox.Text))
                                queries.Add($"FirstName LIKE '%{keywordTextBox.Text}%'");
                        }
                    }

                    if (MaleCBox.Checked) queries.Add($"IsFemale = 0");
                    if (FemaleCBox.Checked) queries.Add($"IsFemale = 1");
                    if (LevelCBox.Checked)
                    {
                        int idx = LevelComboBox.SelectedIndex;

                        if (idx != -1)
                            queries.Add($"Level = {idx}");
                    }

                    for (int i = 0; i < queries.Count; i++)
                    {
                        sb.Append(queries[i]);
                        if (i < queries.Count - 1)
                            sb.Append(" OR ");
                    }

                    sw.PassOffWhereCond(sb.ToString());
                }
            }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            keywordTextBox.Clear();
        }

        private void LevelCBox_CheckedChanged(object sender, EventArgs e)
        {
            LevelComboBox.Enabled = LevelCBox.Checked;
            Compose();
        }

        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            Compose();
        }

        private void keywordTextBox_TextChanged(object sender, EventArgs e)
        {
            Compose();
        }
    }

}
