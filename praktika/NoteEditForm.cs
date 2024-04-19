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

        NoteElement EditElement, NewElement;
        MainForm MainForm;
       public EditFormMode Mode { get; set; }

        public enum EditFormMode
        {
            Create = 1,
            Edit = 2
        }

        public NoteEditForm(MainForm form, NoteElement element)
        {
            InitializeComponent();
            EditElement = element;
            MainForm = form;
        }
        public NoteEditForm(NoteElement element)
        {
            InitializeComponent();
            EditElement = element;
        }

        public NoteEditForm(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
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
            

            if (Mode == EditFormMode.Create)
            {
                CreateNote();
            }
            else if (Mode == EditFormMode.Edit)
            {
                EditNote();
            }

            this.Hide();
        }

        private void NoteEditForm_Load(object sender, EventArgs e)
        {
            if (Mode == EditFormMode.Edit)
            {
                LoadElement();
            }

            NoteTextRich.Focus();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                NoteTextRich.SelectionFont = fontDialog1.Font;
            }
        }

        void CreateNote()
        {
            if (TitleTextBox.Text == "" && NoteTextRich.Text == "")
            {
                new Task(ShowMsg).Start();
                this.Hide();
                return;
            }
            NoteClass note = new NoteClass(NoteTextRich.Text, TitleTextBox.Text);
            NoteTextRich.SelectAll();
            note.FontInfo = new FontConverter().ConvertToInvariantString(NoteTextRich.SelectionFont);
            NewElement = new NoteElement(note, MainForm);
            InsertElement(NewElement, note);
            this.Hide();
        }

        void ShowMsg()
        {
            MessageBox.Show("Ничего нет!");
        }

        void InsertElement(NoteElement element, NoteClass note)
        {
            MainForm.Notes.Insert(0, note);
            MainForm.NoteTable.SuspendLayout();
            MainForm.NoteTable.Controls.Add(element);
            MainForm.NoteTable.Controls.SetChildIndex(element, 0);
            MainForm.NoteTable.ResumeLayout(true);
            TitleTextBox.Clear();
            NoteTextRich.Clear();
        }

        void EditNote()
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
        }

        void LoadElement()
        {
            TitleTextBox.Text = EditElement.Note.Title;
            NoteTextRich.Text = EditElement.Note.Text;
            if (EditElement.Note.FontInfo != null)
            {
                FontConverter converter = new FontConverter();
                Font noteFont = (Font)converter.ConvertFromInvariantString(EditElement.Note.FontInfo);
                NoteTextRich.SelectAll();
                NoteTextRich.Font = noteFont;
            }
        }
    }
}
