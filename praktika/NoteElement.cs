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
        public MainForm Form;
        //EditForm editNote;
        Color DefaultColor;

        Size EditSize, DefaultSize;
        TextBox TitleTextBox;
        RichTextBox NoteTextRich;
        Button ConfirmBtn;
        public NoteElement(NoteClass note, MainForm form)
        {
            InitializeComponent();
            this.note = note;
            TitleLable.Text = note.Title;
            TextNoteRichTextBox.Text = note.Text;
            Form = form;
            DefaultColor = this.BackColor;
            // editNote = new EditForm(Form, this);
            DefaultSize = Size;
            EditSize = new Size(DefaultSize.Width, DefaultSize.Height + 50);
            TitleTextBox = new TextBox();
            NoteTextRich = new RichTextBox();
            ConfirmBtn = new Button();
            ConfirmBtn.Click += ConfirmBtn_Click;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Length == 0 && NoteTextRich.Text.Length != 0)
            {
                note.Title = "Нет названия";
                note.Text = NoteTextRich.Text;
                ExceptChanges();
            }
            else if (TitleTextBox.Text.Length != 0 && NoteTextRich.Text.Length != 0)
            {
                note.Title = TitleTextBox.Text;
                note.Text = NoteTextRich.Text;
                ExceptChanges();
            }
            else
            {
                if (MessageBox.Show($"Вы хотите удалить заметку {TitleLable.Text}", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    удалитьToolStripMenuItem.PerformClick();
                }
            }
            
            HideEditComponents();
            //this.ValidateChildren();
            ShowDefaultComponents();

            Size = DefaultSize;
        }



        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.DeleteNoteElement(this);
            this.Dispose();
        }

        private void NoteElement_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.OrangeRed;
        }

        private void NoteElement_MouseLeave(object sender, EventArgs e)
        {
            BackColor = DefaultColor;
        }

        private void NoteElement_Click(object sender, EventArgs e)
        {

        }

        void HideDefaultComponents()
        {
            TitleLable.Hide();
            TextNoteRichTextBox.Hide();
        }

        void ShowDefaultComponents()
        {
            TitleLable.Show();
            TextNoteRichTextBox.Show();
        }

        void HideEditComponents()
        {
            ConfirmBtn.Hide();
            TitleTextBox.Hide();
            NoteTextRich.Hide();
        }

        void ShowEditComponents()
        {
            ConfirmBtn.Show();
            TitleTextBox.Show();
            NoteTextRich.Show();
        }

        private void NoteElement_DoubleClick(object sender, EventArgs e)
        {
            //editNote.Text = "Редактирование";
            //editNote.mode = EditFormMode.Edit;
            //editNote.TitleTextBox.Text = this.note.Title;
            //editNote.NoteRichText.Text = this.note.Text;
            //editNote.ShowDialog();
            if (Controls.Contains(ConfirmBtn) && Controls.Contains(NoteTextRich) && Controls.Contains(TitleTextBox))
            {
                HideDefaultComponents();
                ShowEditComponents();
                Size = EditSize;

                TitleTextBox.Text = note.Title;
                NoteTextRich.Text = note.Text;
                return;
            }
            CreatEditComponents();
            TitleTextBox.Text = TitleLable.Text;
            NoteTextRich.Text = TextNoteRichTextBox.Text;
        }

        void CreatEditComponents()
        {
            Size = EditSize;
            TitleTextBox.Location = TitleLable.Location;
            if (TitleLable.Size.Width > Size.Width)
            {
                TitleTextBox.Size = new Size(Size.Height, Size.Width - 10);
            }
            else
            {
                TitleTextBox.Size = new Size(200, TitleLable.Size.Width);
            }
            TitleLable.Visible = false;

            NoteTextRich.Location = TextNoteRichTextBox.Location;
            NoteTextRich.Size = TextNoteRichTextBox.Size;
            TextNoteRichTextBox.Visible = false;

            ConfirmBtn.Location = new Point(NoteTextRich.Location.X, NoteTextRich.Location.Y + NoteTextRich.Size.Height + 20);
            ConfirmBtn.Size = new Size(100, 35);
            ConfirmBtn.Text = "Изменить";
            ConfirmBtn.BackColor = Color.White;

            Controls.Add(TitleTextBox);
            Controls.Add(NoteTextRich);
            Controls.Add(ConfirmBtn);
        }

        void ExceptChanges()
        {
            TitleLable.Text = note.Title;
            TextNoteRichTextBox.Text = note.Text;
        }
    }
}
