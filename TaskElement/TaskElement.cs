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


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            SmallTaskClass smallTask = new SmallTaskClass(textBox1.Text);
            Task.smallTasks.Add(smallTask);
            checkedListBox1.Items.Add(smallTask.SmallTitle);
            textBox1.Clear();
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
                checkedListBox1.Items.Add(smallTask.SmallTitle);
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

        public void ExceptChange()
        {
            TitleCheckBox.Text = Task.Title;
            LoadSmallTasks(Task);
        }

        

        private void TitleCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (TitleCheckBox.CheckState==CheckState.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                
            }
            else if(TitleCheckBox.CheckState == CheckState.Unchecked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        

        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if(checkedListBox1.CheckedItems.Count+1>0 && checkedListBox1.CheckedItems.Count+1 < checkedListBox1.Items.Count)
                {
                    TitleCheckBox.CheckState = CheckState.Indeterminate;
                }else if(checkedListBox1.CheckedItems.Count + 1== checkedListBox1.Items.Count)
                {
                    TitleCheckBox.CheckState = CheckState.Checked;
                }
            }
            else if(e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count - 1 > 0 && checkedListBox1.CheckedItems.Count - 1 < checkedListBox1.Items.Count)
                {
                    TitleCheckBox.CheckState = CheckState.Indeterminate;
                }
                else if (checkedListBox1.CheckedItems.Count - 1 <= 0)
                {
                    TitleCheckBox.CheckState = CheckState.Unchecked;
                }
            }
        }
    }
}
