using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBook
{
    [Serializable]
    public class TaskClass
    {
        public string Title { get; set; }
        public CheckState Status { get; set; }
        public List<SmallTaskClass> smallTasks;

        public TaskClass(string title)
        {
            Title = title;
            Status = CheckState.Unchecked;
            smallTasks = new List<SmallTaskClass>();
        }

        public void AddSmallTask(string title)
        {
            SmallTaskClass smallTask = new SmallTaskClass(title);
            smallTasks.Add(smallTask);
        }

        public bool ContainSmallTask(SmallTaskClass smallTask)
        {
            foreach (SmallTaskClass smallName in smallTasks)
            {
                if (smallTask.SmallTitle == smallName.SmallTitle)
                {
                    return true;
                }
            }

            return false;
        }
    }
    [Serializable]
    public class SmallTaskClass
    {
        public string SmallTitle { get; set; }
        public CheckState SmallStatus { get; set; }

        public SmallTaskClass(string title)
        {
            SmallTitle = title;
            SmallStatus = CheckState.Unchecked;
        }
    }
}
