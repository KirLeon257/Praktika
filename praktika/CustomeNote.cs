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
    public partial class NoteElement : UserControl
    {
        public NoteClass note;
        public MainForm Form;
        Color DefaultColor;
        public NoteElement(NoteClass note, MainForm form)
        {
            InitializeComponent();
            this.note = note;
            TitleLable.Text = note.Title;
            TextNoteRichTextBox.Text = note.Text;
            Form = form;
            DefaultColor = this.BackColor;
        }


        private void NoteElement_DoubleClick(object sender, EventArgs e)
        {
            
            EditForm editNote = new EditForm(this);
            editNote.Text = "Редактирование: ";
            editNote.TitleTextBox.Text = this.note.Title;
            editNote.NoteRichText.Text = this.note.Text;
            editNote.ShowDialog();
        }

        public void Update()
        {
            TitleLable.Text = note.Title;
        }

        private void NoteElement_Load(object sender, EventArgs e)
        {
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.NoteTable.Controls.Remove(this);
            Form.Notes.Remove(this.note);
            this.Dispose();
        }

        private void NoteElement_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.OrangeRed;
        }

        private void NoteElement_MouseLeave(object sender, EventArgs e)
        {
            BackColor = DefaultColor;
        }
    }
}
