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
using ReminderElements;
using Reminder;
using Newtonsoft.Json;

namespace praktika
{
    public partial class MainForm : Form
    {
        public int id_user { get; set; }
        JsonSerializer serializer;
        public List<NoteClass> Notes;
        public List<RemindeClass> Remindes;
        public Dictionary<int, List<NoteClass>> DicNoteUsers;
        public Dictionary<int, List<RemindeClass>> DicReminedUsers;
        NoteEditForm editNote;
        public EditReminde editReminde;
        public string UserLogin { get; set; }

        public MainForm()
        {
            InitializeComponent();
            editReminde = new EditReminde(this);
            editNote = new NoteEditForm(this);
            Notes = new List<NoteClass>();
            Remindes = new List<RemindeClass>();
            serializer = new JsonSerializer();
            DicNoteUsers = new Dictionary<int, List<NoteClass>>();
            DicReminedUsers = new Dictionary<int, List<RemindeClass>>();
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
            editNote.Mode = NoteEditForm.EditFormMode.Create;
            editNote.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotes();
            LoadRemined();
            UserNameLabel.Text = UserLogin;
        }

        void LoadNotes()
        {
            try
            {

                using (JsonTextReader fs = new JsonTextReader(new StreamReader("notes.json")))
                {
                    DicNoteUsers = serializer.Deserialize<Dictionary<int, List<NoteClass>>>(fs);
                    if (DicNoteUsers == null)
                    {
                        DicNoteUsers = new Dictionary<int, List<NoteClass>>();

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
            if (!DicNoteUsers.ContainsKey(id_user))
            {
                return;
            }

            Notes = DicNoteUsers[id_user];
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
            SaveRemineds();
            Application.Exit();

        }

        void SaveNotes()
        {
            if (DicNoteUsers.ContainsKey(id_user))
            {
                DicNoteUsers[id_user] = Notes;
            }
            else
            {
                DicNoteUsers.Add(id_user, Notes);
            }
            using (StreamWriter fs = new StreamWriter("notes.json"))
            {

                serializer.Serialize(fs, DicNoteUsers);
            }

        }

        public void DeleteNoteElement(NoteElement element)
        {
            Notes.Remove(element.Note);
            NoteTable.Controls.Remove(element);
        }

        public void DeleteReminedElement(ReminderElement reminderElement)
        {
            Remindes.Remove(reminderElement.Reminde);
            ReminedTable.Controls.Remove(reminderElement);
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editReminde.Mode = EditFormMode.Create;
            editReminde.ShowDialog();
        }

        void LoadRemined()
        {
            try
            {
                using (JsonTextReader fs = new JsonTextReader(new StreamReader("remineds.json")))
                {
                    DicReminedUsers = serializer.Deserialize<Dictionary<int, List<RemindeClass>>>(fs);
                    if (DicReminedUsers == null)
                    {
                        DicReminedUsers = new Dictionary<int, List<RemindeClass>>();

                    }
                    AddRemites();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        void AddRemites()
        {
            if (!DicReminedUsers.ContainsKey(id_user))
            {
                return;
            }

            Remindes = DicReminedUsers[id_user];
            if (Remindes.Count == 0)
            {
                return;
            }
            foreach (RemindeClass reminde in Remindes)
            {
                ReminderElement element = new ReminderElement(reminde, this);
                element.Change();
                ReminedTable.Controls.Add(element);
                ReminedTable.Controls.SetChildIndex(element, 0);
            }
        }

        void SaveRemineds()
        {
            try
            {
                if (DicReminedUsers.ContainsKey(id_user))
                {
                    DicReminedUsers[id_user] = Remindes;
                }
                else
                {
                    DicReminedUsers.Add(id_user, Remindes);
                }
                using (StreamWriter fs = new StreamWriter("remineds.json"))
                {

                    serializer.Serialize(fs, DicReminedUsers);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
