using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reminder;
using ReminderElements;

namespace praktika
{
    public partial class EditReminde : Form
    {

        DateTime picker;
        ReminderElement reminderElement;
        MainForm form;
        EditFormMode formMode;
        public EditReminde(ReminderElement element, MainForm form)
        {
            reminderElement = element;
            this.form = form;
            InitializeComponent();
        }

        public EditReminde(MainForm form)
        { 
            this.form = form;
            InitializeComponent();
        }

        public EditReminde(ReminderElement element)
        {
            reminderElement = element;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(formMode == EditFormMode.Create)
            {
                CreateRemined();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Поле не должно быть пустым!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        void CreateRemined()
        {
            if (!Validation)
            {
                return;
            }
            RemindeClass reminde = new RemindeClass();
        }

        bool Validation()
        {
            if (textBox1.Text == "" || dateTimePicker1.)
        }
    }
}
