namespace RedmineClient
{
    partial class Settings_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPassAuthGroupBox = new System.Windows.Forms.GroupBox();
            this.SeePasswordButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApiKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.SeeApiKeyButton = new System.Windows.Forms.Button();
            this.ApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ServerAddrTextBox = new System.Windows.Forms.TextBox();
            this.LoginPassRadioButton = new System.Windows.Forms.RadioButton();
            this.ApiKeyRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataSavingCheckBox = new System.Windows.Forms.CheckBox();
            this.RunStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginPassAuthGroupBox.SuspendLayout();
            this.ApiKeyGroupBox.SuspendLayout();
            this.SettingsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redmine Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authentification Mode:";
            // 
            // LoginPassAuthGroupBox
            // 
            this.LoginPassAuthGroupBox.Controls.Add(this.SeePasswordButton);
            this.LoginPassAuthGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginPassAuthGroupBox.Controls.Add(this.UserNameTextBox);
            this.LoginPassAuthGroupBox.Controls.Add(this.label4);
            this.LoginPassAuthGroupBox.Controls.Add(this.label3);
            this.LoginPassAuthGroupBox.Location = new System.Drawing.Point(7, 86);
            this.LoginPassAuthGroupBox.Name = "LoginPassAuthGroupBox";
            this.LoginPassAuthGroupBox.Size = new System.Drawing.Size(390, 88);
            this.LoginPassAuthGroupBox.TabIndex = 5;
            this.LoginPassAuthGroupBox.TabStop = false;
            this.LoginPassAuthGroupBox.Text = "Authentification";
            // 
            // SeePasswordButton
            // 
            this.SeePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SeePasswordButton.BackgroundImage")));
            this.SeePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeePasswordButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SeePasswordButton.Location = new System.Drawing.Point(353, 54);
            this.SeePasswordButton.Name = "SeePasswordButton";
            this.SeePasswordButton.Size = new System.Drawing.Size(26, 21);
            this.SeePasswordButton.TabIndex = 6;
            this.SeePasswordButton.UseVisualStyleBackColor = true;
            this.SeePasswordButton.Click += new System.EventHandler(this.SeePasswordButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedmineClient.Properties.Settings.Default, "PasswordValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordTextBox.Location = new System.Drawing.Point(81, 55);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(267, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = global::RedmineClient.Properties.Settings.Default.PasswordValue;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedmineClient.Properties.Settings.Default, "UserNameValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UserNameTextBox.Location = new System.Drawing.Point(81, 26);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(267, 20);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.Text = global::RedmineClient.Properties.Settings.Default.UserNameValue;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // ApiKeyGroupBox
            // 
            this.ApiKeyGroupBox.Controls.Add(this.SeeApiKeyButton);
            this.ApiKeyGroupBox.Controls.Add(this.ApiKeyTextBox);
            this.ApiKeyGroupBox.Controls.Add(this.label6);
            this.ApiKeyGroupBox.Location = new System.Drawing.Point(7, 86);
            this.ApiKeyGroupBox.Name = "ApiKeyGroupBox";
            this.ApiKeyGroupBox.Size = new System.Drawing.Size(390, 60);
            this.ApiKeyGroupBox.TabIndex = 6;
            this.ApiKeyGroupBox.TabStop = false;
            this.ApiKeyGroupBox.Text = "Authentification";
            // 
            // SeeApiKeyButton
            // 
            this.SeeApiKeyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SeeApiKeyButton.BackgroundImage")));
            this.SeeApiKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeeApiKeyButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SeeApiKeyButton.Location = new System.Drawing.Point(353, 22);
            this.SeeApiKeyButton.Name = "SeeApiKeyButton";
            this.SeeApiKeyButton.Size = new System.Drawing.Size(26, 21);
            this.SeeApiKeyButton.TabIndex = 5;
            this.SeeApiKeyButton.UseVisualStyleBackColor = true;
            this.SeeApiKeyButton.Click += new System.EventHandler(this.SeeApiKeyButton_Click);
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedmineClient.Properties.Settings.Default, "ApiKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ApiKeyTextBox.Location = new System.Drawing.Point(81, 23);
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.PasswordChar = '•';
            this.ApiKeyTextBox.Size = new System.Drawing.Size(267, 20);
            this.ApiKeyTextBox.TabIndex = 4;
            this.ApiKeyTextBox.Text = global::RedmineClient.Properties.Settings.Default.ApiKey;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "API Key:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(266, 235);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(347, 235);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.tabPage1);
            this.SettingsTabControl.Controls.Add(this.tabPage2);
            this.SettingsTabControl.Location = new System.Drawing.Point(12, 12);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(410, 217);
            this.SettingsTabControl.TabIndex = 9;
            this.SettingsTabControl.SelectedIndexChanged += new System.EventHandler(this.SettingsTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ApiKeyGroupBox);
            this.tabPage1.Controls.Add(this.ServerAddrTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LoginPassAuthGroupBox);
            this.tabPage1.Controls.Add(this.LoginPassRadioButton);
            this.tabPage1.Controls.Add(this.ApiKeyRadioButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ServerAddrTextBox
            // 
            this.ServerAddrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedmineClient.Properties.Settings.Default, "RedmineServerAddressValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ServerAddrTextBox.Location = new System.Drawing.Point(6, 25);
            this.ServerAddrTextBox.Name = "ServerAddrTextBox";
            this.ServerAddrTextBox.Size = new System.Drawing.Size(393, 20);
            this.ServerAddrTextBox.TabIndex = 1;
            this.ServerAddrTextBox.Text = global::RedmineClient.Properties.Settings.Default.RedmineServerAddressValue;
            // 
            // LoginPassRadioButton
            // 
            this.LoginPassRadioButton.AutoSize = true;
            this.LoginPassRadioButton.Checked = global::RedmineClient.Properties.Settings.Default.LoginPassRadiobuttonChecked;
            this.LoginPassRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RedmineClient.Properties.Settings.Default, "LoginPassRadiobuttonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LoginPassRadioButton.Location = new System.Drawing.Point(168, 62);
            this.LoginPassRadioButton.Name = "LoginPassRadioButton";
            this.LoginPassRadioButton.Size = new System.Drawing.Size(102, 17);
            this.LoginPassRadioButton.TabIndex = 3;
            this.LoginPassRadioButton.TabStop = true;
            this.LoginPassRadioButton.Text = "Login/Password";
            this.LoginPassRadioButton.UseVisualStyleBackColor = true;
            this.LoginPassRadioButton.Click += new System.EventHandler(this.LoginPassRadioButtonClick);
            // 
            // ApiKeyRadioButton
            // 
            this.ApiKeyRadioButton.AutoSize = true;
            this.ApiKeyRadioButton.Checked = global::RedmineClient.Properties.Settings.Default.ApiKeyRadioButtonChecked;
            this.ApiKeyRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RedmineClient.Properties.Settings.Default, "ApiKeyRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ApiKeyRadioButton.Location = new System.Drawing.Point(292, 62);
            this.ApiKeyRadioButton.Name = "ApiKeyRadioButton";
            this.ApiKeyRadioButton.Size = new System.Drawing.Size(63, 17);
            this.ApiKeyRadioButton.TabIndex = 4;
            this.ApiKeyRadioButton.Text = "API Key";
            this.ApiKeyRadioButton.UseVisualStyleBackColor = true;
            this.ApiKeyRadioButton.Click += new System.EventHandler(this.ApiKeyRadioButtonClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataSavingCheckBox);
            this.tabPage2.Controls.Add(this.RunStartupCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataSavingCheckBox
            // 
            this.DataSavingCheckBox.AutoSize = true;
            this.DataSavingCheckBox.Checked = global::RedmineClient.Properties.Settings.Default.AutoDataSavingCheckBoxSetting;
            this.DataSavingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RedmineClient.Properties.Settings.Default, "AutoDataSavingCheckBoxSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataSavingCheckBox.Location = new System.Drawing.Point(36, 74);
            this.DataSavingCheckBox.Name = "DataSavingCheckBox";
            this.DataSavingCheckBox.Size = new System.Drawing.Size(147, 17);
            this.DataSavingCheckBox.TabIndex = 1;
            this.DataSavingCheckBox.Text = "Do automatic data saving";
            this.DataSavingCheckBox.UseVisualStyleBackColor = true;
            this.DataSavingCheckBox.Visible = false;
            // 
            // RunStartupCheckBox
            // 
            this.RunStartupCheckBox.AutoSize = true;
            this.RunStartupCheckBox.Checked = global::RedmineClient.Properties.Settings.Default.RunAtStartupCheckBoxSetting;
            this.RunStartupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RedmineClient.Properties.Settings.Default, "RunAtStartupCheckBoxSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RunStartupCheckBox.Location = new System.Drawing.Point(36, 31);
            this.RunStartupCheckBox.Name = "RunStartupCheckBox";
            this.RunStartupCheckBox.Size = new System.Drawing.Size(93, 17);
            this.RunStartupCheckBox.TabIndex = 0;
            this.RunStartupCheckBox.Text = "Run at startup";
            this.RunStartupCheckBox.UseVisualStyleBackColor = true;
            this.RunStartupCheckBox.Visible = false;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 269);
            this.Controls.Add(this.SettingsTabControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(445, 307);
            this.MinimumSize = new System.Drawing.Size(445, 307);
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.LoginPassAuthGroupBox.ResumeLayout(false);
            this.LoginPassAuthGroupBox.PerformLayout();
            this.ApiKeyGroupBox.ResumeLayout(false);
            this.ApiKeyGroupBox.PerformLayout();
            this.SettingsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerAddrTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton LoginPassRadioButton;
        private System.Windows.Forms.RadioButton ApiKeyRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox ApiKeyGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox ApiKeyTextBox;
        private System.Windows.Forms.Button SaveButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox LoginPassAuthGroupBox;
        private System.Windows.Forms.CheckBox DataSavingCheckBox;
        private System.Windows.Forms.CheckBox RunStartupCheckBox;
        private System.Windows.Forms.Button SeePasswordButton;
        private System.Windows.Forms.Button SeeApiKeyButton;
    }
}