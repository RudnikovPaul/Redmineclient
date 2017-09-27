using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using Redmine.Net.Api.Types;
using Redmine.Net.Api;

namespace Redmine_Client_2._0
{
    static class LocalClass
    {
        //public static string folderPath = Environment.ExpandEnvironmentVariables(@"RedmineClient20");
        public static string folderPath = Environment.ExpandEnvironmentVariables(@"%APPDATA%\RedmineClient20");
        private static string CurrentModificationPath = Path.Combine(folderPath, "issues.json");
        private static string VariablesPath = Path.Combine(folderPath, "variables.json");
        private static string CommitPath = Path.Combine(folderPath, "commits.json");
        private static string LogPath = Path.Combine(folderPath, "log.txt");

        public static void Init()
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.Init");
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
            if (!File.Exists(CurrentModificationPath)) File.Create(CurrentModificationPath).Close();
            if (!File.Exists(VariablesPath)) File.Create(VariablesPath).Close();
            if (!File.Exists(CommitPath)) File.Create(CommitPath).Close();
            if (!File.Exists(LogPath)) File.Create(LogPath).Close();
            
            FileInfo f = new FileInfo(LogPath);
            if (f.Length > 1000000)  // 1000000 - 1Mb
            {
                string[] readText = File.ReadAllLines(LogPath);
                File.Delete(LogPath);

                StreamWriter sw = File.AppendText(LogPath);
                for (int x = readText.Length / 4; x < readText.Length; x++) sw.WriteLine(readText[x]);
                sw.Close();
            }
        }

        public static DataStructureClass.DataStructure[] GetAllIssues()
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.GetAllIssues");
            string[] readText = File.ReadAllLines(CurrentModificationPath);
            DataStructureClass.DataStructure[] allIssues = new DataStructureClass.DataStructure[readText.Length];

            for (int x = 0; x < readText.Length; x++) allIssues[x] = JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(readText[x]);
            return allIssues;
        }

        public static DataStructureClass.DataStructure GetOneIssue(int IssueId)
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.GetOneIssue: " + IssueId);

            DataStructureClass.DataStructure oneIssue = new DataStructureClass.DataStructure();
            string[] readText = File.ReadAllLines(CurrentModificationPath);
            for (int x = 0; x < readText.Length; x++) if (IssueId == JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(readText[x])._id) oneIssue = JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(readText[x]);
            return oneIssue;
        }

        public static string[,] GetVariables(int RowId)
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.GetVariables " + RowId);
            return JsonConvert.DeserializeObject<string[,]>(File.ReadAllLines(VariablesPath)[RowId - 1]);
        }

        public static void CommitTime(int Id, string CommentText, int Activity)
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.CommitTime " + Id);
            DataStructureClass.DataStructure IssueData = GetOneIssue(Id);
            TimeEntry entry = new TimeEntry();
            entry.Comments = CommentText;
            entry.Activity = new IdentifiableName { Id = Activity };
            entry.Hours = (decimal)IssueData._notCommittedWorkingTime / 3600;
            entry.SpentOn = DateTime.Now;
            entry.Issue = new IdentifiableName { Id = IssueData._id };
            entry.Project = new IdentifiableName { Id = IssueData._projectId };
            entry.User = new IdentifiableName { Id = IssueData._assignedToId };
            
            FileInfo fl = new FileInfo(CommitPath);
            StreamWriter sw = fl.AppendText();
            sw.WriteLine("Time:" + JsonConvert.SerializeObject(entry));
            sw.Close();
        }

        public static bool CheckForOldCommits()
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.CheckForOldCommits");
            string[] str = File.ReadAllLines(CommitPath);
            if (str.Length > 0) return true;
            return false;
        }

        public static string[] GetLocalCommits()
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.GetLocalCommits");
            return File.ReadAllLines(CommitPath);
        }

        public static void DeleteLocalCommits()
        {
            File.WriteAllText(CommitPath, string.Empty);
        }

        public static void AutomaticSaveTime(int IssueId, int TimeAmount)
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.AutomaticSaveTime" + TimeAmount);
            string[] readText = File.ReadAllLines(CurrentModificationPath);
            int linesAmount = readText.Length, LineId = 0;            
            foreach (string line in readText)
            {
                DataStructureClass.DataStructure data = JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(line);
                if (data._id == IssueId)
                {
                    //data._commitStatus = true;
                    data._notCommittedWorkingTime += TimeAmount;
                    readText[LineId] = JsonConvert.SerializeObject(data);
                    break;
                }
                LineId++;
            }            
            File.Delete(CurrentModificationPath);
            File.AppendAllLines(CurrentModificationPath, readText);
        }

        public static void EditIssue(DataStructureClass.DataStructure EditedData)
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.AutomaticSaveTime" + EditedData._id);
            string[] readText = File.ReadAllLines(CurrentModificationPath);
            int linesAmount = readText.Length, LineId = 0;
            foreach (string line in readText)
            {
                DataStructureClass.DataStructure data = JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(line);
                if (JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(line)._id == EditedData._id)
                {
                    readText[LineId] = JsonConvert.SerializeObject(EditedData);
                    LineId++;
                    break;
                }
            }
            File.Delete(CurrentModificationPath);
            File.AppendAllLines(CurrentModificationPath, readText);            
        }

        public static void EditIssueCommit(DataStructureClass.DataStructure NewData)
        {
            Console.WriteLine(DateTime.Now + ": LocalClass.AutomaticSaveTime");
            // add a local commit message
            FileInfo fi = new FileInfo(CommitPath);
            StreamWriter si = fi.AppendText();
            si.WriteLine("Edit:" + JsonConvert.SerializeObject(NewData));
            si.Close();
        }

        public static void CreateIssue(DataStructureClass.DataStructure NewData)
        {
            Console.WriteLine(DateTime.Now + ": local.createIssue");
            FileInfo fl = new FileInfo(CurrentModificationPath);  // save data to current modification file.
            StreamWriter sw = fl.AppendText();
            sw.WriteLine(JsonConvert.SerializeObject(NewData));
            sw.Close();

            FileInfo fi = new FileInfo(CommitPath);  // save data to commit file to send it to server.
            StreamWriter si = fi.AppendText();
            si.WriteLine("NewI:" + JsonConvert.SerializeObject(NewData));
            si.Close();
        }

        public static void DeleteIssue(int IssueId)
        {

        }

        public static void CleanUpIssuesFile()
        {
            
        }

        public static void AddIssue(int IssueId)
        {
            // add issue id to issue list.
        }
    }
}
