using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Note;

namespace praktika
{
    public partial class EditNote : Form
    {
        MainForm Form;
        NoteElement element;
        public EditNote(MainForm form)
        {
            InitializeComponent();
            Form = form;
        }

        public EditNote(NoteElement noteElement)
        {
            InitializeComponent();
            element = noteElement;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "")
            {
                MessageBox.Show("Введите название заметки!");
                return;
            }

            if (Form != null)
            {
                NoteClass note = new NoteClass(TitleTextBox.Text, NoteRichText.Text);
                element = new NoteElement(note,Form);
                Form.Notes.Add(note);
                Form.NoteTable.Controls.Add(element);
                TitleTextBox.Clear();
                NoteRichText.Clear();
                this.Hide();
            }else if (element != null)
            {
                element.note.Title = TitleTextBox.Text;
                element.note.Text = NoteRichText.Text;
                element.TitleLable.Text = element.note.Title;
                this.Hide();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public NoteElement ReturnNoteElement()
        {
            return element;
        }
    }
}
