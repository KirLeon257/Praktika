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
    public partial class EditForm : Form
    {
        MainForm Form;
        NoteElement element;
        public EditForm(MainForm form)
        {
            InitializeComponent();
            Form = form;
        }

        public EditForm(NoteElement noteElement)
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

            if (this.Text == "Создание")
            {
                CreateNote();
            }
            else if (this.Text == "Редактирование: ")
            {
                EditNote();
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

        void CreateNote()
        {
            NoteClass note = new NoteClass(TitleTextBox.Text, NoteRichText.Text,Form.id_user);
            element = new NoteElement(note, Form);
            Form.Notes.Add(note);
            Form.NoteTable.Controls.Add(element);
            TitleTextBox.Clear();
            NoteRichText.Clear();
            this.Hide();
        }

        void EditNote()
        {
            element.note.Title = TitleTextBox.Text;
            element.note.Text = NoteRichText.Text;
            element.TitleLable.Text = element.note.Title;
            this.Hide();
        }
    }
}
