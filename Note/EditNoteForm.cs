using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteModul;

namespace Note
{
    public partial class EditNoteForm : Form
    {
        bool isNotEmptyNote = false;
        public EditNoteForm()
        {
            InitializeComponent();
        }

        public bool IsNotEmptyNote { get => isNotEmptyNote;}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
