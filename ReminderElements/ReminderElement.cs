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
using praktika;

namespace ReminderElements
{
    public partial class ReminderElement : UserControl
    {
        public RemindeClass Reminde { get; }
        MainForm mainForm;
        EditReminde EditReminde;
        public ReminderElement(RemindeClass reminde, MainForm mainForm)
        {
            InitializeComponent();
            Reminde = reminde;
            this.mainForm = mainForm;
            EditReminde = new EditReminde(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now < Reminde.TimeOfReminde)
            {
                return;
            }
            timer1.Enabled = false;
            Reminde.StartReminde();
            mainForm.DeleteReminedElement(this);
            this.Dispose();
        }

        public void Change()
        {
            TitleLable.Text = Reminde.Title;
            DateTimeLabel.Text = Reminde.TimeOfReminde.ToString();
        }

        private void ReminderElement_Load(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить напоминание \"{Reminde.Title}\"", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mainForm.DeleteReminedElement(this);
                mainForm.Remindes.Remove(Reminde);
                this.Dispose();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReminde.Mode = EditFormMode.Edit;
            EditReminde.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
