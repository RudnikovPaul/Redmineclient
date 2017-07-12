using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Redmine.Net.Api.Types;
using Redmine.Net.Api;
using System.Net;

namespace RedmineClient
{
    class DataLogic_Class
    {
        // задачи:
        // 1. Получить все таски для одного человека.
        // 2. Получить один таск для помощи кому-то.
        // 3. Отправить коммит на один таск на сервер.

        // 1. добавить все таски в таблицу. foreach()
        // 2. считывать по одному таску для: добавления всех в таблицу; добавление одного чужого таска. чужие таски удаляются после коммита.
        // 3. записать в файл изменения таска.

        public int linesAmount;
        private int lastFileId = 0;
        private string current_modification_file_path = Directory.GetCurrentDirectory() + "/last_issues_edition.json";
        private string task_variables_file_path = Directory.GetCurrentDirectory() + "/task_variables_file_path.json";
        private string local_commit_storage_path = Directory.GetCurrentDirectory() + "/local_commit_storage_path.json";
        private bool Connected_to_server = false;

        internal static RedmineManager redmine;
        User newCurrentUser = new User();


        NameValueCollection parameters = new NameValueCollection();

        List<User> allUsers = new List<User>();
        List<Tracker> allTrackers = new List<Tracker>();
        List<IssueStatus> allStatuses = new List<IssueStatus>();
        List<IssuePriority> allPrioritys = new List<IssuePriority>();
        List<TimeEntryActivity> allActivities = new List<TimeEntryActivity>();

        public void Init()
        {
            if (!File.Exists(current_modification_file_path))
            {
                FileInfo fl = new FileInfo(current_modification_file_path);
                StreamWriter sw = fl.AppendText();
                sw.WriteLine("0");
                sw.Close();
            }
        }

        public void commit_time_locally(int id)
        {
            FileInfo fl = new FileInfo(local_commit_storage_path);
            StreamWriter sw = fl.AppendText();
            sw.WriteLine(JsonConvert.SerializeObject(createTimeEntry(id, true)));
            sw.Close();
        }

        public bool is_their_any_not_committed_commits()
        {
            try { if (File.ReadAllLines(local_commit_storage_path).Length > 0) return true; else return false; }
            catch { return false; }
        }

        public int[] search_for_commits_for_one_task(int id)
        {
            int commentsamount = 0;
            linesAmount = File.ReadAllLines(local_commit_storage_path).Length;
            string[] readText = File.ReadAllLines(local_commit_storage_path);

            for (int x = 0; x < readText.Length; x++)   // finding amount of comments for particular task.
            {
                TimeEntry fileline = JsonConvert.DeserializeObject<TimeEntry>(readText[x]);
                if (fileline.Issue.Id == id) commentsamount++;
            }

            int[] tasklinenumbers = new int[commentsamount];

            int counter = 0;
            for (int x = 0; x < readText.Length; x++)   // finding all line ids for particular task.
            {
                TimeEntry fileline = JsonConvert.DeserializeObject<TimeEntry>(readText[x]);
                if (fileline.Issue.Id == id)
                {
                    tasklinenumbers[counter] = x;
                    counter++;
                }
            }
            return tasklinenumbers;
        }

        public void send_all_commits_to_server()
        {
            linesAmount = File.ReadAllLines(local_commit_storage_path).Length;
            string[] readText = File.ReadAllLines(local_commit_storage_path);
            bool check = true;
            int counter = 0;
            int[] differenttasks = new int[linesAmount];
            for (int i = 0; i < linesAmount; i++)
            {
                for (int l = 0; l < linesAmount; l++) if (JsonConvert.DeserializeObject<TimeEntry>(readText[i]).Issue.Id == differenttasks[l]) check = false;
                if (check == true)
                {
                    differenttasks[counter] = JsonConvert.DeserializeObject<TimeEntry>(readText[i]).Issue.Id;
                    counter++;
                }
                check = true;
            }
            
            for (int i = 0; i < linesAmount; i++)
            {
                try
                {
                    if (differenttasks[i] == 0) break;
                    Commit_time_to_server_for_all_commits_inside_a_task(differenttasks[i]);
                }
                catch { }
            }
        }

        public void Commit_time_to_server_for_all_commits_inside_a_task(int id)
        {
            string[] readText = File.ReadAllLines(local_commit_storage_path);


            int[] i = search_for_commits_for_one_task(id);   // search for commits.
            for (int x = 0; x < i.Length; x++)      // sending all commits to server.
            {
                TimeEntry taskline = JsonConvert.DeserializeObject<TimeEntry>(readText[i[x]]);
                try
                {
                    redmine.CreateObject(taskline);
                }
                catch {
                    MessageBox.Show("error");
                }
            }

            DataStructure data = Get_one_issue(id);
            data._currentussagetime = 0;
            data._commit = false;
            Write_new_issue_information(data);



            string[] newlines = new string[readText.Length - i.Length];
            int idof = 0;
            for (int x = 0; x < readText.Length; x++)
            {
                TimeEntry fileline = JsonConvert.DeserializeObject<TimeEntry>(readText[x]);
                if (fileline.Issue.Id != id)
                {
                    newlines[idof] = readText[x];
                    idof++;
                }
            }
            File.Delete(local_commit_storage_path);
            File.AppendAllLines(local_commit_storage_path, newlines);
        }

        public void Commit_time_to_server_for_one_task(int id)   // one piece TO server. задача 3.
        {
            redmine.CreateObject(createTimeEntry(id, false));
        }

        public void delete_local_commit_file()
        {
            File.Delete(local_commit_storage_path);
        }


        private TimeEntry createTimeEntry(int id, bool type)
        {
            DataStructure data = Get_one_issue(id);
            TimeEntry entry = new TimeEntry();
            entry.Comments = data._comment;
            entry.Activity = new IdentifiableName { Id = data._activity };
            entry.Hours = (decimal)data._currentussagetime / 3600;
            entry.SpentOn = DateTime.Now;
            entry.Issue = new IdentifiableName { Id = data._numberid };
            entry.Project = new IdentifiableName { Id = data._projectid };
            entry.User = new IdentifiableName { Id = data._assignedtoid };

            data._currentussagetime = 0;
            data._commit = type;
            Write_new_issue_information(data);

            return entry;
        }

        public void Update_one_task_on_server(int id)
        {
            //redmine.UpdateObject(Convert.ToString(data._commentid), entry);
        }

        

        public bool Connect_to_server()
        {
            WebRequest webRequest = WebRequest.Create(Properties.Settings.Default.RedmineServerAddressValue);
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

        public bool authentificate_on_server()
        {
            
            try
            {
                if (Properties.Settings.Default.LoginPassRadiobuttonChecked) redmine = new RedmineManager(Properties.Settings.Default.RedmineServerAddressValue, Properties.Settings.Default.UserNameValue, Properties.Settings.Default.PasswordValue, MimeFormat.Json);
                else if (Properties.Settings.Default.ApiKeyRadioButtonChecked) redmine = new RedmineManager(Properties.Settings.Default.RedmineServerAddressValue, Properties.Settings.Default.ApiKey, MimeFormat.Json);
                else redmine = new RedmineManager(Properties.Settings.Default.RedmineServerAddressValue, MimeFormat.Json);
                newCurrentUser = redmine.GetCurrentUser();
                
                Connected_to_server = true;
                return Connected_to_server;
                
              
            }
            catch (Exception)
            {
                Connected_to_server = false;
                return Connected_to_server;
            }
        }


        public void SetVariables ()
        {
            try
            {
            IList<Project> allProjects = redmine.GetObjects<Project>(parameters);
                //allUsers = redmine.GetObjects<User>();  // сервер: запрещено
                allTrackers = redmine.GetObjects<Tracker>();
                allStatuses = redmine.GetObjects<IssueStatus>();
                allPrioritys = redmine.GetObjects<IssuePriority>();
                allActivities = redmine.GetObjects<TimeEntryActivity>();

                File.Delete(task_variables_file_path);
                FileInfo fl = new FileInfo(task_variables_file_path);
                StreamWriter sw = fl.AppendText();

                int count = allProjects.Count;
                string[] projects = new string[count];
                for (int r = 0; r < count; r++) projects[count - 1 - r] = allProjects[r].Name;
                sw.WriteLine(JsonConvert.SerializeObject(projects));

                count = allTrackers.Count;
                string[] Trackers = new string[count];
                for (int r = 0; r < count; r++) Trackers[count - 1 - r] = allTrackers[r].Name;
                sw.WriteLine(JsonConvert.SerializeObject(Trackers));

                count = allStatuses.Count;
                string[] Statuses = new string[count];
                for (int r = 0; r < count; r++) Statuses[r] = allStatuses[r].Name;
                sw.WriteLine(JsonConvert.SerializeObject(Statuses));

                count = allPrioritys.Count;
                string[] Prioritys = new string[count];
                for (int r = 0; r < count; r++) { Prioritys[r] = allPrioritys[r].Name; }
                sw.WriteLine(JsonConvert.SerializeObject(Prioritys));

                
                count = allUsers.Count;
                string[] Users = new string[count + 1];
                Users[0] = "";
                for (int r = 0; r < count; r++) Users[count - 1 - r + 1] = allUsers[r].FirstName + " " + allUsers[r].LastName;
                sw.WriteLine(JsonConvert.SerializeObject(Users));

                count = allActivities.Count;
                string[] Activities = new string[count];
                int[] Activitiesid = new int[count];
                for (int r = 0; r < count; r++) { Activities[r] = Convert.ToString(allActivities[r].Name); Activitiesid[r] = allActivities[r].Id; }
                sw.WriteLine(JsonConvert.SerializeObject(Activities));
                sw.WriteLine(JsonConvert.SerializeObject(Activitiesid));

                sw.Close();
            }
            catch { }
            
            //List<ProjectMembership> projectMembers = redmine.GetObjects<ProjectMembership>(InitParameters());
            //List<IssueCategory> allCategorys = redmine.GetObjects<IssueCategory>(InitParameters());
            //List<TimeEntryActivity> allTimeEntryActivitys = redmine.GetObjects<TimeEntryActivity>();
            //List<CustomField> allCustomFields = redmine.GetObjects<CustomField>();
        }

        public string[] GetVariables(int lineId)
        {
            string[] ListVar;
            string[] readText = File.ReadAllLines(task_variables_file_path);
            ListVar = JsonConvert.DeserializeObject<string[]>(readText[lineId]);
            return ListVar;
        }

        public void SetParameters()
        {
            parameters.Add(RedmineKeys.ASSIGNED_TO_ID, "me");
            //MessageBox.Show("setting");
        }

        public void GetIssueData()
        {
            IList<Issue> Issues = redmine.GetObjects<Issue>(parameters);  // ask for tasks only for me.
            DataStructure newDataStructure = new DataStructure();
            
            File.Delete(current_modification_file_path);
            FileInfo fl = new FileInfo(current_modification_file_path);
            StreamWriter sw = fl.AppendText();
            
            for (int x = 0; x < Issues.Count; x++)
            {
                
                newDataStructure._project = Convert.ToString(Issues[x].Project.Name);
                
                newDataStructure._projectid = Convert.ToInt32(Issues[x].Project.Id);
                newDataStructure._numberid = Convert.ToInt32(Issues[x].Id);
                newDataStructure._subject = Convert.ToString(Issues[x].Subject); 

                try { newDataStructure._done = Convert.ToInt32(Issues[x].DoneRatio); }
                catch { newDataStructure._done = 0; }
                newDataStructure._priority = Convert.ToString(Issues[x].Priority.Name);
                try { newDataStructure._assignedto = Convert.ToString(Issues[x].AssignedTo.Name); newDataStructure._assignedtoid = Issues[x].AssignedTo.Id; }
                catch { newDataStructure._assignedto = ""; newDataStructure._assignedtoid = 0; }
                newDataStructure._status = Convert.ToString(Issues[x].Status.Name);
                newDataStructure._trackerid = Convert.ToString(Issues[x].Tracker.Name);
                newDataStructure._description = Convert.ToString(Issues[x].Description);
                newDataStructure._notes = Convert.ToString(Issues[x].Notes);
                try { newDataStructure._estimhours = Convert.ToInt32(Issues[x].EstimatedHours); }
                catch { newDataStructure._estimhours = 0; }
                
                newDataStructure._startdate = Convert.ToDateTime(Issues[x].StartDate);
                newDataStructure._duedate = Convert.ToDateTime(Issues[x].DueDate);
                newDataStructure._startdateCh = false;
                newDataStructure._duedateCh = false;
                if (Convert.ToInt32(Convert.ToString(newDataStructure._startdate).Substring(6, 4)) > 2000) newDataStructure._startdateCh = true;
                if (Convert.ToInt32(Convert.ToString(newDataStructure._duedate).Substring(6, 4)) > 2000) newDataStructure._duedateCh = true;
                
                sw.WriteLine(Serilize(newDataStructure));
            }

            if (Issues.Count > 0) sw.WriteLine(Convert.ToInt32(Issues[0].Id));
            else sw.WriteLine(0);
            sw.Close();

        }
       

        public string Serilize(DataStructure myDataStructer)
        {
            return JsonConvert.SerializeObject(myDataStructer);
        }

        public DataStructure Deserilize(string jsonText)
        {
            return JsonConvert.DeserializeObject<DataStructure>(jsonText); // исправить ошибку возникающую когда файлик с проектами пустой.
        }


        public int Getamount()
        {
            linesAmount = File.ReadAllLines(current_modification_file_path).Length - 1;
            
            return linesAmount;
        }

        public DataStructure Get_one_issue(int id)
        {
            string[] readText = File.ReadAllLines(current_modification_file_path);
            for (int i = 0; i< readText.Length - 1; i++) if (Deserilize(readText[i])._numberid == id) return Deserilize(readText[i]);
            try {
                DataStructure newdata = Deserilize(readText[id]);
                return newdata;
            }
            catch {
                DataStructure newdata = Deserilize(readText[id-1]);
                return newdata;
            }
        }

        public DataStructure Get_all_issues(int numb)
        {
            string[] readText = File.ReadAllLines(current_modification_file_path);
            DataStructure ReadenText = new DataStructure();
            if (readText.Length > 1) ReadenText = Deserilize(readText[numb]);
            return ReadenText;
        }

        public void Write_new_issue_information(DataStructure newInfo)
        {
            linesAmount = File.ReadAllLines(current_modification_file_path).Length;
            string[] readText = File.ReadAllLines(current_modification_file_path);
            int existanceNumber = 0;
            
            if (!(newInfo._numberid == -1)) // обновление существующего issue.
            {
                while (existanceNumber < linesAmount-1)
                {
                    if (Deserilize(readText[existanceNumber])._numberid == newInfo._numberid) break;
                    existanceNumber++;
                }
                
                // rewrite the array element
                readText[existanceNumber] = Serilize(newInfo);
                File.Delete(current_modification_file_path);
                File.AppendAllLines(current_modification_file_path, readText);
            }
            
            else
            {
                string[] readText2 = File.ReadAllLines(current_modification_file_path);
                int i = readText2.Length;
                lastFileId = Convert.ToInt32(readText2[i-1]);

                string[] newReadText = new string[i-1];
                for (int j = 0; j < i; j++) if (j < i - 1) newReadText[j] = readText2[j];

                newInfo._numberid = lastFileId + 1;
                lastFileId++;

                File.Delete(current_modification_file_path);
                FileInfo fl = new FileInfo(current_modification_file_path);
                StreamWriter sw = fl.AppendText();
                for (int r = 0; r<i-1; r++) sw.WriteLine(newReadText[r]);
                sw.WriteLine(Serilize(newInfo));
                sw.WriteLine(lastFileId);
                sw.Close();
            } // просто добавляется новая строка в json файл, при отсутвии issue в списке.

            
        }


        public struct DataStructure
        {
            public int _numberid;
            public string _project;
            public int _projectid;
            public string _subject;

            public int _done;
            public string _priority;

            public string _assignedto;
            public int _assignedtoid;

            public string _status;
            public string _trackerid;

            public bool _startdateCh;
            public bool _duedateCh;
            public DateTime _startdate;
            public DateTime _duedate;
            public DateTime _committime;
            public int _estimhours;
            public int _currentussagetime;

            public string _description;
            public string _notes;
            
            public bool _commit;
            public string _comment;
            public int _activity;
        }
        
    }
}
