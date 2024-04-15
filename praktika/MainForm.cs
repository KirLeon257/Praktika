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


        public MainForm()
        {
            InitializeComponent();

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
            EditForm editNote = new EditForm(this);
            editNote.Text = "Создание";
            editNote.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            LoadNotes();
        }

        void LoadNotes()
        {

            using (FileStream fs = new FileStream("notes.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    Notes = (List<NoteClass>)serializer.Deserialize(fs);
                }
                catch (InvalidOperationException ex)
                {
                    serializer.Serialize(fs, Notes);
                }
                if (Notes.Count == 0)
                {
                    return;
                }
                AddNotes();
            }
        }

        void AddNotes()
        {

            foreach (NoteClass note in Notes)
            {
                if (note.id_user==id_user)
                {
                    NoteElement element = new NoteElement(note, this);
                    NoteTable.Controls.Add(element);
                }
            }

            NoteTable.Update();
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

            NoteTable.Controls.Remove(element);
        }
    }
}
