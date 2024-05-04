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
        EditTask editTask;
        public TaskElement(TaskClass task, MainForm form)
        {
            InitializeComponent();
            this.Task = task;
            MainForm = form;
            editTask = new EditTask(this, MainForm);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            SmallTaskClass smallTask = new SmallTaskClass(textBox1.Text);
            if (Task.ContainSmallTask(smallTask))
            {
                return;
            }
            Task.smallTasks.Add(smallTask);
            checkedListBox1.Items.Add(smallTask.SmallTitle);
            if(checkedListBox1.CheckedItems.Count > 0)
            {
                TitleCheckBox.CheckState = CheckState.Indeterminate;
            }
            else
            {
                TitleCheckBox.CheckState = CheckState.Unchecked;
            }

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

            
            for (int i = 0; i < task.smallTasks.Count; i++)
            {

                checkedListBox1.Items.Add(Task.smallTasks[i].SmallTitle);
                if (Task.smallTasks[i].SmallStatus == CheckState.Checked)
                {
                    checkedListBox1.SetItemCheckState(checkedListBox1.Items.IndexOf(Task.smallTasks[i].SmallTitle), CheckState.Checked);
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
            if (TitleCheckBox.CheckState == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }

            }
            else if (TitleCheckBox.CheckState == CheckState.Unchecked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }



        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            CheckState StateTask = CheckTitleStatus(e);
            TitleCheckBox.CheckState = StateTask;
            Task.Status = StateTask;
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleCheckBox.CheckState == CheckState.Checked)
            {
                CheckedAllElement();
            }else if(TitleCheckBox.CheckState == CheckState.Unchecked)
            {
                UncheckedAllElement();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBox1.SelectedIndex != -1)
                {
                    Task.smallTasks.Remove(Task.smallTasks[checkedListBox1.SelectedIndex]);
                    checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.DeleteTask(Task);
            this.Dispose();
        }

        CheckState CheckTitleStatus(ItemCheckEventArgs e)
        {
            CheckState state = new CheckState();
            if (e.NewValue == CheckState.Checked)
            {
                if (checkedListBox1.CheckedItems.Count + 1 > 0 && checkedListBox1.CheckedItems.Count + 1 < checkedListBox1.Items.Count)
                {
                    state = CheckState.Indeterminate;
                }
                else if (checkedListBox1.CheckedItems.Count + 1 == checkedListBox1.Items.Count)
                {
                    state = CheckState.Checked;
                }
                Task.smallTasks[e.Index].SmallStatus = CheckState.Checked;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count - 1 > 0 && checkedListBox1.CheckedItems.Count - 1 < checkedListBox1.Items.Count)
                {
                    state = CheckState.Indeterminate;
                }
                else if (checkedListBox1.CheckedItems.Count - 1 <= 0)
                {
                    state = CheckState.Unchecked;
                }
                Task.smallTasks[e.Index].SmallStatus = CheckState.Unchecked;
            }
            return state;
        }

        void CheckedAllElement()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        void UncheckedAllElement()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
