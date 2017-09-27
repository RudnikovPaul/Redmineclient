using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Redmine.Net.Api.Types;
using Redmine.Net.Api;
using System.Net;

namespace Redmine_Client_2._0
{
    static class BuisinessLogicClass
    {
        public static string ConnectionMessage = "", Headline = "";
        public static int SuperIssueId = 0, EditIssueId = 0, AddIssueId = 0;

        public static void Init()
        {
            LocalClass.Init();
        }

        public static int Connect()
        {
            Console.WriteLine(DateTime.Now + ": BuisinessLogicClass.Connect");
            int status = 0; // status types: not available; not connected; connected.
                        
            if (ServerClass.Authentificate())
            {
                status = 2;
                Properties.Settings.Default.Connection = true;
                ConnectionMessage = "Connection and authentification successfull";
                Headline = "Success";
                return status;
            }
            else if (ServerClass.CheckAvailability())
            {
                status = 1;
                ConnectionMessage = "Authentification has failed. \r\nThe server is available.";
                Headline = "Authentification fail";
                Properties.Settings.Default.Connection = false;
            }
            else
            {
                ConnectionMessage = "Redmine server " + Properties.Settings.Default.RedmineAddress + " is not accesible.\r\nYou will work offline.";
                Headline = "Server not available";
                Properties.Settings.Default.Connection = false;
            }
            Console.WriteLine(DateTime.Now + ConnectionMessage);
            Thread MessageBoxThread = new Thread(ShowMessage);
            MessageBoxThread.Start();
            return status;
        }

        private static void ShowMessage()
        {
            MessageBox.Show(ConnectionMessage, Headline, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Update()
        {
            if (Properties.Settings.Default.Connection & !Properties.Settings.Default.OldCommits)
            {
                ServerClass.UpdateVariables();
                ServerClass.GetAllIssues();
            }
        }

        public static bool CheckForOldCommits()
        {
            return LocalClass.CheckForOldCommits();
        }

        public static void OldCommits(bool OperationType)
        {
            Console.WriteLine(DateTime.Now + ": BuisinessLogicClass.OldCommits");
            if (OperationType)
            {
                foreach (string line in LocalClass.GetLocalCommits())
                {
                    try
                    {
                        if (line.Substring(0, 5) == "Time:")
                        {
                            string newLine = line.Substring(5);
                            TimeEntry Entry = JsonConvert.DeserializeObject<TimeEntry>(newLine);
                            DataStructureClass.DataStructure IssueData = new DataStructureClass.DataStructure()
                            {
                                _notCommittedWorkingTime = Convert.ToInt32(Entry.Hours * 3600),
                                _id = Entry.Issue.Id,
                                _projectId = Entry.Project.Id,
                                _assignedToId = Entry.User.Id
                            };
                            ServerClass.CommitTime(Entry.Issue.Id, Entry.Comments, Entry.Activity.Id, Convert.ToDateTime(Entry.SpentOn), IssueData);
                        }
                        if (line.Substring(0, 5) == "Edit:")
                        {
                            string newLine = line.Substring(5);
                            DataStructureClass.DataStructure IssueData = JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(newLine);
                            ServerClass.EditIssue(IssueData);
                        }
                        if (line.Substring(0, 5) == "NewI:")
                        {
                            string newLine = line.Substring(5);
                            TimeEntry Entry = JsonConvert.DeserializeObject<TimeEntry>(newLine);
                            DataStructureClass.DataStructure IssueData = JsonConvert.DeserializeObject<DataStructureClass.DataStructure>(newLine);
                            ServerClass.CreateIssue(IssueData);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The" + line.Substring(0, 4) + "failed to get to the server.", "Send data to server fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else LocalClass.DeleteLocalCommits();
        }

        public static string ConvertDate(DateTime dateTime)
        {
            try
            {
                string StringDateTime = "";
                string day = Convert.ToString(dateTime.Day);
                string month = Convert.ToString(dateTime.Month);
                if (Convert.ToString(dateTime.Day).Length == 1) day = "0" + Convert.ToString(dateTime.Day);
                if (Convert.ToString(dateTime.Month).Length == 1) month = "0" + Convert.ToString(dateTime.Month);
                StringDateTime = day + "." + month + ".";
                if (Convert.ToString(dateTime.Year).Length == 4) { StringDateTime = StringDateTime + Convert.ToString(dateTime.Year).Substring(2, 2); }
                else StringDateTime = StringDateTime + Convert.ToString(dateTime.Year);
                return StringDateTime;
            }
            catch { Console.WriteLine(DateTime.Now + ": Error converting date: " + dateTime); return Convert.ToString(dateTime); }
        }

        public static string NormalizeText(string originalText, int lineLength)
        {
            if (originalText.IndexOf("<pre") > 0) lineLength = 300;
            try
            {
                string normalizedText = "";
                int bite_length = 0;
                string bite_text = "";
                int last_space_id = 0;
                int originalTextLength = originalText.Length;
                if (originalTextLength > 0)
                {
                    while (originalTextLength > 0)
                    {
                        bite_length = originalText.IndexOf("\n");
                        
                        if (bite_length == -1) bite_length = originalTextLength;
                        if (bite_length == 0) bite_length = 1;
                        while (bite_length > 0)
                        {
                            //Console.WriteLine(bite_length + "----------------------------------------");
                            if (bite_length > lineLength)
                            {
                                bite_text = originalText.Substring(0, lineLength);
                                last_space_id = bite_text.LastIndexOf(" ");
                                normalizedText = normalizedText + originalText.Substring(0, last_space_id) + "\n";
                                bite_length = bite_length - last_space_id;
                                originalTextLength = originalTextLength - last_space_id;
                                originalText = originalText.Substring(last_space_id);
                            }
                            else if (bite_length > 0)
                            {
                                normalizedText = normalizedText + originalText.Substring(0, bite_length);
                                originalText = originalText.Substring(bite_length);
                                originalTextLength = originalTextLength - bite_length;
                                bite_length = 0;
                            }
                        }
                    }
                }
                return normalizedText;
            }
            catch { Console.WriteLine(DateTime.Now + ": Error normalizing text: " + originalText); return originalText; }
        }

        public static DataStructureClass.DataStructure[] GetAllIssues()
        {
            DataStructureClass.DataStructure[] allIssues = LocalClass.GetAllIssues();
            return allIssues;
        }

        public static DataStructureClass.DataStructure GetOneIssue(int IssueId)
        {
            return LocalClass.GetOneIssue(IssueId);
        }

        public static string FindIssue(int IssueId)
        {
            AddIssueId = IssueId;
            return ServerClass.FindIssue(IssueId);
        }

        public static void AddIssueByItsId(int IssueId)
        {
            ServerClass.AddIssue(IssueId);
        }

        public static void CommitOneTimeEntry(int Id, string CommentText, int Activity)
        {
            Console.WriteLine(DateTime.Now + ": BuisinessLogicClass.CommitOneTimeEntry: " + Id);
            if (Properties.Settings.Default.Connection) ServerClass.CommitTime(Id, CommentText, Activity, DateTime.Now, GetOneIssue(Id));
            else LocalClass.CommitTime(Id, CommentText, Activity);
            DataStructureClass.DataStructure IssueData = LocalClass.GetOneIssue(Id);
            IssueData._notCommittedWorkingTime = 0;
            LocalClass.EditIssue(IssueData);
        }

        public static void SaveTimeTicked(int IssueId, int TimeAmount)
        {
            LocalClass.AutomaticSaveTime(IssueId, TimeAmount);
        }

        public static void EditIssue(DataStructureClass.DataStructure EditedData)
        {
            if (Properties.Settings.Default.Connection) ServerClass.EditIssue(EditedData);
            else
            {
                LocalClass.EditIssue(EditedData);
                LocalClass.EditIssueCommit(EditedData);
            }
        }

        public static void CreateIssue(DataStructureClass.DataStructure NewData)
        {
            if (Properties.Settings.Default.Connection) ServerClass.CreateIssue(NewData);
            else LocalClass.CreateIssue(NewData);
        }

        public static void DeleteIssue(int IssueId)
        {

        }


        public static string[,] GetVariables(int LineId)
        {
            return LocalClass.GetVariables(LineId);
        }

        public static void CleanUpIssuesFile()
        {
            LocalClass.CleanUpIssuesFile();
        }
    }
}
