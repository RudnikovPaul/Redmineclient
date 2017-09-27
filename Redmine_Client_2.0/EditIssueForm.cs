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
    public partial class EditIssueForm : Form
    {
        DataStructureClass.DataStructure OldStructure = new DataStructureClass.DataStructure();
        DataStructureClass.DataStructure NewStructure = new DataStructureClass.DataStructure();
        private bool TypeCreate = false;

        public EditIssueForm()
        {
            InitializeComponent();
            if (BuisinessLogicClass.EditIssueId == -1234)
            {
                TypeCreate = true;
                Text = "Creat issue";
            }
            OldStructure = BuisinessLogicClass.GetOneIssue(BuisinessLogicClass.EditIssueId);

            {
                string[,] projects = BuisinessLogicClass.GetVariables(1);
                ProjectSelectComboBox.Items.Clear();

                BindingList<KeyValuePair<string, int>> items = new BindingList<KeyValuePair<string, int>>();

                int x = 0;
                while (x < projects.GetLength(0))
                {
                    items.Add(new KeyValuePair<string, int>(projects[x, 0], Convert.ToInt32(projects[x, 1])));
                    x++;
                }
                ProjectSelectComboBox.DisplayMember = "Key";
                ProjectSelectComboBox.ValueMember = "Value";
                ProjectSelectComboBox.DataSource = items;
                ProjectSelectComboBox.Text = OldStructure._projectName;
            } // projects

            {
                string[,] trackers = BuisinessLogicClass.GetVariables(2);
                TrackerComboBox.Items.Clear();

                BindingList<KeyValuePair<string, int>> items = new BindingList<KeyValuePair<string, int>>();

                int x = 0;
                while (x < trackers.GetLength(0))
                {
                    items.Add(new KeyValuePair<string, int>(trackers[x, 0], Convert.ToInt32(trackers[x, 1])));
                    x++;
                }
                TrackerComboBox.DisplayMember = "Key";
                TrackerComboBox.ValueMember = "Value";
                TrackerComboBox.DataSource = items;
                TrackerComboBox.Text = OldStructure._tracker;
            } // trackers

            {
                // сделать зависимость от типа пользователя.
                string[,] statuses = BuisinessLogicClass.GetVariables(3);
                StatusComboBox.Items.Clear();
                BindingList<KeyValuePair<string, int>> items = new BindingList<KeyValuePair<string, int>>();
                if ((OldStructure._statusId != 7 || OldStructure._statusId != 2) & OldStructure._statusId != 0) items.Add(new KeyValuePair<string, int>(OldStructure._status, OldStructure._statusId));
                else if (OldStructure._statusId == 7 || OldStructure._statusId == 2)
                {
                    int x = 0;
                    while (x < statuses.GetLength(0))
                    {
                        if (OldStructure._status == statuses[x, 0])
                        {
                            items.Add(new KeyValuePair<string, int>(statuses[x, 0], Convert.ToInt32(statuses[x, 1])));
                            items.Add(new KeyValuePair<string, int>(statuses[x + 1, 0], Convert.ToInt32(statuses[x + 1, 1])));
                        }
                        x++;
                    }                    
                }
                else
                {
                    items.Add(new KeyValuePair<string, int>(statuses[0, 0], Convert.ToInt32(statuses[0, 1])));
                    items.Add(new KeyValuePair<string, int>(statuses[1, 0], Convert.ToInt32(statuses[1, 1])));
                }

                StatusComboBox.DisplayMember = "Key";
                StatusComboBox.ValueMember = "Value";
                StatusComboBox.DataSource = items;
                TrackerComboBox.Text = OldStructure._tracker;
            } // statuses

            {
                string[,] prioritys = BuisinessLogicClass.GetVariables(4);
                PrioritycomboBox.Items.Clear();
                BindingList<KeyValuePair<string, int>> items = new BindingList<KeyValuePair<string, int>>();

                int x = 0;
                while (x < prioritys.GetLength(0))
                {
                    items.Add(new KeyValuePair<string, int>(prioritys[x, 0], Convert.ToInt32(prioritys[x, 1])));
                    x++;
                }
                PrioritycomboBox.DisplayMember = "Key";
                PrioritycomboBox.ValueMember = "Value";
                PrioritycomboBox.DataSource = items;
                PrioritycomboBox.Text = OldStructure._priority;
            } // prioritys

            {
                string[,] users = BuisinessLogicClass.GetVariables(6);
                AssignedToComboBox.Items.Clear();

                BindingList<KeyValuePair<string, int>> items = new BindingList<KeyValuePair<string, int>>();

                int x = 0;
                while (x < users.GetLength(0))
                {
                    items.Add(new KeyValuePair<string, int>(users[x, 0], Convert.ToInt32(users[x, 1])));
                    x++;
                }
                AssignedToComboBox.DisplayMember = "Key";
                AssignedToComboBox.ValueMember = "Value";
                AssignedToComboBox.DataSource = items;
                AssignedToComboBox.Text = OldStructure._assignedTo;

                AssignedToComboBox.Text = OldStructure._assignedTo;
            } // users

            if (!TypeCreate) Fill_data();
        }

        private void Fill_data()
        {
            SubjectNameTextBox.Text = OldStructure._subjectName;
            PercentDonecomboBox.SelectedIndex = Convert.ToInt32(OldStructure._percentDone/10);
            if (StartDateCheckBox.Checked = OldStructure._startDateCh) StartDateDateTimePicker.Value = OldStructure._startDate;
            if (OldStructure._dueDateCh) DueDateDateTimePicker.Value = OldStructure._dueDate;
            DueDateCheckBox.Checked = OldStructure._dueDateCh;

            DescriptionRichTextBox.Text = OldStructure._description;
            NotesRichTextBox.Text = OldStructure._notes;

            EstimTimeTextBox.Text = Convert.ToString(OldStructure._estimHours);
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

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewStructure = OldStructure;

                if (ProjectSelectComboBox.Text.Length < 2) throw new ArgumentException("Project");
                NewStructure._projectName = ProjectSelectComboBox.Text;
                NewStructure._projectId = Convert.ToInt32(ProjectSelectComboBox.SelectedValue);

                if (SubjectNameTextBox.Text.Length < 1) throw new ArgumentException("Subject");
                NewStructure._subjectName = SubjectNameTextBox.Text;

                NewStructure._percentDone = PercentDonecomboBox.SelectedIndex * 10;

                if (PrioritycomboBox.Text.Length < 2) throw new ArgumentException("Priority");
                NewStructure._priority = PrioritycomboBox.Text;
                NewStructure._priorityId = Convert.ToInt32(PrioritycomboBox.SelectedValue);

                NewStructure._assignedTo = AssignedToComboBox.Text;
                NewStructure._assignedToId = Convert.ToInt32(AssignedToComboBox.SelectedValue);

                if (StatusComboBox.Text.Length < 2) throw new ArgumentException("Status");
                NewStructure._status = StatusComboBox.Text;
                NewStructure._statusId = Convert.ToInt32(StatusComboBox.SelectedValue);

                if (TrackerComboBox.Text.Length < 2) throw new ArgumentException("Tracker");
                NewStructure._tracker = TrackerComboBox.Text;
                NewStructure._trackerId = Convert.ToInt32(TrackerComboBox.SelectedValue);

                NewStructure._description = DescriptionRichTextBox.Text;
                NewStructure._notes = NotesRichTextBox.Text;

                if (EstimTimeTextBox.Text.Length > 0) NewStructure._estimHours = Convert.ToInt32(EstimTimeTextBox.Text);

                if (StartDateCheckBox.Checked)
                {
                    NewStructure._startDate = StartDateDateTimePicker.Value;
                    NewStructure._startDateCh = true;
                }
                else
                {
                    NewStructure._startDate = new DateTime(1, 1, 1);
                    NewStructure._startDateCh = false;
                }
                if (DueDateCheckBox.Checked)
                {
                    NewStructure._dueDate = DueDateDateTimePicker.Value;
                    NewStructure._dueDateCh = true;
                }
                else
                {
                    NewStructure._dueDate = new DateTime(1, 1, 1);
                    NewStructure._dueDateCh = false;
                }                                
            }
            catch (ArgumentException err)
            {
                MessageBox.Show($"{err.Message} should be selected.", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TypeCreate) BuisinessLogicClass.CreateIssue(NewStructure);
            else BuisinessLogicClass.EditIssue(NewStructure);

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
