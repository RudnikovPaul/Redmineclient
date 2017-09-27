using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redmine_Client_2._0
{
    public partial class MainForm : Form
    {        
        private DataStructureClass.DataStructure[] GridContents = new DataStructureClass.DataStructure[0];
        
        private bool CurrentIssueTimerTicking = false;
        private int TimerTicks = 0, NewTicksAfterAutoSave = 0;

        private int CurrentIssueId = 0;
        private int CurrentIssueDataGridRowId = 0;
        private int MouseSelectedRow = 0;
        private string CurrentIssueName = "current issue";
        private int AmountOfIssues = 0;

        private bool NewIssueSelectionAvailability = true;

        Thread SplashThread;


        public MainForm()
        {
            InitializeComponent();
            // start 
            SplashThread = new Thread(SplashScrean);
            SplashThread.Start();

            BuisinessLogicClass.Init();
            Console.SetOut(new StreamWriter(new FileStream(Path.Combine(Environment.ExpandEnvironmentVariables(@"%APPDATA%\RedmineClient20"), "log.txt"), FileMode.Append))); // console output to file
            Console.WriteLine("\r\n\r\n" + DateTime.Now + ": Application starts" + "\r\n");

            CheckForIllegalCrossThreadCalls = false;
            if (BuisinessLogicClass.Connect() == 2)
            {
                Search_others_button.Enabled = true;
                BuisinessLogicClass.Update();
                OldCommits();
            }
            
            ModifyGridViewData();

            notifyIcon.Text = "Redmine Client";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = "REDMINE CLIENT";
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            CurrentIssueTimer.Interval = 1000;
            AutoSaveTimer.Interval = 30000;

            Issue_list_GridView.EnableHeadersVisualStyles = false;
        }

        private void SplashScrean()
        {
            SplashForm EditWindow = new SplashForm();
            EditWindow.ShowDialog();
        }

        private void OldCommits()
        {
            if (BuisinessLogicClass.CheckForOldCommits())
            {
                DialogResult result = MessageBox.Show("Local commits left\r\nYES - send 'em to server\r\nNO - delete 'em\r\nCANCEL - work offline", "Local time commits", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    BuisinessLogicClass.OldCommits(true);
                    MessageBox.Show("The commits where succesfully logged to " + Properties.Settings.Default.RedmineAddress, "Local time commits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (result == DialogResult.No)
                {
                    BuisinessLogicClass.OldCommits(false);
                    MessageBox.Show("The commits where deleted.", "Local time commits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (result == DialogResult.Cancel) Properties.Settings.Default.Connection = false;
            }
        }


        private void ModifyGridViewData()
        {
            SetIssueList();
            SplashThread.Abort();
        }

        private void SetIssueList()
        {            
            GridContents = BuisinessLogicClass.GetAllIssues();
            AmountOfIssues = GridContents.Length;
            Issue_list_GridView.Rows.Clear();
            DataStructureClass.DataStructure GridLine = new DataStructureClass.DataStructure();
            for (int x = 0; x < AmountOfIssues; x++)  //adding rows into GridView
            {
                GridLine = GridContents[x];
                string startDate = "";
                string dueDate = "";
                if (GridLine._startDateCh) startDate = BuisinessLogicClass.ConvertDate(GridLine._startDate);
                if (GridLine._dueDateCh) dueDate = BuisinessLogicClass.ConvertDate(GridLine._dueDate);

                string donePercent = Convert.ToString(GridLine._percentDone + "%");

                Issue_list_GridView.Rows.Add(GridLine._id, GridLine._subjectName, startDate, dueDate, donePercent);

                if (GridLine._description != null) Issue_list_GridView.Rows[x].Cells[1].ToolTipText = GridLine._subjectName + "\r\n" + BuisinessLogicClass.NormalizeText(GridLine._description, 120);
                Issue_list_GridView.Rows[x].Cells[0].ToolTipText = "double click opens the edit window.";
            }
            try { Issue_list_GridView.Rows[0].Cells[0].Selected = true; } catch { }
            Selection_changed();
        }


        private void MainFormResize(object sender, EventArgs e)
        {
            Hide();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
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
            if (NewIssueSelectionAvailability)
            {
                CurrentIssueId = Convert.ToInt32(Convert.ToString(Issue_list_GridView
                    .Rows[Issue_list_GridView.SelectedRows[0].Index].Cells[0].Value));
                BuisinessLogicClass.SuperIssueId = CurrentIssueId;
                CurrentIssueName = Convert.ToString(Issue_list_GridView
                        .Rows[Issue_list_GridView.SelectedRows[0].Index].Cells[1].Value);
                if (CurrentIssueName.Length > 50) Text = "RC: " + CurrentIssueName.Substring(0, 50);
                else Text = "RC: " + CurrentIssueName;

                Issue_list_GridView.BackgroundColor = Color.WhiteSmoke;
                for (int i = 0; i < 5; i++) Issue_list_GridView.Rows[CurrentIssueDataGridRowId].Cells[i].Style.BackColor = Color.DarkGray;
            }

            if (Start_timer_button.Text == "Start") NewIssueSelectionAvailability = true;
            if (CurrentIssueTimerTicking)
            {
                CurrentIssueTimer.Stop();
                CurrentIssueTimerTicking = false;
                AutoSaveTimer.Stop();
                Start_timer_button.Text = "Continue";
            }
            else
            {
                CurrentIssueTimer.Start();
                CurrentIssueTimerTicking = true;
                AutoSaveTimer.Start();
                Start_timer_button.Text = "Pause";
                Commit_button.Enabled = true;
                NewIssueSelectionAvailability = false;
            }
        }

        private void Current_stage_timer_tick(object sender, EventArgs e)
        {
            TimerTicks++;
            NewTicksAfterAutoSave++;
            UpdateTimerLabel();

            string Textforicon = "Time on " + CurrentIssueName + ":\n" + Timer_label.Text;
            if (Textforicon.Length > 63) notifyIcon.Text = "Time on " + CurrentIssueName.Substring(0, 43) + ":\n" + Timer_label.Text;
            else notifyIcon.Text = Textforicon;
        }

        private void UpdateTimerLabel()
        {
            string hours;
            string minutes;
            string seconds;

            int hours_ = (TimerTicks / 3600 % 60);
            int minutes_ = (TimerTicks / 60 % 60);
            int seconds_ = (TimerTicks % 60);
            if (seconds_ < 10) seconds = "0" + seconds_;
            else seconds = (TimerTicks % 60).ToString();
            if (minutes_ < 10) minutes = "0" + minutes_;
            else minutes = (TimerTicks / 60 % 60).ToString();
            if (hours_ < 10) hours = "0" + hours_;
            else hours = (TimerTicks / 3600 % 60).ToString();

            Timer_label.Text = hours + ":" + minutes + ":" + seconds;
        }

        private void AutoSaveTimerTick(object sender, EventArgs e)
        {
            SaveTimeTicked(NewTicksAfterAutoSave);
            NewTicksAfterAutoSave = 0;
        }

        private void SaveTimeTicked(int time)
        {
            BuisinessLogicClass.SaveTimeTicked(CurrentIssueId, time);
        }

        private void Issue_list_double_click(object sender, DataGridViewCellEventArgs e)
        {
            BuisinessLogicClass.EditIssueId = Convert.ToInt32(Issue_list_GridView.SelectedRows[0].Cells[0].Value);
            EditIssueForm EditWindow = new EditIssueForm();
            if (EditWindow.ShowDialog() == DialogResult.OK) ModifyGridViewData();
        }

        private void Issue_list_selection_changed(object sender, EventArgs e)
        {
            Selection_changed();
        }

        private void Selection_changed()
        {
            try { 
                Start_timer_button.Enabled = true;
                if (NewIssueSelectionAvailability)
                {
                    CurrentIssueName = Convert.ToString(Issue_list_GridView.SelectedRows[0].Cells[1].Value);
                    CurrentIssueId = Convert.ToInt32(Issue_list_GridView.SelectedRows[0].Cells[0].Value);
                    BuisinessLogicClass.SuperIssueId = CurrentIssueId;
                    CurrentIssueDataGridRowId = Issue_list_GridView.SelectedRows[0].Index;
                    DataStructureClass.DataStructure data = BuisinessLogicClass.GetOneIssue(CurrentIssueId);
                    TimerTicks = data._notCommittedWorkingTime;
                    UpdateTimerLabel();
                }
                for (int i = 0; i < 5; i++) Issue_list_GridView.Rows[MouseSelectedRow].Cells[i].Style.BackColor = Color.WhiteSmoke;
                MouseSelectedRow = Issue_list_GridView.SelectedRows[0].Index;
                Issue_list_GridView.BackgroundColor = Color.WhiteSmoke;
                for (int i = 0; i < 5; i++) Issue_list_GridView.Rows[CurrentIssueDataGridRowId].Cells[i].Style.BackColor = Color.DarkGray;
            }
            catch { }
        }


        private void Sorting_items_GridView_Clicked(object sender, EventArgs e)
        {
            if (Issue_list_GridView.SortedColumn.Name == "GridStart") Sort_GridView_items(2);
            if (Issue_list_GridView.SortedColumn.Name == "GridDue") Sort_GridView_items(3);
        }

        private void Sort_GridView_items(int columnId)
        {
            int[,] NotSortedArray = new int[AmountOfIssues, 2];
            int[,] SortedArray = new int[AmountOfIssues, 2];

            for (int x = 0; x < AmountOfIssues; x++) 
            {
                if (Convert.ToString(Issue_list_GridView.Rows[x].Cells[columnId].Value).Length == 8)
                {
                    string date = Convert.ToString(Issue_list_GridView.Rows[x].Cells[columnId].Value);
                    NotSortedArray[x, 1] = Convert.ToInt32(date.Substring(6, 2) + date.Substring(3, 2) + date.Substring(0, 2));
                }
                else NotSortedArray[x, 1] = 800000 + x;
                NotSortedArray[x, 0] = x;
            }   // copying id and dates (converted to int) into array

            int OldestDate = 888888;
            int LineId = 0;
            for (int x = 0; x < AmountOfIssues; x++)
            {
                for (int y = 0; y < AmountOfIssues; y++)
                {
                    if (NotSortedArray[y, 1] < OldestDate)
                    {
                        OldestDate = NotSortedArray[y, 1];
                        LineId = y;
                    }
                }
                SortedArray[x, 1] = NotSortedArray[LineId, 1];  // a line is added to new array
                SortedArray[x, 0] = NotSortedArray[LineId, 0];
                OldestDate = 888888;
                NotSortedArray[LineId, 1] = 999999;  // date value is made maximum
            }  // sorting old array saving sorted values in sorted array.

            DataGridView Grid2 = new DataGridView();  // creating new data grid where not sorted data will be copyed
            Grid2.Columns.Add("G1", "");
            Grid2.Columns.Add("G2", "");
            Grid2.Columns.Add("G3", "");
            Grid2.Columns.Add("G4", "");
            Grid2.Columns.Add("G5", "");
            Grid2.Columns.Add("G6", "");

            for (int z = 0; z < AmountOfIssues; z++)
            {
                Grid2.Rows.Add();
                for (int n = 0; n < 5; n++) Grid2.Rows[z].Cells[n].Value = Issue_list_GridView.Rows[z].Cells[n].Value;
            }  // Копирование информации с основного дата грида во временный. copying datagrid1 into datagrid2

            Issue_list_GridView.Rows.Clear();  // clearing datagrid1

            for (int z = 0; z < AmountOfIssues; z++)
            {
                Issue_list_GridView.Rows.Add();
                for (int n = 0; n < 5; n++) Issue_list_GridView.Rows[z].Cells[n].Value = Grid2.Rows[SortedArray[z, 0]].Cells[n].Value;
            }   // copying data to datagrid1 from datagrid2 according to array of sorted dates.

            Grid2.Dispose();    // удаление временного датагрида.
        }


        private void Commit_button_Click(object sender, EventArgs e)
        {
            CurrentIssueTimer.Stop();
            CurrentIssueTimerTicking = false;
            AutoSaveTimer.Stop();
            SaveTimeTicked(NewTicksAfterAutoSave);

            if (NewIssueSelectionAvailability) BuisinessLogicClass.SuperIssueId = Convert.ToInt32(Issue_list_GridView.SelectedRows[0].Cells[0].Value);
            else BuisinessLogicClass.SuperIssueId = CurrentIssueId;

            CommitForm CommitWindow = new CommitForm();
            if (CommitWindow.ShowDialog() == DialogResult.OK)
            {
                Timer_label.Text = "00:00:00";
                Start_timer_button.Text = "Start";
                NewTicksAfterAutoSave = 0;
                TimerTicks = 0;
                NewIssueSelectionAvailability = true;
                Commit_button.Enabled = false;
                ModifyGridViewData();
            }
            else
            {
                CurrentIssueTimer.Start();
                CurrentIssueTimerTicking = true;
                AutoSaveTimer.Start();
            }
        }

        private void New_issue_button_Click(object sender, EventArgs e)
        {
            int issue = BuisinessLogicClass.EditIssueId;
            BuisinessLogicClass.EditIssueId = -1234;
            EditIssueForm EditWindow = new EditIssueForm();
            if (EditWindow.ShowDialog() == DialogResult.OK) ModifyGridViewData();
            else BuisinessLogicClass.EditIssueId = issue;
        }
        

        private void Settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsForm = new SettingsForm();
            DialogResult SettingsDialogResult = new DialogResult();
            SettingsDialogResult = SettingsForm.ShowDialog(this);

            if (SettingsDialogResult == DialogResult.OK) // ok - other settings where changed.
            {
                if (Properties.Settings.Default.AutoSaving) AutoSaveTimer.Start();
                else AutoSaveTimer.Stop();
            }
            if (SettingsDialogResult == DialogResult.Yes) // yes - authentification values where changed.
            {
                // reconnect to server.
                if (BuisinessLogicClass.Connect() == 2)
                {
                    Properties.Settings.Default.Connection = true;
                    OldCommits();
                    BuisinessLogicClass.Update();
                    Search_others_button.Enabled = true;
                }
            }
        }

        private void Search_others_button_Click(object sender, EventArgs e)
        {
            SearchForm SearchWindow = new SearchForm(); // add found issue to issue file.
            if (SearchWindow.ShowDialog() == DialogResult.OK) ModifyGridViewData();
        }

        private void AboutForm_click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {            
            ExitApplication();
        }

        private void ExitAppClick(object sender, EventArgs e)
        {
            ExitApplication();
            Close();
        }
        
        private void ExitApplication ()
        {
            CurrentIssueTimer.Stop();
            CurrentIssueTimerTicking = false;
            AutoSaveTimer.Stop();
            SaveTimeTicked(NewTicksAfterAutoSave);
            BuisinessLogicClass.CleanUpIssuesFile(); // move all time to comments and empty time in main file.
            notifyIcon.Visible = false;
        }
    }
}
