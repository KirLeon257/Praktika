using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

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
            // Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("ReminedId", 9813)
                .AddText("Напоминание!!!")
                .AddText(Title)
                .SetToastDuration(ToastDuration.Long)
                .SetToastScenario(ToastScenario.Reminder)
                .Show();
        }
    }
}
