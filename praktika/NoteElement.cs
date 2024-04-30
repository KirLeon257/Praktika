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
        public NoteClass Note;
        public MainForm Form;
        Color DefaultColor;
        Size EditSize, DefSize;
        TextBox TitleTextBox;
        RichTextBox NoteTextRich;
        public Button ConfirmBtn,EditFormBtn;

        public NoteElement(NoteClass note, MainForm form)
        {
            InitializeComponent();
            this.Note = note;
            TitleLable.Text = note.Title;
            TextNoteRichTextBox.Text = note.Text;
            Form = form;
            DefaultColor = this.BackColor;
            DefSize = Size;
            EditSize = new Size(DefSize.Width, DefSize.Height + 50);
            TitleTextBox = new TextBox();
            TitleTextBox.Modified = true;
            NoteTextRich = new RichTextBox();
            NoteTextRich.Modified = true;
            ConfirmBtn = new Button();
            EditFormBtn = new Button();
            ConfirmBtn.Click += ConfirmBtn_Click;
            EditFormBtn.Click += EditFormBtn_Click;
        }

        private void EditFormBtn_Click(object sender, EventArgs e)
        {
            NoteEditForm editForm = new NoteEditForm(this);
            editForm.Text = "Редактирование";
            editForm.Mode = NoteEditForm.EditFormMode.Edit;
            editForm.ShowDialog();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Length == 0 && NoteTextRich.Text.Length != 0)
            {
                Note.Title = "Нет названия";
                Note.Text = NoteTextRich.Text;
                ExceptChanges();
            }
            else if (TitleTextBox.Text.Length != 0 && NoteTextRich.Text.Length != 0)
            {
                Note.Title = TitleTextBox.Text;
                Note.Text = NoteTextRich.Text;
                ExceptChanges();
            }
            else if(TitleTextBox.Text.Length == 0 && NoteTextRich.Text.Length == 0)
            {
                if (MessageBox.Show($"Вы хотите удалить заметку {TitleLable.Text}", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    удалитьToolStripMenuItem.PerformClick();
                }
            }
            
            HideEditComponents();
            ShowDefaultComponents();

            Size = DefSize;
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

        public Size GetDefaultSize()
        {
            return DefSize;
        }

        public void HideDefaultComponents()
        {
            TitleLable.Hide();
            TextNoteRichTextBox.Hide();
        }

        public void ShowDefaultComponents()
        {
            TitleLable.Show();
            TextNoteRichTextBox.Show();
        }

        public void HideEditComponents()
        {
            ConfirmBtn.Hide();
            EditFormBtn.Hide();
            TitleTextBox.Hide();
            NoteTextRich.Hide();
        }

        public void ShowEditComponents()
        {
            ConfirmBtn.Show();
            EditFormBtn.Show();
            TitleTextBox.Show();
            NoteTextRich.Show();
        }

        private void NoteElement_DoubleClick(object sender, EventArgs e)
        {
            if (Controls.Contains(ConfirmBtn) && Controls.Contains(NoteTextRich) && Controls.Contains(TitleTextBox))
            {
                HideDefaultComponents();
                ShowEditComponents();
                Size = EditSize;

                TitleTextBox.Text = Note.Title;
                NoteTextRich.Text = Note.Text;
                return;
            }
            CreatEditComponents();
            TitleTextBox.Text = TitleLable.Text;
            NoteTextRich.Text = TextNoteRichTextBox.Text;


            //NoteEditForm = new NoteEditForm(this);
            //NoteEditForm.Mode = NoteEditForm.EditFormMode.Edit;
            //NoteEditForm.Text = "Редактирование";
            //NoteEditForm.ShowDialog();
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

            EditFormBtn.Location = new Point(ConfirmBtn.Location.X + ConfirmBtn.Size.Width + 20, ConfirmBtn.Location.Y);
            EditFormBtn.Size = ConfirmBtn.Size;
            EditFormBtn.Text = "Больше...";
            EditFormBtn.BackColor = Color.White;

            Controls.Add(TitleTextBox);
            Controls.Add(NoteTextRich);
            Controls.Add(ConfirmBtn);
            Controls.Add(EditFormBtn);
        }

        public void ExceptChanges()
        {
            TitleLable.Text = Note.Title;
            TextNoteRichTextBox.Text = Note.Text;
        }
    }
}
