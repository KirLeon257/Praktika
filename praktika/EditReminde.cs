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
            }else if (Mode == EditFormMode.Edit)
            {
                EditR();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        void CreateRemined()
        {
            if (!CheckValidation() || textBox1.Text==""){
                new Task(() => MessageBox.Show("Введены некоректные значения!")).Start();
                return;
            }
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text);
            RemindeClass reminde = new RemindeClass(textBox1.Text, dateTime);
            ReminderElement element = new ReminderElement(reminde,Form);
            element.Change();
            Form.Remindes.Add(reminde);
            Form.ReminedTable.Controls.Add(element);
            Form.ReminedTable.Controls.SetChildIndex(element, 0);
            textBox1.Clear();
            this.Hide();
        }

        bool CheckValidation()
        {
            if (DateTime.Parse(dateTimePicker1.Text) < DateTime.Now)
            {
                return false;
            }
            return true;
        }

        void EditR()
        {
            reminderElement.Reminde.Title = textBox1.Text;
            reminderElement.Reminde.TimeOfReminde = DateTime.Parse(dateTimePicker1.Text);
            reminderElement.Change();
            this.Hide();
        }

        private void EditReminde_Load(object sender, EventArgs e)
        {
            if (Mode==EditFormMode.Edit)
            {
                textBox1.Text = reminderElement.Reminde.Title;
                dateTimePicker1.Value = reminderElement.Reminde.TimeOfReminde;
            }
            
        }
    }
}
