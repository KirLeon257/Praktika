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

        public string Title { get; set; }
        public string Text { get; set; }
        public string FontInfo { get; set; }

        public NoteClass()
        {

        }

        public NoteClass(string text)
        {
            Text = text;
            Title = "Нет названия";
        }

        public NoteClass(string text, string title)
        {
            if (title == "")
            {
                Title = "Нет названия";
            }
            else
            {
                Title = title;
            }
            Text = text;

        }
    }
}
