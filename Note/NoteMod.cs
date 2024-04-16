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
        public int id_user { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public NoteClass()
        {

        }

        public NoteClass(string title, int id)
        {
            Title = title;
            id_user = id;
        }

        public NoteClass(string title, string text,int id)
        {
            Title = title;
            Text = text;
            id_user = id;
        }
    }
}
