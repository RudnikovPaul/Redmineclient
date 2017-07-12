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
    public partial class New_issue_Form : Form
    {
        public New_issue_Form()
        {
            InitializeComponent();
            DataLogic_Class newObject = new DataLogic_Class();
            
            ProjectSelectComboBox.DataSource = newObject.GetVariables(0);
            TrackerComboBox.DataSource = newObject.GetVariables(1);
            StatusComboBox.DataSource = newObject.GetVariables(2);
            PrioritycomboBox.DataSource = newObject.GetVariables(3);
            AssignedToComboBox.DataSource = newObject.GetVariables(4);

            PercentDonecomboBox.SelectedIndex = 0;
            PrioritycomboBox.SelectedIndex = 1;
            StatusComboBox.SelectedIndex = 1;
            TrackerComboBox.SelectedIndex = 1;
        }

        private void StartDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StartDateDateTimePicker.Enabled) StartDateDateTimePicker.Enabled = false;
            else StartDateDateTimePicker.Enabled = true;
        }

        private void DueDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DueDateDateTimePicker.Enabled) DueDateDateTimePicker.Enabled = false;
            else DueDateDateTimePicker.Enabled = true;
        }

        private void EstimTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
            else if (EstimTimeTextBox.Text.Length == 4 && number != 8)
            {
                e.Handled = true;
            }
        }

            private void CreateButton_Click(object sender, EventArgs e)
        {
            DataLogic_Class.DataStructure structure_for_creating = new DataLogic_Class.DataStructure();
            try
            {
                structure_for_creating._project = ProjectSelectComboBox.Text;
                structure_for_creating._projectid = ProjectSelectComboBox.SelectedIndex+1;

                structure_for_creating._subject = SubjectNameTextBox.Text;
                structure_for_creating._done = PercentDonecomboBox.SelectedIndex;
                structure_for_creating._priority = PrioritycomboBox.Text;
                structure_for_creating._assignedto = AssignedToComboBox.Text;
                structure_for_creating._assignedtoid = AssignedToComboBox.SelectedIndex + 1;

                structure_for_creating._status = StatusComboBox.Text;
                structure_for_creating._trackerid = TrackerComboBox.Text;
                if (structure_for_creating._startdateCh = StartDateCheckBox.Checked) structure_for_creating._startdate = StartDateDateTimePicker.Value;
                if (structure_for_creating._duedateCh = DueDateCheckBox.Checked) structure_for_creating._duedate = DueDateDateTimePicker.Value;
                structure_for_creating._description = DescriptionRichTextBox.Text;
                structure_for_creating._notes = NotesRichTextBox.Text;
                if (EstimTimeTextBox.Text.Length == 0) EstimTimeTextBox.Text = "0";
                structure_for_creating._estimhours = Convert.ToInt32(EstimTimeTextBox.Text);
                structure_for_creating._numberid = -1;
                structure_for_creating._commit = true;

                DataLogic_Class newObject = new DataLogic_Class();
                newObject.Write_new_issue_information(structure_for_creating);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Please, check the values", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
