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
            FontConverter fontConverter = new FontConverter();
            EditElement.Note.Text = NoteTextRich.Text;
            EditElement.Note.Title = TitleTextBox.Text;
            NoteTextRich.SelectAll();
            EditElement.Note.FontInfo = fontConverter.ConvertToInvariantString(NoteTextRich.SelectionFont);
            EditElement.ExceptChanges();
            EditElement.HideEditComponents();
            EditElement.ShowDefaultComponents();
            EditElement.Size = EditElement.GetDefaultSize();
            this.Dispose();
        }

        private void NoteEditForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = EditElement.Note.Title;
            NoteTextRich.Text = EditElement.Note.Text;
            if (EditElement.Note.FontInfo != null)
            {
                FontConverter converter = new FontConverter();
                Font noteFont =(Font)converter.ConvertFromInvariantString(EditElement.Note.FontInfo);
                NoteTextRich.SelectAll();
                NoteTextRich.Font = noteFont;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                NoteTextRich.SelectionFont = fontDialog1.Font;
            }
        }
    }
}
