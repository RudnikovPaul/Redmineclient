using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedmineClient
{
    public partial class Commit_Form : Form
    {
        public int task_id;
        private string[] activity_ids;

        DataLogic_Class newObject = new DataLogic_Class();
        DataLogic_Class.DataStructure structure_for_creating = new DataLogic_Class.DataStructure();

        public Commit_Form()
        {
            InitializeComponent();            
            
            ComboBoxActivity.DataSource = newObject.GetVariables(5);
            activity_ids = newObject.GetVariables(6);

        }

        public void Fill_data(int id)
        {
            task_id = id;
            structure_for_creating = newObject.Get_one_issue(task_id);
            labelProjectContent.Text = structure_for_creating._project;
            labelIssueContent.Text = structure_for_creating._subject;
            //MessageBox.Show(Convert.ToString(structure_for_creating._currentussagetime));
            labelTimeContent.Text = String.Format("{0:0.##}", (double)structure_for_creating._currentussagetime / 3600);
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            try
            {
                structure_for_creating._activity = Convert.ToInt32(activity_ids[ComboBoxActivity.SelectedIndex]);
                structure_for_creating._comment = CommentRichTextBox.Text;
                
                newObject.Write_new_issue_information(structure_for_creating); //last state file will always be updated.
                // if there is a connection to the server and we have not commited changes, ask the user and automatically send them to the server.
                // after sending the changes to the server, delete the journal json file.
                // if there is no online connection add a commit instance for the task into journal json.
                
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Somethings gone wrong.", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
