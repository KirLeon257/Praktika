using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook
{
    [Serializable]
    public class TaskClass
    {
        public string Title { get; set; }
        bool Status { get; set; }
        public List<SmallTaskClass> smallTasks;

        public TaskClass(string title)
        {
            Title = title;
            Status = false;
            smallTasks = new List<SmallTaskClass>();
        }

        public void AddSmallTask(string title)
        {
            SmallTaskClass smallTask = new SmallTaskClass(title);
            smallTasks.Add(smallTask);
        }
    }

    public class SmallTaskClass
    {
        public string SmallTitle { get; set; }
        public bool SmallStatus { get; set; }

        public SmallTaskClass(string title)
        {
            SmallTitle = title;
            SmallStatus = false;
        }
    }
}
