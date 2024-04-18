using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika
{
    public partial class NoteEditForm : Form
    {

        NoteElement EditElement;
        public NoteEditForm(NoteElement element)
        {
            InitializeComponent();
            EditElement = element;

        }

        private void KyrcivToolStrip_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(NoteTextRich.SelectionFont, //1
       (NoteTextRich.SelectionFont.Italic ?             //2
       NoteTextRich.SelectionFont.Style & ~FontStyle.Italic :   //3
       NoteTextRich.SelectionFont.Style | FontStyle.Italic));  //4
            NoteTextRich.SelectionFont = newFont;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(NoteTextRich.SelectionFont, //1
       (NoteTextRich.SelectionFont.Bold ?               //2
       NoteTextRich.SelectionFont.Style & ~FontStyle.Bold : //3
       NoteTextRich.SelectionFont.Style | FontStyle.Bold));  //4
            NoteTextRich.SelectionFont = newFont;
        }

        private void UnderlineTollStrip_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(NoteTextRich.SelectionFont, //1
       (NoteTextRich.SelectionFont.Underline ?              //2
       NoteTextRich.SelectionFont.Style & ~FontStyle.Underline :    //3
       NoteTextRich.SelectionFont.Style | FontStyle.Underline));  //4
            NoteTextRich.SelectionFont = newFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
