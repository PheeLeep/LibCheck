using LibCheck.Database.Tables;
using LibCheck.Modules;
using LibCheck.Modules.Security;
using System.Security;
using System.Text;

namespace LibCheck.Forms
{
    public partial class RegisterLib : Form
    {
        private bool isDone = false;
        private bool _showPass = false;

        private Stack<Panel> prevPanels = new Stack<Panel>();
        private Stack<Panel> nextPanels = new Stack<Panel>();
        private Panel currentPanel;
        public RegisterLib()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            currentPanel = WelcomePanel;
            InitPanels();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // Minimize form and control flickering.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void RegisterLib_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDone)
            {
                if (MessageBox.Show(this, "Do you want to discard changes?", "", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            switch (currentPanel)
            {
                case Panel p when p.Name.Equals(UsernamePanel.Name):
                    if (string.IsNullOrEmpty(usernameTxtBox.Text) || !Regexes.IsValidUsername(usernameTxtBox.Text))
                    {
                        MessageBox.Show(this, "Invalid username.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    break;
                case Panel p when p.Name.Equals(PasswordPanel.Name):
                    if (!IsValidPassword(passTxtBox.Text) || !IsValidPassword(passReTypeTxtBox.Text) ||
                        !passTxtBox.Text.Equals(passReTypeTxtBox.Text))
                    {
                        MessageBox.Show(this, "Invalid password. It must not be at least 8 characters and are matched.", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    break;
                case Panel p when p.Name.Equals(BasicInfoPanel.Name):
                    if (!Regexes.IsValidAlphabet(FNameTxtBox.Text))
                    {
                        MessageBox.Show(this, "Invalid first name.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if (!Regexes.IsValidAlphabet(LNameTxtBox.Text))
                    {
                        MessageBox.Show(this, "Invalid last name.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if (!string.IsNullOrEmpty(MNameTxtBox.Text) && !Regexes.IsValidAlphabet(MNameTxtBox.Text))
                    {
                        MessageBox.Show(this, "Invalid middle name.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    break;
                case Panel p when p.Name.Equals(FinishPanel.Name):
                    if (PleaseWait.IsRunning) return;
                    LibrarianInfo lInfo = new LibrarianInfo
                    {
                        Username = usernameTxtBox.Text,
                        FirstName = FNameTxtBox.Text,
                        MiddleName = MNameTxtBox.Text,
                        LastName = LNameTxtBox.Text,
                        BirthDate = BDatePicker.Value,
                        IsFemale = GenderCBox.SelectedIndex == 1
                    };

                    byte[] salt = CryptComp.GenerateRNGBytes();
                    byte[] sqlcDBSalt = CryptComp.GenerateRNGBytes();
                    LibrarianToken token = new LibrarianToken
                    {
                        Username = CryptComp.HashPassword(lInfo.Username, salt),
                        Salt = Convert.ToBase64String(salt),
                        Hash = CryptComp.HashPassword(passTxtBox.Text, salt),
                        SQLCipherDBKey = CryptComp.ConvertToString(CryptComp.GenerateSecurePassword()),
                        SQLCipherDBKeySalt = Convert.ToBase64String(sqlcDBSalt)
                    };

                    PleaseWait.RunInPleaseWait(this, new Action(() =>
                    {
                        try
                        {
                            char[] c = passTxtBox.Text.ToCharArray();
                            using (SecureString sb = new SecureString())
                            {
                                for (int i = 0; i < c.Length; i++)
                                    sb.AppendChar(c[i]);

                                Credentials.Register(token, lInfo, sb);
                                Invoke(new Action(() =>
                                {
                                    MessageBox.Show(this, "Registration succeed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isDone = true;
                                    DialogResult = DialogResult.Yes;
                                    Close();
                                }));
                            }
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() =>
                            {
                                MessageBox.Show(this, $"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }));
                        }
                    }));
                    return;
            }
            SwapPanels(nextPanels, prevPanels);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            SwapPanels(prevPanels, nextPanels);
        }

        private void SwapPanels(Stack<Panel> panel1, Stack<Panel> panel2)
        {
            if (panel1.Count == 0) return;
            panel2.Push(currentPanel);
            currentPanel = panel1.Pop();
            currentPanel.BringToFront();
            ChangeLabel();
        }

        private void InitPanels()
        {
            nextPanels.Push(FinishPanel);
            nextPanels.Push(BasicInfoPanel);
            nextPanels.Push(AccRecPanel);
            nextPanels.Push(PasswordPanel);
            nextPanels.Push(UsernamePanel);
        }

        private void ChangeLabel()
        {
            StringBuilder progress = new StringBuilder();
            if (prevPanels.Count > 0)
            {
                for (int i = 0; i < prevPanels.Count; i++)
                {
                    progress.Append('•');
                    if (i < prevPanels.Count - 1)
                        progress.Append(' ');
                }
            }
            progress.Append("[•] ");
            if (nextPanels.Count > 0)
            {
                for (int i = 0; i < nextPanels.Count; i++)
                {
                    progress.Append('-');
                    if (i < nextPanels.Count - 1)
                        progress.Append(' ');
                }
            }
            BulletProgressLabel.Text = progress.ToString();
            DescLabel.Text = currentPanel.Tag?.ToString();
            NextButton.Text = nextPanels.Count > 0 ? "Next" : "Finish";
        }

        private void RegisterLib_Load(object sender, EventArgs e)
        {
            ChangeLabel();
            currentPanel.BringToFront();
            BDatePicker.MaxDate = DateTime.Now;
            GenderCBox.SelectedIndex = 0;
        }

        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }

        private void ShowPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_showPass) return;
            _showPass = true;
            passTxtBox.UseSystemPasswordChar = false;
            passReTypeTxtBox.UseSystemPasswordChar = false;
        }

        private void ShowPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_showPass) return;
            _showPass = false;
            passTxtBox.UseSystemPasswordChar = true;
            passReTypeTxtBox.UseSystemPasswordChar = true;
        }

        private void BasicInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
