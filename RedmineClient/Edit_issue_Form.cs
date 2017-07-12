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
    public partial class Edit_issue_Form : Form
    {
        public int task_id;

        private string _project, _subject, _priority, _assignedto, _status, _trackerid, _description, _notes;
        private int _done, _numberid, _estimhours;
        private DateTime _startdate, _duedate;
        private bool _startdateCh, _duedateCh;

        DataLogic_Class newObject = new DataLogic_Class();
        DataLogic_Class.DataStructure structure_for_updating = new DataLogic_Class.DataStructure();
        DataLogic_Class.DataStructure structure_for_creating = new DataLogic_Class.DataStructure();

        public Edit_issue_Form()
        {
            InitializeComponent();
            ProjectSelectComboBox.DataSource = newObject.GetVariables(0);
            TrackerComboBox.DataSource = newObject.GetVariables(1);
            StatusComboBox.DataSource = newObject.GetVariables(2);
            PrioritycomboBox.DataSource = newObject.GetVariables(3);
            AssignedToComboBox.DataSource = newObject.GetVariables(4);
        }

        public void Fill_data(int id)
        {
            structure_for_updating = newObject.Get_one_issue(id);
            _numberid = structure_for_updating._numberid;
            _project = ProjectSelectComboBox.Text = structure_for_updating._project;
            _subject = SubjectNameTextBox.Text = structure_for_updating._subject;
            _done = PercentDonecomboBox.SelectedIndex = Convert.ToInt32(Convert.ToString(structure_for_updating._done).Substring(0,1));
            _priority = PrioritycomboBox.Text = structure_for_updating._priority;
            _assignedto = AssignedToComboBox.Text = structure_for_updating._assignedto;
            _status = StatusComboBox.Text = structure_for_updating._status;
            _trackerid = TrackerComboBox.Text = structure_for_updating._trackerid;
            _startdate = structure_for_updating._startdate;
            _duedate = structure_for_updating._duedate;
            if (_startdateCh = StartDateCheckBox.Checked = structure_for_updating._startdateCh) _startdate = StartDateDateTimePicker.Value = structure_for_updating._startdate;
            if (structure_for_updating._duedateCh) _duedate = DueDateDateTimePicker.Value = structure_for_updating._duedate;
            _duedateCh = DueDateCheckBox.Checked = structure_for_updating._duedateCh;

            _description = DescriptionRichTextBox.Text = structure_for_updating._description;
            _notes = NotesRichTextBox.Text = structure_for_updating._notes;

            _estimhours = structure_for_updating._estimhours;
            EstimTimeTextBox.Text = Convert.ToString(structure_for_updating._estimhours);

            string hours;
            string minutes;

            int time = structure_for_updating._currentussagetime;
            int hours_ = (time / 3600 % 60);
            int minutes_ = (time / 60 % 60);
            if (minutes_ < 10) minutes = "0" + minutes_;
            else minutes = (time / 60 % 60).ToString();
            if (hours_ < 10) hours = "0" + hours_;
            else hours = (time / 3600 % 60).ToString();
            TimeAfterLastCommitLabel.Text = Convert.ToString(hours) + ":" + Convert.ToString(minutes);
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

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                structure_for_creating._project = ProjectSelectComboBox.Text;
                structure_for_creating._projectid = ProjectSelectComboBox.SelectedIndex + 1;

                structure_for_creating._subject = SubjectNameTextBox.Text;
                structure_for_creating._done = PercentDonecomboBox.SelectedIndex;
                structure_for_creating._priority = PrioritycomboBox.Text;
                structure_for_creating._assignedto = AssignedToComboBox.Text;
                structure_for_creating._assignedtoid = AssignedToComboBox.SelectedIndex + 1;

                structure_for_creating._status = StatusComboBox.Text;
                structure_for_creating._trackerid = TrackerComboBox.Text;
                structure_for_creating._description = DescriptionRichTextBox.Text;
                structure_for_creating._notes = NotesRichTextBox.Text;
                structure_for_creating._estimhours = Convert.ToInt32(EstimTimeTextBox.Text);
                structure_for_creating._numberid = structure_for_updating._numberid;
               /*
                String text = OverallTimeTextBox.Text;
                int charIndex = text.IndexOf(':');
                if (text.Length == 0) OverallTimeTextBox.Text = "0:0";
                structure_for_creating._currentussagetime = structure_for_updating._currentussagetime; //Convert.ToInt32(OverallTimeTextBox.Text.Substring(0, charIndex)) * 3600 + Convert.ToInt32(OverallTimeTextBox.Text.Substring(charIndex + 1, text.Length - charIndex - 1)) * 60;
                */
                structure_for_creating._commit = structure_for_updating._commit;

                if (structure_for_creating._startdateCh = StartDateCheckBox.Checked) structure_for_creating._startdate = StartDateDateTimePicker.Value;
                else
                {
                    structure_for_creating._startdate = new DateTime(1, 1, 1);
                    structure_for_creating._startdateCh = false;
                }
                if (structure_for_creating._duedateCh = DueDateCheckBox.Checked) structure_for_creating._duedate = DueDateDateTimePicker.Value;
                else
                {
                    structure_for_creating._duedate = new DateTime(1, 1, 1);
                    structure_for_creating._duedateCh = false;
                }

                if (structure_for_creating._project != _project |
                    structure_for_creating._subject != _subject |
                    structure_for_creating._done != _done |
                    structure_for_creating._priority != _priority |
                    structure_for_creating._assignedto != _assignedto |
                    structure_for_creating._status != _status |
                    structure_for_creating._trackerid != _trackerid |
                    structure_for_creating._description != _description |
                    structure_for_creating._notes != _notes |
                    structure_for_creating._estimhours != _estimhours |
                    structure_for_creating._numberid != _numberid |
                    structure_for_creating._startdate != _startdate |
                    structure_for_creating._duedate != _duedate |
                    structure_for_creating._startdateCh != _startdateCh |
                    structure_for_creating._duedateCh != _duedateCh 
                    ) structure_for_creating._commit = true; 


                DataLogic_Class newObject2 = new DataLogic_Class();
                newObject2.Write_new_issue_information(structure_for_creating); // here we have the last state of our tasks.
                // if there is no online connection also add a commit instance for the task into journal json.

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
    }
}
