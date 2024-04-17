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
using Newtonsoft.Json;

namespace praktika
{
    public partial class MainForm : Form
    {
        public int id_user;
        JsonSerializer serializer;
        public List<NoteClass> Notes;
        Dictionary<int, List<NoteClass>> DicUsers;
        EditForm editNote;

        public MainForm()
        {
            InitializeComponent();
            editNote = new EditForm(this);
            Notes = new List<NoteClass>();
            serializer = new JsonSerializer();
            DicUsers = new Dictionary<int, List<NoteClass>>();
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

                using (JsonTextReader fs = new JsonTextReader(new StreamReader("notes.json")))
                {
                    DicUsers = serializer.Deserialize<Dictionary<int, List<NoteClass>>>(fs);
                    if (DicUsers == null)
                    {
                        DicUsers = new Dictionary<int, List<NoteClass>>();
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
            Notes = DicUsers[id_user];
            if (Notes.Count == 0)
            {
                return;
            }
            foreach (NoteClass note in Notes)
            {
                NoteElement element = new NoteElement(note, this);
                NoteTable.Controls.Add(element);
            }


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveNotes();
            Application.Exit();

        }

        void SaveNotes()
        {
            if (DicUsers.ContainsKey(id_user))
            {
                DicUsers[id_user] = Notes;
            }
            else
            {
                DicUsers.Add(id_user, Notes);
            }
            using (StreamWriter fs = new StreamWriter("notes.json"))
            {

                serializer.Serialize(fs, DicUsers);
            }

        }

        public void DeleteNoteElement(NoteElement element)
        {
            Notes.Remove(element.note);
            NoteTable.Controls.Remove(element);
        }
    }
}
