using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reminder;

namespace ReminderElements
{
    public partial class ReminderElement : UserControl
    {
        RemindeClass Reminde;
        public ReminderElement(RemindeClass reminde)
        {
            InitializeComponent();
            Reminde = reminde;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > Reminde.TimeOfReminde) 
            {
                return;
            }
            Reminde.StartReminde();
            this.Dispose();
        }
    }
}
