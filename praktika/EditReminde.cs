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

        ReminderElement reminderElement;
        MainForm Form;
        public EditFormMode Mode { get; set; }
        public EditReminde(ReminderElement element, MainForm form)
        {
            reminderElement = element;
            this.Form = form;
            InitializeComponent();
        }

        public EditReminde(MainForm form)
        { 
            this.Form = form;
            InitializeComponent();
        }

        public EditReminde(ReminderElement element)
        {
            reminderElement = element;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Mode == EditFormMode.Create)
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
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text);
            RemindeClass reminde = new RemindeClass(textBox1.Text, dateTime);
            ReminderElement element = new ReminderElement(reminde);
            element.Change();
            Form.ReminedTable.Controls.Add(element);
            Form.ReminedTable.Controls.SetChildIndex(element, 0);
            this.Hide();
        }

        //bool CheckValidation()
        //{
        //    if (textBox1.Text == "" || dateTimePicker1.Value < DateTime.Now)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        private void EditReminde_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Now;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
    }
}
