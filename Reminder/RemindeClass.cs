using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    [Serializable]
    public class RemindeClass
    {
        public string Title { get; set; }
        public DateTime TimeOfReminde { get; set; }

        public RemindeClass(string title, DateTime timeOfReminde)
        {
            Title = title;
            TimeOfReminde = timeOfReminde;
        }


        public void StartReminde()
        {
            MessageBox.Show(Title);
        }
    }
}
