using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;


namespace RedmineClient
{
    public partial class Form1 : Form
    {
        private bool _timerTicking;
        private int _ticks;
        private int _currentStageTimerInterval = 1000;
        private int AutoSavingTimeInterval = 30000;
        private int lastSavedTime;
        private int _currentIssueId;
        private string _currentIssueName = "current issue";
        //private int _rowOfCurrentIssue;
        private int _mouseSelectedIssueId;
        //private bool _isARowSelected;
        //private int _currentIssueId_;
        private bool New_issue_can_be_selected = true;
        private int curntiss = 0;
        private bool _is_online = false;
        private bool _is_their_something_not_commited = false;
        private int amountOfTasks;
        private bool vso_ok = true;
        
        private DataLogic_Class.DataStructure GridContents = new DataLogic_Class.DataStructure();

        DataLogic_Class DataLogicObject = new DataLogic_Class();

        public Form1()
        {
            InitializeComponent();
            DataLogicObject.Init();
            ToolTip resetTimerButtonTooltip = new ToolTip();
            resetTimerButtonTooltip.SetToolTip(Reset_timer_button, "The time you have worked will be saved.");

            notifyIcon1.Text = "Redmine Client";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "REDMINE CLIENT";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            AutoSavingTimeTimer.Stop();
            AutoSavingTimeTimer.Interval = AutoSavingTimeInterval;
            AutoSavingTimeTimer.Start();

            

            bool check = false;
            if (!DataLogicObject.Connect_to_server())
            {
                MessageBox.Show("Redmine server " + Properties.Settings.Default.RedmineServerAddressValue + " is not accesible.\r\nYou will work in offline mode.", "Server not available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                WorkingMode_label.Visible = true;
                check = true;
                vso_ok = false;

            }
            if (DataLogicObject.authentificate_on_server() == false)
            {
                MessageBox.Show("Authentification has failed. \r\nThe server is available.", "Authentification fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                WorkingMode_label.Visible = true;
                check = true;
                WorkingMode_label.Visible = true;
                vso_ok = false;
                
            }

            if (vso_ok) DataLogicObject.SetVariables();

            
            Task_list_GridView.EnableHeadersVisualStyles = false;

            if (check == false) oldCommits();
            
            ConstructDataForGrid();
            
        }
        
        private void oldCommits ()
        {
            if (DataLogicObject.is_their_any_not_committed_commits() == true)
            {
                DialogResult result = MessageBox.Show("You have local time commits not sended to the server.\r\nDo you want to send them now?", "Local time commits", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    DataLogicObject.send_all_commits_to_server();
                    MessageBox.Show("Time was successfully logged to " + Properties.Settings.Default.RedmineServerAddressValue, "Local time commits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (result == DialogResult.No)
                {
                    DialogResult result2 = MessageBox.Show("Do you want to loose the previous commits?\r\nClick YES to loose, or NO to work in offline mode", "Local time commits", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result2 == DialogResult.Yes)
                    {
                        WorkingMode_label.Visible = false;
                        DataLogicObject.delete_local_commit_file();
                    }
                    if (result2 == DialogResult.No) WorkingMode_label.Visible = true;
                }
            }
        }
        
        public void ConstructDataForGrid()
        {
            Cursor = Cursors.AppStarting;
            
            Task_list_GridView.Rows.Clear();

            
            amountOfTasks = DataLogicObject.Getamount();
            DataLogicObject.SetParameters();

            for (int x = 0; x < amountOfTasks; x++)
            {
                GridContents = DataLogicObject.Get_all_issues(x);
                if (GridContents._commit) _is_their_something_not_commited = true;
            }

            if (!_is_their_something_not_commited & vso_ok == true) DataLogicObject.GetIssueData();
            
            for (int x = 0; x < amountOfTasks; x++)
            {
                GridContents = DataLogicObject.Get_all_issues(x);
                string commit = "  -";
                if (GridContents._commit) commit = "  +";
                string startDate = "";
                string dueDate = "";
                string donePercent = Convert.ToString(GridContents._done + "%");
                if (GridContents._startdateCh)
                {
                    string day = Convert.ToString(GridContents._startdate.Day);
                    string month = Convert.ToString(GridContents._startdate.Month);
                    if (Convert.ToString(GridContents._startdate.Day).Length == 1) day = "0" + Convert.ToString(GridContents._startdate.Day);
                    if (Convert.ToString(GridContents._startdate.Month).Length == 1) month = "0" + Convert.ToString(GridContents._startdate.Month);
                    if (Convert.ToString(GridContents._duedate.Year).Length == 4) startDate = day + "." + month + "." + Convert.ToString(GridContents._startdate.Year).Substring(2, 2);
                }
                
                if (GridContents._duedateCh)
                {
                    string day = Convert.ToString(GridContents._duedate.Day);
                    string month = Convert.ToString(GridContents._duedate.Month);
                    if (Convert.ToString(GridContents._duedate.Day).Length == 1) day = "0" + GridContents._duedate.Day;
                    if (Convert.ToString(GridContents._duedate.Month).Length == 1) month = "0" + GridContents._duedate.Month;
                    if (Convert.ToString(GridContents._duedate.Year).Length == 4) dueDate = day + "." + month + "." + Convert.ToString(GridContents._duedate.Year).Substring(2, 2);
                }
                
                Task_list_GridView.Rows.Add(GridContents._numberid, GridContents._subject, startDate, dueDate, donePercent, commit);
                if (GridContents._description != null)
                {
                    if (GridContents._description.Length > 2)
                    {
                        Task_list_GridView.Rows[x].Cells[1].ToolTipText = "                 Description:\r\n" + GridContents._description;
                    }
                }
                Task_list_GridView.Rows[x].Cells[0].ToolTipText = "double click opens the edit window.";
            }
            
            for (int x = 0; x < amountOfTasks; x++)
            {
                if (Convert.ToString(Task_list_GridView.Rows[x].Cells[5].Value) == "  +") Task_list_GridView.Rows[x].Cells[5].Style.BackColor = Color.Red;
            }

            if (Task_list_GridView.Rows.Count>0)
            {
                Task_list_GridView.Rows[0].Cells[0].Selected = true;
                Task_list_GridView.Rows[0].Cells[0].Selected = false;
            }
            Cursor = Cursors.Default;
        }
        

        private void RedmineClientFormResize(object sender, EventArgs e)
        {
            Hide();
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Show();
                WindowState = FormWindowState.Normal;
                Show();
                WindowState = FormWindowState.Normal;
            }
        }


        private void Start_timer_button_Click(object sender, EventArgs e)
        {
            if (!_timerTicking)
            {
                CurrentStageTimer.Interval = _currentStageTimerInterval;
                CurrentStageTimer.Start();
                Start_timer_button.Text = "Pause";
            }
            else
            {
                CurrentStageTimer.Stop();
                Start_timer_button.Text = "Continue";
            }
            _timerTicking = !_timerTicking;

            string Textforicon = "Redmine Client\nTime on " + _currentIssueName + ":\n" + Timer_label.Text;

            if (Textforicon.Length > 63)
            {
                _currentIssueName = _currentIssueName.Substring(0, 43);
                notifyIcon1.BalloonTipText = "Time on " + _currentIssueName + ":\n" + Timer_label.Text;
            }
            else notifyIcon1.BalloonTipText = Textforicon;
            
            Reset_timer_button.Enabled = true;
            
            DataLogic_Class.DataStructure structure_for_updating = DataLogicObject.Get_one_issue(_currentIssueId);
            structure_for_updating._commit = true;
            DataLogicObject.Write_new_issue_information(structure_for_updating);

            if (New_issue_can_be_selected)
            {
                
                _currentIssueId = Convert.ToInt32(Convert.ToString(Task_list_GridView
                    .Rows[Task_list_GridView.SelectedRows[0].Index].Cells[0].Value));
                
                _currentIssueName = Convert.ToString(Task_list_GridView
                    .Rows[Task_list_GridView.SelectedRows[0].Index].Cells[1].Value);
                for (int i = 0; i < 6; i++) Task_list_GridView.Rows[curntiss].Cells[i].Style.BackColor = Color.Gray;
                curntiss = Search_for_current_issue(_currentIssueId);
                
                for (int i = 0; i < 6; i++) Task_list_GridView.Rows[curntiss].Cells[i].Style.BackColor = Color.DimGray;
                CurrentIssueNameLabel.Text = _currentIssueName;
                New_issue_can_be_selected = false;
                _is_their_something_not_commited = true;
            }
        }

        private void Current_stage_timer_tick(object sender, EventArgs e)
        {
            _ticks++;
            UpdateTime();
            string Textforicon = "Redmine Client\nTime on " + _currentIssueName + ":\n" + Timer_label.Text;
            if (Textforicon.Length > 63)
            {
                _currentIssueName = _currentIssueName.Substring(0, 43);
                notifyIcon1.Text = "Time on " + _currentIssueName + ":\n" + Timer_label.Text;
            }
            else notifyIcon1.Text = Textforicon;


        }

        private void UpdateTime()
        {
            string hours;
            string minutes;
            string seconds;

            int hours_ = (_ticks / 3600 % 60);
            int minutes_ = (_ticks / 60 % 60);
            int seconds_ = (_ticks % 60);
            if (seconds_ < 10) seconds = "0" + seconds_;
            else seconds = (_ticks % 60).ToString();
            if (minutes_ < 10) minutes = "0" + minutes_;
            else minutes = (_ticks / 60 % 60).ToString();
            if (hours_ < 10) hours = "0" + hours_;
            else hours = (_ticks / 3600 % 60).ToString();
           
            Timer_label.Text = hours + ":" + minutes + ":" + seconds;
        }

        private void Reset_timer_button_Click(object sender, EventArgs e)
        {
            // first you will need to commit your work.
            lastSavedTime = lastSavedTime + _ticks;
            
            DataLogic_Class newObject = new DataLogic_Class();
            DataLogic_Class.DataStructure structure_for_updating = new DataLogic_Class.DataStructure();
            structure_for_updating = newObject.Get_one_issue(_currentIssueId);
            structure_for_updating._currentussagetime += _ticks;

            _ticks = 0;
            Timer_label.Text = "00:00:00";
            CurrentStageTimer.Stop();
            Start_timer_button.Text = "Start";
            _timerTicking = false;
            New_issue_can_be_selected = true;
            Reset_timer_button.Enabled = false;
            for (int i = 0; i < 6; i++) Task_list_GridView.Rows[curntiss].Cells[i].Style.BackColor = Color.Gray;
        }

        private void AutoSavingTimeTimerTick(object sender, EventArgs e)
        {
            lastSavedTime = lastSavedTime + _ticks;
            // saving into file.

            if (_timerTicking)
            {
                DataLogic_Class.DataStructure TimeCommitting = new DataLogic_Class.DataStructure();
                TimeCommitting = DataLogicObject.Get_one_issue(_currentIssueId);
                TimeCommitting._currentussagetime = TimeCommitting._currentussagetime + AutoSavingTimeInterval/1000;
                DataLogicObject.Write_new_issue_information(TimeCommitting);
            }
            
        }
        

        private void Task_list_gridView_clicked(object sender, EventArgs e)
        {
            try
            {
                _mouseSelectedIssueId = Convert.ToInt32(Task_list_GridView.SelectedRows[0].Cells[0].Value);

                //_isARowSelected = true;
                Commit_button.Enabled = true;
                Start_timer_button.Enabled = true;

                if (DataLogicObject.Get_one_issue(_mouseSelectedIssueId)._commit) _is_their_something_not_commited = true;
                else _is_their_something_not_commited = false;

                if (New_issue_can_be_selected == true) _currentIssueId = Convert.ToInt32(Convert.ToString(Task_list_GridView.Rows[Task_list_GridView.SelectedRows[0].Index].Cells[0].Value));
            }
            catch {  }
        }

        private void Sorting_items_GridView_Clicked(object sender, EventArgs e)
        {
            if (Task_list_GridView.SortedColumn.Name == "GridStart") sort_GridView_items(2);
            if (Task_list_GridView.SortedColumn.Name == "GridDue") sort_GridView_items(3);
        }

        private void sort_GridView_items(int columnId)
        {
            int[,] arrayforsorting = new int[amountOfTasks, 2];
            int[,] sortedarray = new int[amountOfTasks, 2];
            for (int x = 0; x < amountOfTasks; x++)
            {
                if (Convert.ToString(Task_list_GridView.Rows[x].Cells[columnId].Value).Length == 8)
                {
                    string date = Convert.ToString(Task_list_GridView.Rows[x].Cells[columnId].Value);
                    arrayforsorting[x, 1] = Convert.ToInt32(date.Substring(6, 2) + date.Substring(3, 2) + date.Substring(0, 2));
                }
                else arrayforsorting[x, 1] = 800000 + x;
                arrayforsorting[x, 0] = x;
            }   // запись и конвертация даты в массив

            int smallest = 999999;
            int smy = 0;
            for (int x = 0; x < amountOfTasks; x++)
            {
                for (int y = 0; y < amountOfTasks; y++)
                {

                    if (arrayforsorting[y, 1] < smallest)
                    {
                        smallest = arrayforsorting[y, 1];
                        smy = y;
                    }
                }
                sortedarray[x, 1] = arrayforsorting[smy, 1];
                sortedarray[x, 0] = arrayforsorting[smy, 0];
                smallest = 999999;
                arrayforsorting[smy, 1] = 999999;
            }  // нахождение минимальных элементов

            DataGridView Grid2 = new DataGridView();  // создание нового дата грида куда запишутся все данные
            Grid2.Columns.Add("G1", "");
            Grid2.Columns.Add("G2", "");
            Grid2.Columns.Add("G3", "");
            Grid2.Columns.Add("G4", "");
            Grid2.Columns.Add("G5", "");
            Grid2.Columns.Add("G6", "");

            for (int z = 0; z < amountOfTasks; z++)
            {
                Grid2.Rows.Add();
                for (int n = 0; n < 6; n++) Grid2.Rows[z].Cells[n].Value = Task_list_GridView.Rows[z].Cells[n].Value;
            }  // Копирование информации с основного дата грида во временный.

            Task_list_GridView.Rows.Clear();  // очистка основного датагрида.

            for (int z = 0; z < amountOfTasks; z++)
            {
                Task_list_GridView.Rows.Add();
                for (int n = 0; n < 6; n++) Task_list_GridView.Rows[z].Cells[n].Value = Grid2.Rows[sortedarray[z, 0]].Cells[n].Value;
            }   // запись данных в основной дата грид в требуемом порядке.

            for (int x = 0; x < amountOfTasks; x++)
            {
                if (Task_list_GridView.Rows[x].Cells[5].Value == "  +") Task_list_GridView.Rows[x].Cells[5].Style.BackColor = Color.Red;
            }

            Grid2.Dispose();    // удаление временного датагрида.
        }

        private int Search_for_current_issue(int id)
        {
            for (int x = 0; x < amountOfTasks; x++)
            {
                if (id == Convert.ToInt32(Convert.ToString(Task_list_GridView.Rows[x].Cells[0].Value)))
                {
                    return x;
                }
            }
            return 0;
        }


        private void New_issue_button_Click(object sender, EventArgs e)
        {
            New_issue_Form NewTaskForm = new New_issue_Form();
            
            if (NewTaskForm.ShowDialog(this) == DialogResult.OK)
            {
                ConstructDataForGrid();
                Task_list_GridView.Rows[Search_for_current_issue(_currentIssueId)].Selected = true;
            }
        }

        private void Update_tasks_button_Click(object sender, EventArgs e)
        {
            Task_list_GridView.Rows[Search_for_current_issue(_currentIssueId)].Selected = true;
        }

        private void Search_others_button_Click(object sender, EventArgs e)
        {
            SearchOthersForm NewSearchOthersForm = new SearchOthersForm();
            if (NewSearchOthersForm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenEditWindow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            Edit_issue_Form NewEditTaskForm = new Edit_issue_Form();
            NewEditTaskForm.Fill_data(Convert.ToInt32(Task_list_GridView.Rows[Task_list_GridView.SelectedRows[0].Index].Cells[0].Value));

            if (NewEditTaskForm.ShowDialog(this) == DialogResult.OK)
            {
                ConstructDataForGrid();
                Task_list_GridView.Rows[Search_for_current_issue(_currentIssueId)].Selected = true;
                //if (!WorkingMode_label.Visible) DataLogicObject.Commit_time_to_server_for_one_task(_currentIssueId); // if their is no connection to the server, call a method for saving the task to the journal
                //else { }
                
                // update grid
            }
        }

        private void Commit_button_Click(object sender, EventArgs e)
        {
            
            if (!_is_their_something_not_commited)
            {
                MessageBox.Show("There is nothing to commit", "Commit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Commit_Form NewCommitForm = new Commit_Form();
                NewCommitForm.Fill_data(Convert.ToInt32(Task_list_GridView.Rows[Task_list_GridView.SelectedRows[0].Index].Cells[0].Value));
                CurrentStageTimer.Stop();
                _timerTicking = false;
                Start_timer_button.Text = "Continue";
                if (NewCommitForm.ShowDialog(this) == DialogResult.OK)
                {
                    notifyIcon1.BalloonTipText = "";
                    New_issue_can_be_selected = true;
                    Timer_label.Text = "00:00:00";
                    Start_timer_button.Text = "Start";
                    _ticks = 0;
                    
                    Task_list_GridView.Rows[Search_for_current_issue(_currentIssueId)].Selected = true;

                    if (!WorkingMode_label.Visible)
                    {
                        DataLogicObject.Commit_time_to_server_for_one_task(_currentIssueId);
                        MessageBox.Show("Time was successfully logged to " + Properties.Settings.Default.RedmineServerAddressValue, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        DataLogicObject.commit_time_locally(_currentIssueId);
                        MessageBox.Show("The commit was successfully saved localy.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    ConstructDataForGrid();
                    
                }
            }
        }
        
        private void Settings_button_Click(object sender, EventArgs e)
        {
            Settings_Form newSettingsForm = new Settings_Form();
            if (newSettingsForm.ShowDialog(this) == DialogResult.OK)
            {
                if (!Properties.Settings.Default.AutoDataSavingCheckBoxSetting) AutoSavingTimeTimer.Stop();
                else
                {
                    AutoSavingTimeTimer.Interval = AutoSavingTimeInterval;
                    AutoSavingTimeTimer.Start();
                }

                if (Properties.Settings.Default.AuthenSettChanged) {
                    if (!DataLogicObject.authentificate_on_server())
                    {
                        MessageBox.Show("The new settings were saved. BUT...\r\n \r\n ...The connection to the server has failed. \r\nConsider changing the authentification values", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        WorkingMode_label.Visible = true;
                    }
                    else
                    {
                        WorkingMode_label.Visible = false;
                        DataLogicObject.SetVariables();
                        oldCommits();
                    }
                    Properties.Settings.Default.AuthenSettChanged = false;
                }
            }
        }
        

        private void About_button_Click(object sender, EventArgs e)
        {
            About_Form a = new About_Form();
            a.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
