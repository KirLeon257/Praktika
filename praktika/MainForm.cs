using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Note;
using ReminderElements;
using Reminder;
using TaskBook;
using TaskElement;
using Newtonsoft.Json;

namespace praktika
{
    public partial class MainForm : Form
    {
        public int id_user { get; set; }

        readonly string PATH_NOTE = "notes.json";
        readonly string PATH_DIR = "resorses";
        readonly string PATH_REMINDES = "remineds.json";
        readonly string PATH_TASKS = "tasks.json";
        JsonSerializer serializer;
        public List<NoteClass> Notes;
        public List<RemindeClass> Remindes;
        public List<TaskClass> Tasks;

        public Dictionary<int, List<NoteClass>> DicNoteUsers;
        public Dictionary<int, List<RemindeClass>> DicReminedUsers;
        public Dictionary<int, List<TaskClass>> DicTaskUsers;

        NoteEditForm editNote;
        public EditReminde editReminde;
        public string UserLogin { get; set; }
        EditTask editTask;

        public MainForm()
        {
            InitializeComponent();

            editReminde = new EditReminde(this);
            editNote = new NoteEditForm(this);
            editTask = new EditTask(this);

            Notes = new List<NoteClass>();
            Remindes = new List<RemindeClass>();
            Tasks = new List<TaskClass>();

            DicNoteUsers = new Dictionary<int, List<NoteClass>>();
            DicReminedUsers = new Dictionary<int, List<RemindeClass>>();
            DicTaskUsers = new Dictionary<int, List<TaskClass>>();

            serializer = new JsonSerializer();
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
            LoadTasks();
            UserNameLabel.Text = UserLogin;
        }

        void LoadNotes()
        {
            try
            {

                using (JsonTextReader fs = new JsonTextReader(new StreamReader(PATH_NOTE)))
                {
                    DicNoteUsers = serializer.Deserialize<Dictionary<int, List<NoteClass>>>(fs);
                    if (DicNoteUsers == null)
                    {
                        DicNoteUsers = new Dictionary<int, List<NoteClass>>();

                    }
                    AddNotes();

                }
            }
            catch (FileNotFoundException)
            {
                throw;
                //File.Create(PATH_NOTE).Close();
            }catch (DirectoryNotFoundException)
            {
                throw;
                //Directory.CreateDirectory(PATH_DIR);
                //File.Create(PATH_NOTE).Close();
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
            SaveTasks();
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
            using (StreamWriter fs = new StreamWriter(PATH_NOTE))
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
                using (JsonTextReader fs = new JsonTextReader(new StreamReader(PATH_REMINDES)))
                {
                    DicReminedUsers = serializer.Deserialize<Dictionary<int, List<RemindeClass>>>(fs);
                    if (DicReminedUsers == null)
                    {
                        DicReminedUsers = new Dictionary<int, List<RemindeClass>>();

                    }
                    AddRemites();
                }
                
            }
            catch (FileNotFoundException)
            {
                //File.Create(PATH_REMINDES).Close();
            }
            catch (DirectoryNotFoundException)
            {
               // Directory.CreateDirectory(PATH_DIR);
               // //File.Create(PATH_REMINDES).Close();
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
                using (StreamWriter fs = new StreamWriter(PATH_REMINDES))
                {

                    serializer.Serialize(fs, DicReminedUsers);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editTask.Mode = EditFormMode.Create;
            editTask.ShowDialog();
        }

        void SaveTasks()
        {
            try
            {
                if (DicTaskUsers.ContainsKey(id_user))
                {
                    DicTaskUsers[id_user] = Tasks;
                }
                else
                {
                    DicTaskUsers.Add(id_user, Tasks);
                }

                using (StreamWriter sw = new StreamWriter(PATH_TASKS))
                {
                    serializer.Serialize(sw, DicTaskUsers);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        void LoadTasks()
        {
            try
            {
                using (JsonTextReader jr = new JsonTextReader(new StreamReader("tasks.json")))
                {
                    DicTaskUsers = serializer.Deserialize<Dictionary<int, List<TaskClass>>>(jr);
                    if (DicTaskUsers == null)
                    {
                        return;
                    }

                    AddTasks();
                }
            }
            catch (FileNotFoundException)
            {
                File.Create("tasks.json").Close();
            }
        }

        void AddTasks()
        {
            if (DicTaskUsers.Count == 0)
            {
                return;
            }

            Tasks = DicTaskUsers[id_user];
            foreach (TaskClass task in Tasks)
            {
                TaskElement.TaskElement taskElement = new TaskElement.TaskElement(task, this);
                TasksFlowLayout.Controls.Add(taskElement);
            }
        }
    }
}
