using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    [Serializable]
    public class NoteClass
    {
        int id_user;
        public string Title { get; set; }
        public string Text { get; set; }

        public NoteClass()
        {

        }

        public NoteClass(string title)
        {
            this.Title = title;
        }

        public NoteClass(string title, string text)
        {
            this.Title = title;
            this.Text = text;
        }
    }
}
