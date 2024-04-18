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

    public enum EditFormMode
    {
        Create = 1,
        Edit = 2
    }


    public partial class EditForm : Form
    {
        MainForm Form;
        NoteElement element;
        public EditFormMode mode;
        public EditForm(MainForm form)
        {
            InitializeComponent();
            Form = form;
        }

        public EditForm(MainForm form, NoteElement noteElement)
        {
            InitializeComponent();
            Form = form;
            element = noteElement;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == EditFormMode.Create)
            {
                CreateNote();
            }
            else if (mode == EditFormMode.Edit)
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
            if (TitleTextBox.Text == "" && NoteRichText.Text == "")
            {
                new Task(ShowMsg).Start();
                this.Hide();
                return;
            }
            NoteClass note = new NoteClass(NoteRichText.Text, TitleTextBox.Text);
            element = new NoteElement(note, Form);
            InsertElement(element,note);
            this.Hide();
        }

        void EditNote()
        {

            Form.NoteTable.SuspendLayout();
            element.Note.Title = TitleTextBox.Text;
            element.Note.Text = NoteRichText.Text;
            element.TitleLable.Text = element.Note.Title;
            element.TextNoteRichTextBox.Text = element.Note.Text;
            Form.NoteTable.ResumeLayout(true);
            this.Hide();

        }

        void ShowMsg()
        {
            MessageBox.Show("Ничего не изменилось :(");
        }

        void InsertElement(NoteElement element,NoteClass note)
        {
            Form.Notes.Insert(0, note);
            Form.NoteTable.SuspendLayout();
            Form.NoteTable.Controls.Add(element);
            Form.NoteTable.Controls.SetChildIndex(element, 0);
            Form.NoteTable.ResumeLayout(true);
            TitleTextBox.Clear();
            NoteRichText.Clear();
        }
    }
}
