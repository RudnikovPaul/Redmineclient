using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redmine_Client_2._0
{
    public partial class SettingsForm : Form
    {
        string username, pass, url, api;
        bool usernamePassCh;

        public SettingsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.LoginType) LoginPassRadioButton.Checked = true;
            else ApiKeyRadioButton.Checked = true;
            LoginPassAuthGroupBox.Visible = Properties.Settings.Default.LoginType;
            ApiKeyGroupBox.Visible = !Properties.Settings.Default.LoginType;
            tabPage1.Text = "Redmine Server";
            tabPage2.Text = "Options";

            ServerAddrTextBox.Text = Properties.Settings.Default.RedmineAddress;
            LoginPassRadioButton.Checked = Properties.Settings.Default.LoginType;
            UserNameTextBox.Text = Properties.Settings.Default.UserName;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
            ApiKeyTextBox.Text = Properties.Settings.Default.ApiKey;
            RunStartupCheckBox.Checked = Properties.Settings.Default.RunAtStartUp;
            DataSavingCheckBox.Checked = Properties.Settings.Default.AutoSaving;

            InitIt();
        }

        private void InitIt()
        {
            username = UserNameTextBox.Text;
            pass = PasswordTextBox.Text;
            url = ServerAddrTextBox.Text;
            api = ApiKeyTextBox.Text;
            usernamePassCh = LoginPassRadioButton.Checked;
        }

        private void LoginPassRadioButtonClick(object sender, EventArgs e)
        {
            ApiKeyGroupBox.Visible = false;
            LoginPassAuthGroupBox.Visible = true;
            LoginPassRadioButton.Checked = true;
            PasswordTextBox.PasswordChar = '•';
            ApiKeyTextBox.PasswordChar = '•';
        }

        private void ApiKeyRadioButtonClick(object sender, EventArgs e)
        {
            LoginPassAuthGroupBox.Visible = false;
            ApiKeyGroupBox.Visible = true;
            ApiKeyRadioButton.Checked = true;
            PasswordTextBox.PasswordChar = '•';
            ApiKeyTextBox.PasswordChar = '•';
        }

        private void SeePasswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '•') PasswordTextBox.PasswordChar = '\0';
            else PasswordTextBox.PasswordChar = '•';
        }

        private void SeeApiKeyButton_Click(object sender, EventArgs e)
        {
            if (ApiKeyTextBox.PasswordChar == '•') ApiKeyTextBox.PasswordChar = '\0';
            else ApiKeyTextBox.PasswordChar = '•';
        }

        private void SettingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '•';
            ApiKeyTextBox.PasswordChar = '•';
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (username != UserNameTextBox.Text | pass != PasswordTextBox.Text | url != ServerAddrTextBox.Text | api != ApiKeyTextBox.Text | usernamePassCh != LoginPassRadioButton.Checked)
            {
                if (Properties.Settings.Default.OldCommits)
                {
                    DialogResult result = MessageBox.Show("If you save the new user settings your local commits\r\nwill be discarded. Continue?", "Local time commits left", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes) BuisinessLogicClass.OldCommits(false);
                    else return;
                }
                DialogResult = DialogResult.Yes;
            }
            else DialogResult = DialogResult.OK;

            int counter = 0;
            for (int x = 0; x < ServerAddrTextBox.Text.Length; x++)
            {
                if (ServerAddrTextBox.Text.Substring(x, 1) == "/") counter++;
                if (counter == 4)
                {
                    ServerAddrTextBox.Text = ServerAddrTextBox.Text.Remove(x, ServerAddrTextBox.Text.Length - x);
                    break;
                }
            }

            Properties.Settings.Default.RedmineAddress = ServerAddrTextBox.Text;
            Properties.Settings.Default.LoginType = false;
            if (LoginPassRadioButton.Checked) Properties.Settings.Default.LoginType = true;
            Properties.Settings.Default.UserName = UserNameTextBox.Text;
            Properties.Settings.Default.Password = PasswordTextBox.Text;
            Properties.Settings.Default.ApiKey = ApiKeyTextBox.Text;
            Properties.Settings.Default.RunAtStartUp = RunStartupCheckBox.Checked;
            Properties.Settings.Default.AutoSaving = DataSavingCheckBox.Checked;

            Properties.Settings.Default.Save();
            
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
