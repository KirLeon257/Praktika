using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBook;
using praktika;

namespace TaskElement
{
    public partial class TaskElement : UserControl
    {
        TaskClass Task;
        MainForm MainForm;
        public TaskElement(TaskClass task, MainForm form)
        {
            InitializeComponent();
            this.Task = task;
            MainForm = form;
        }


        public TaskElement()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TaskElement_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TaskElement_Load(object sender, EventArgs e)
        {
            TitleCheckBox.Text = Task.Title;
            LoadSmallTasks(Task);
        }

        void LoadSmallTasks(TaskClass task)
        {
            if (task.smallTasks.Count == 0)
            {
                return;
            }

            foreach (SmallTaskClass smallTask in task.smallTasks)
            {
                checkedListBox1.Items.Add(smallTask);
                if (smallTask.SmallStatus)
                {
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(smallTask), true);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddSmallTask(textBox1.Text);
        }

        public void AddSmallTask(string title)
        {
            SmallTaskClass smallTask = new SmallTaskClass(title);
            Task.smallTasks.Add(smallTask);
        }
    }
}
