using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBook;
using TaskElement;

namespace praktika
{
    public partial class EditTask : Form
    {
        public EditFormMode Mode;
        TaskElement.TaskElement element;
        MainForm MainForm;
        int SelectedIndex;
        public EditTask(TaskElement.TaskElement element, MainForm form)
        {
            InitializeComponent();
            this.element = element;
            MainForm = form;
        }

        public EditTask(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите доп задачу!");
                return;
            }
            if (listBox1.Items.Contains(textBox2.Text)){
                return;
            }

            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            if (Mode == EditFormMode.Edit)
            {
                textBox1.Text = element.Task.Title;
                LoadSmallTasks();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Mode == EditFormMode.Create)
            {
                CreateTask();
            }
        }

        void CreateTask()
        {
            TaskClass task = new TaskClass(textBox1.Text);
            foreach (var item in listBox1.Items)
            {
                task.AddSmallTask((string)item);
            }
            TaskElement.TaskElement element = new TaskElement.TaskElement(task, MainForm);
            MainForm.Tasks.Add(task);
            MainForm.TasksFlowLayout.Controls.Add(element);
            Hide();
        }

        private void EditTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mode == EditFormMode.Edit)
            {
                textBox2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
        }

        void LoadSmallTasks()
        {
            foreach (SmallTaskClass task in element.Task.smallTasks)
            {
                listBox1.Items.Add(task.SmallTitle);
            }
        }

        void EditSmallTask(int index)
        {

        }
    }
}
