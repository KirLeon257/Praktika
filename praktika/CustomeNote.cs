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
        EditForm editNote;
        Color DefaultColor;
        public NoteElement(NoteClass note, MainForm form)
        {
            InitializeComponent();
            this.note = note;
            TitleLable.Text = note.Title;
            TextNoteRichTextBox.Text = note.Text;
            Form = form;
            DefaultColor = this.BackColor;
            editNote = new EditForm(Form, this);
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
            Form.DeleteNoteElement(this);
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

        private void NoteElement_Click(object sender, EventArgs e)
        {
            editNote.Text = "Редактирование";
            editNote.mode = EditFormMode.Edit;
            editNote.TitleTextBox.Text = this.note.Title;
            editNote.NoteRichText.Text = this.note.Text;
            editNote.ShowDialog();
        }
    }
}
