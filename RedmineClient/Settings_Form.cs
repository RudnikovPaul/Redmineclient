using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;

namespace RedmineClient
{
    public partial class Settings_Form : Form
    {
        string username, pass, url, api;
        bool usernamePassCh;

        public Settings_Form()
        {
            InitializeComponent();
            LoginPassAuthGroupBox.Visible = Properties.Settings.Default.LoginPassRadiobuttonChecked;
            ApiKeyGroupBox.Visible = Properties.Settings.Default.ApiKeyRadioButtonChecked;
            tabPage1.Text = "Redmine Server";
            tabPage2.Text = "Options";
            initIt();
        }

        private void initIt()
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

        private void ApiKeyRadioButtonClick(object sender, EventArgs e)
        {
            LoginPassAuthGroupBox.Visible = false;
            ApiKeyGroupBox.Visible = true;
            ApiKeyRadioButton.Checked = true;
            PasswordTextBox.PasswordChar = '•';
            ApiKeyTextBox.PasswordChar = '•';
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (username != UserNameTextBox.Text | pass != PasswordTextBox.Text | url != ServerAddrTextBox.Text | api != ApiKeyTextBox.Text | usernamePassCh != LoginPassRadioButton.Checked) Properties.Settings.Default.AuthenSettChanged = true;
            else Properties.Settings.Default.AuthenSettChanged = false;

            Properties.Settings.Default.RedmineServerAddressValue = ServerAddrTextBox.Text;
            Properties.Settings.Default.LoginPassRadiobuttonChecked = LoginPassRadioButton.Checked;
            Properties.Settings.Default.ApiKeyRadioButtonChecked = ApiKeyRadioButton.Checked;
            Properties.Settings.Default.UserNameValue = UserNameTextBox.Text;
            Properties.Settings.Default.PasswordValue = PasswordTextBox.Text;
            Properties.Settings.Default.ApiKey = ApiKeyTextBox.Text;
            Properties.Settings.Default.RunAtStartupCheckBoxSetting = RunStartupCheckBox.Checked;
            Properties.Settings.Default.AutoDataSavingCheckBoxSetting = DataSavingCheckBox.Checked;

            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
