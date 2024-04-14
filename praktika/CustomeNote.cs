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
        
        public NoteElement(NoteClass note)
        {
            InitializeComponent();
            this.note = note;
            TitleLable.Text = note.Title;
            
        }

        public NoteClass GetNoteClass()
        {
            return this.note;
            
        }

        private void NoteElement_DoubleClick(object sender, EventArgs e)
        {
            
            EditNote editNote = new EditNote(this);
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
            
        }
    }
}
