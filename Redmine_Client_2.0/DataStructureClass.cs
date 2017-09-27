using System;

namespace Redmine_Client_2._0
{
    class DataStructureClass
    {
        public struct DataStructure
        {            
            public string _projectName;
            public int _projectId;

            public string _subjectName;
            public int _id;

            public float? _percentDone;

            public string _priority;
            public int _priorityId;

            public string _assignedTo;
            public int _assignedToId;

            public string _status;
            public int _statusId;

            public string _tracker;
            public int _trackerId;

            public bool _startDateCh;
            public bool _dueDateCh;
            public DateTime _startDate;
            public DateTime _dueDate;
            public float? _estimHours;
            public int _notCommittedWorkingTime;

            public string _description;
            public string _notes;
        }
    }
}
