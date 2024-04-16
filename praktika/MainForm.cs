using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Note;
using System.Xml.Serialization;


namespace praktika
{
    public partial class MainForm : Form
    {
        public int id_user { get; set; }
        XmlSerializer serializer;
        public List<NoteClass> Notes;
        EditForm editNote;

        public MainForm()
        {
            InitializeComponent();
            editNote = new EditForm(this);
            Notes = new List<NoteClass>();
            serializer = new XmlSerializer(Notes.GetType());
        }

        private void NoteBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void TaskBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            editNote.Text = "Создание";
            editNote.mode = EditFormMode.Create;
            editNote.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        void LoadNotes()
        {
            try
            {

                using (FileStream fs = new FileStream("notes.xml", FileMode.Open))
                {
                    Notes = (List<NoteClass>)serializer.Deserialize(fs);
                    if (Notes.Count == 0)
                    {
                        return;
                    }
                    AddNotes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult.ToString());
            }
        }

        void AddNotes()
        {

            foreach (NoteClass note in Notes)
            {
                if (note.id_user == id_user)
                {
                    NoteElement element = new NoteElement(note, this);
                    NoteTable.Controls.Add(element);
                }
            }


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveNotes();
            Application.Exit();

        }

        void SaveNotes()
        {

            using (FileStream fs = new FileStream("notes.xml", FileMode.Create))
            {

                serializer.Serialize(fs, Notes);
            }

        }

        public void DeleteNoteElement(NoteElement element)
        {
            Notes.Remove(element.note);
            NoteTable.Controls.Remove(element);
        }
    }
}
