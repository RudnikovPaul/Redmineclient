using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Redmine.Net.Api.Types;
using Redmine.Net.Api;
using System.Net;

namespace Redmine_Client_2._0
{
    static class ServerClass
    {
        public static int linesAmount, lastFileId = 0;

        //public static string folderPath = Environment.ExpandEnvironmentVariables(@"RedmineClient20");
        public static string folderPath = Environment.ExpandEnvironmentVariables(@"%APPDATA%\RedmineClient20");
        private static string CurrentModificationPath = Path.Combine(folderPath, "issues.json");
        private static string VariablesPath = Path.Combine(folderPath, "variables.json");
        private static string CommitPath = Path.Combine(folderPath, "commits.json");
        private static bool Connected_to_server = false;

        internal static RedmineManager redmine;
        private static User CurrentUser = new User();
        static NameValueCollection parameters = new NameValueCollection();
        static NameValueCollection parameters2 = new NameValueCollection();
        static NameValueCollection parameters3 = new NameValueCollection();
        static Issue Issues = new Issue();
        static Issue IssueAdd = new Issue();
        static Issue IssueUpdate = new Issue();
        static Issue IssueCreate = new Issue();

        public static bool CheckAvailability()
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.CheckAvailability");
            WebRequest webRequest = WebRequest.Create(Properties.Settings.Default.RedmineAddress);
            webRequest.Method = "HEAD";
            try
            {
                using (WebResponse webResponse = webRequest.GetResponse()) { }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Authentificate()
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.Authentificate");
            try
            {
                if (Properties.Settings.Default.LoginType) redmine = new RedmineManager(Properties.Settings.Default.RedmineAddress, Properties.Settings.Default.UserName, Properties.Settings.Default.Password, MimeFormat.Json);
                else redmine = new RedmineManager(Properties.Settings.Default.RedmineAddress, Properties.Settings.Default.ApiKey, MimeFormat.Json);
                CurrentUser = redmine.GetCurrentUser();
                Connected_to_server = true;
                return true;
            }
            catch (Exception)
            {
                Connected_to_server = false;
                return false;
            }
        }

        public static void UpdateVariables()
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.UpdateVariables");
            /*try
            {*/

            IList<Project> allProjects = redmine.GetObjects<Project>();
            List<Tracker> allTrackers = redmine.GetObjects<Tracker>();
            List<IssueStatus> allStatuses = redmine.GetObjects<IssueStatus>();
            List<IssuePriority> allPrioritys = redmine.GetObjects<IssuePriority>();
            List<TimeEntryActivity> allActivities = redmine.GetObjects<TimeEntryActivity>();
            

            File.Delete(VariablesPath);
            FileInfo fl = new FileInfo(VariablesPath);
            StreamWriter sw = fl.AppendText();


            int count = allProjects.Count;
            string[,] projects = new string[count, 2];
            for (int r = 0; r < count; r++) {projects[count - 1 - r, 0] = allProjects[r].Name; projects[count - 1 - r, 1] = Convert.ToString(allProjects[r].Id); }
            sw.WriteLine(JsonConvert.SerializeObject(projects));

            count = allTrackers.Count;
            string[,] Trackers = new string[count, 2];
            for (int r = 0; r < count; r++) { Trackers[count - 1 - r, 0] = allTrackers[r].Name; Trackers[count - 1 - r, 1] = Convert.ToString(allTrackers[r].Id); }
            sw.WriteLine(JsonConvert.SerializeObject(Trackers));

            count = allStatuses.Count;
            string[,] Statuses = new string[count,2];
            for (int r = 0; r < count; r++) { Statuses[r,0] = allStatuses[r].Name; Statuses[r, 1] = Convert.ToString(allStatuses[r].Id); }
            sw.WriteLine(JsonConvert.SerializeObject(Statuses));

            count = allPrioritys.Count;
            string[,] Prioritys = new string[count, 2];
            for (int r = 0; r < count; r++) { Prioritys[r, 0] = allPrioritys[r].Name; Prioritys[r, 1] = Convert.ToString(allPrioritys[r].Id); }
            sw.WriteLine(JsonConvert.SerializeObject(Prioritys));

            count = allActivities.Count;
            string[,] Activities = new string[count, 2];
            for (int r = 0; r < count; r++) { Activities[r, 0] = Convert.ToString(allActivities[r].Name); Activities[r, 1] = Convert.ToString(allActivities[r].Id); }
            sw.WriteLine(JsonConvert.SerializeObject(Activities));

            string[,] user = new string[1, 2] { { CurrentUser.Login, Convert.ToString(CurrentUser.Id) } };
            try
            {
                List<User> allUsers = redmine.GetObjects<User>();
                count = allUsers.Count;
                string[,] Users = new string[count, 2];
                for (int r = 0; r < count; r++) { Users[r, 0] = Convert.ToString(allUsers[r].Id); Users[r, 1] = Convert.ToString(allUsers[r].Id); }
                sw.WriteLine(JsonConvert.SerializeObject(Users));
            }
            catch { sw.WriteLine(JsonConvert.SerializeObject(user)); }

            sw.Close();
            /*}
            catch { }*/
        }

        public static void GetAllIssues()
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.GetAllIssues");
            parameters.Clear();
            //parameters.Add(RedmineKeys.ASSIGNED_TO_ID, "me");
            parameters.Add(RedmineKeys.PROJECT_ID, "79");  // 79 - forpay
            IList<Issue> Issues = redmine.GetObjects<Issue>(parameters);
            
            DataStructureClass.DataStructure newDataStructure = new DataStructureClass.DataStructure();

            File.Delete(CurrentModificationPath);
            FileInfo fl = new FileInfo(CurrentModificationPath);
            StreamWriter sw = fl.AppendText();

            for (int x = 0; x < Issues.Count; x++)
            {
                newDataStructure._projectName = Issues[x].Project.Name;
                newDataStructure._projectId = Issues[x].Project.Id;
                
                newDataStructure._subjectName = Issues[x].Subject;
                newDataStructure._id = Issues[x].Id;

                try { newDataStructure._percentDone = Convert.ToInt32(Issues[x].DoneRatio); }
                catch { newDataStructure._percentDone = 0; }
                newDataStructure._priority = Convert.ToString(Issues[x].Priority.Name);
                try { newDataStructure._assignedTo = Convert.ToString(Issues[x].AssignedTo.Name); newDataStructure._assignedToId = Issues[x].AssignedTo.Id; }
                catch { newDataStructure._assignedTo = ""; newDataStructure._assignedToId = 0; }
                newDataStructure._status = Issues[x].Status.Name;
                newDataStructure._statusId = Issues[x].Status.Id;
                newDataStructure._tracker = Issues[x].Tracker.Name;
                newDataStructure._trackerId = Issues[x].Tracker.Id;
                newDataStructure._description = Issues[x].Description;
                newDataStructure._notes = Issues[x].Notes;
                try { newDataStructure._estimHours = Issues[x].EstimatedHours; }
                catch { newDataStructure._estimHours = 0; }

                newDataStructure._startDate = Convert.ToDateTime(Issues[x].StartDate);
                newDataStructure._dueDate = Convert.ToDateTime(Issues[x].DueDate);
                newDataStructure._startDateCh = false;
                newDataStructure._dueDateCh = false;
                if (Convert.ToInt32(Convert.ToString(newDataStructure._startDate).Substring(6, 4)) > 2000) newDataStructure._startDateCh = true;
                if (Convert.ToInt32(Convert.ToString(newDataStructure._dueDate).Substring(6, 4)) > 2000) newDataStructure._dueDateCh = true;

                sw.WriteLine(JsonConvert.SerializeObject(newDataStructure));
            }            
            sw.Close();
        }

        public static DataStructureClass.DataStructure GetOneIssue(int IssueId)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.GetOneIssue: " + IssueId);
            DataStructureClass.DataStructure oneIssue = new DataStructureClass.DataStructure();

            return oneIssue;
        }

        public static void CommitTime(int Id, string CommentText, int Activity, DateTime SpentOn, DataStructureClass.DataStructure IssueData)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.CommitTime");
            TimeEntry entry = new TimeEntry()
            {
                Comments = CommentText,
                Activity = new IdentifiableName { Id = Activity },
                Hours = (decimal)IssueData._notCommittedWorkingTime / 3600,
                SpentOn = SpentOn,
                Issue = new IdentifiableName { Id = IssueData._id },
                Project = new IdentifiableName { Id = IssueData._projectId },
                User = new IdentifiableName { Id = IssueData._assignedToId }
            };
            redmine.CreateObject(entry);
        }

        public static void EditIssue(DataStructureClass.DataStructure EditedData)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.EditIssue");
            IssueUpdate.Project = new IdentifiableName { Id = EditedData._projectId };
            IssueUpdate.Subject = EditedData._subjectName;
            IssueUpdate.DoneRatio = EditedData._percentDone;
            IssueUpdate.Priority = new IdentifiableName { Id = EditedData._priorityId };
            IssueUpdate.AssignedTo = new IdentifiableName { Id = EditedData._assignedToId };
            IssueUpdate.Description = EditedData._description;
            IssueUpdate.Status = new IdentifiableName { Id = EditedData._statusId };
            IssueUpdate.Tracker = new IdentifiableName { Id = EditedData._trackerId };
            if (EditedData._startDateCh) IssueUpdate.StartDate = EditedData._startDate;
            if (EditedData._dueDateCh) IssueUpdate.DueDate = EditedData._dueDate;
            IssueUpdate.EstimatedHours = EditedData._estimHours;

            redmine.UpdateObject(Convert.ToString(EditedData._id), IssueUpdate);
        }

        public static void CreateIssue(DataStructureClass.DataStructure NewData)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.CreateIssue");
            IssueCreate.Project = new IdentifiableName { Id = NewData._projectId };            
            IssueCreate.Subject = NewData._subjectName;
            IssueCreate.DoneRatio = NewData._percentDone;
            IssueCreate.Priority = new IdentifiableName { Id = NewData._priorityId };
            IssueCreate.AssignedTo = new IdentifiableName { Id = NewData._assignedToId };
            IssueCreate.Description = NewData._description;
            IssueCreate.Status = new IdentifiableName { Id = NewData._statusId };
            IssueCreate.Tracker = new IdentifiableName { Id = NewData._trackerId };
            if (NewData._startDateCh) IssueCreate.StartDate = NewData._startDate;
            if (NewData._dueDateCh) IssueCreate.DueDate = NewData._dueDate;
            IssueCreate.EstimatedHours = NewData._estimHours;

            // Does the issue ID need to be created
            //IssueCreate.Id = NewData._id;

            redmine.CreateObject(IssueCreate);
        }

        public static void DeleteIssue(int IssueId)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.DeleteIssue");
        }

        public static string FindIssue(int IssueId)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.FindIssue: " + IssueId);
            try
            {
                Issues = redmine.GetObject<Issue>(Convert.ToString(IssueId), parameters2);
                return Issues.Subject;
            }
            catch { return ""; }
        }

        public static void AddIssue(int IssueId)
        {
            Console.WriteLine(DateTime.Now + ": ServerClass.AddIssue");
            try
             {
                string[] readText = File.ReadAllLines(CurrentModificationPath);
                for (int x = 0; x < readText.Length; x++) if (JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(readText[x])._id == IssueId) { MessageBox.Show("Issue is already in the list!"); return; }

                IssueAdd = redmine.GetObject<Issue>(Convert.ToString(IssueId), parameters3);
                DataStructureClass.DataStructure newDataStructure = new DataStructureClass.DataStructure();
                FileInfo fl = new FileInfo(CurrentModificationPath);
                StreamWriter sw = fl.AppendText();

                newDataStructure._projectName = Convert.ToString(IssueAdd.Project.Name);

                newDataStructure._projectId = Convert.ToInt32(IssueAdd.Project.Id);
                newDataStructure._id = Convert.ToInt32(IssueAdd.Id);
                newDataStructure._subjectName = Convert.ToString(IssueAdd.Subject);

                try { newDataStructure._percentDone = Convert.ToInt32(IssueAdd.DoneRatio); }
                catch { newDataStructure._percentDone = 0; }
                newDataStructure._priority = Convert.ToString(IssueAdd.Priority.Name);
                try { newDataStructure._assignedTo = Convert.ToString(IssueAdd.AssignedTo.Name); newDataStructure._assignedToId = IssueAdd.AssignedTo.Id; }
                catch { newDataStructure._assignedTo = ""; newDataStructure._assignedToId = 0; }
                newDataStructure._status = Convert.ToString(IssueAdd.Status.Name);
                newDataStructure._trackerId = IssueAdd.Tracker.Id;
                newDataStructure._description = Convert.ToString(IssueAdd.Description);
                newDataStructure._notes = Convert.ToString(IssueAdd.Notes);
                try { newDataStructure._estimHours = Convert.ToInt32(IssueAdd.EstimatedHours); }
                catch { newDataStructure._estimHours = 0; }

                newDataStructure._startDate = Convert.ToDateTime(IssueAdd.StartDate);
                newDataStructure._dueDate = Convert.ToDateTime(IssueAdd.DueDate);
                newDataStructure._startDateCh = false;
                newDataStructure._dueDateCh = false;
                if (Convert.ToInt32(Convert.ToString(newDataStructure._startDate).Substring(6, 4)) > 2000) newDataStructure._startDateCh = true;
                if (Convert.ToInt32(Convert.ToString(newDataStructure._dueDate).Substring(6, 4)) > 2000) newDataStructure._dueDateCh = true;

                sw.WriteLine(JsonConvert.SerializeObject(newDataStructure));
                sw.Close();
            }
            catch {}
        }
    }
}
