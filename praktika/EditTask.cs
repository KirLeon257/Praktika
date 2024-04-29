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
        EditFormMode Mode;
        TaskElement.TaskElement element;
        MainForm MainForm;
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
            if (textBox2.Text != "")
            {
                MessageBox.Show("Введите доп задачу!");
                return;
            }

            listBox1.Items.Add(textBox2.Text);
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Mode == EditFormMode.Create)
            {
                CreateTask();
            }
        }

        void CreateTask()
        {
            TaskClass task = new TaskClass(textBox1.Text);
            foreach (var item in listBox1.Items)
            {
                task.AddSmallTask(item.ToString());
            }
            TaskElement.TaskElement element = new TaskElement.TaskElement(task,MainForm);
            
        }
    }
}
