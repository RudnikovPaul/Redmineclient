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
    public partial class CommitForm : Form
    {
        DataStructureClass.DataStructure CommitStructure = BuisinessLogicClass.GetOneIssue(BuisinessLogicClass.SuperIssueId);

        public CommitForm()
        {
            InitializeComponent();
            string[,] activitys = BuisinessLogicClass.GetVariables(5);
            BindingList<KeyValuePair<string, int>> m_items = new BindingList<KeyValuePair<string, int>>();
            for (int i = 0; i < activitys.GetLength(0); i++) m_items.Add(new KeyValuePair<string, int> (activitys[i, 0], Convert.ToInt32(activitys[i, 1])));
            ComboBoxActivity.DisplayMember = "Key";
            ComboBoxActivity.ValueMember = "Value";
            ComboBoxActivity.DataSource = m_items;         
            
            FillData();           
        }

        private void FillData()
        {
            
            labelProjectContent.Text = CommitStructure._projectName;
            labelIssueContent.Text = CommitStructure._subjectName;

            string hours;
            string minutes;

            int hours_ = (CommitStructure._notCommittedWorkingTime / 3600 % 60);
            int minutes_ = (CommitStructure._notCommittedWorkingTime / 60 % 60);
            if (minutes_ < 10) minutes = "0" + minutes_;
            else minutes = (CommitStructure._notCommittedWorkingTime / 60 % 60).ToString();
            if (hours_ < 10) hours = "0" + hours_;
            else hours = (CommitStructure._notCommittedWorkingTime / 3600 % 60).ToString();

            labelTimeContent.Text = hours + ":" + minutes;
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            BuisinessLogicClass.CommitOneTimeEntry(BuisinessLogicClass.SuperIssueId, CommentRichTextBox.Text, Convert.ToInt32(ComboBoxActivity.SelectedValue.ToString()));
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
