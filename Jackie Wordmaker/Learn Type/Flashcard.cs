using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using Jackie_s_WordList;
using WeifenLuo.WinFormsUI.Docking;

namespace Jackie_Wordmaker
{
    public partial class Flashcard : Form
    {
        Word _word;

        bool def;

        public Flashcard(Word w)
        {
            InitializeComponent();

            _word = w;
            def = true;
            textBox1.Text = w.Name;
        }

        public Word word
        {
            get { return _word; }
        }

        private void FlipButt_Click(object sender, EventArgs e)
        {
            if (def != true)
                textBox1.Text = _word.Name;
            else
                textBox1.Text = _word.Definition;

            def = !def;
        }

        private void Flashcard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Editor.Instance.FlashCard.Remove(this);
        }
    }
}
