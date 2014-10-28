using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jackie_s_WordList;

namespace Jackie_Wordmaker
{
    public partial class FlashcardTest : Form
    {
        CurrencyManager cm;

        public FlashcardTest()
        {
            InitializeComponent();

            lstWords.DataSource = Editor.Instance.CurrentList.MiniList;
            lstWords.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MiniList];

            UpdateList();
            
        }

        public void UpdateList()
        {
            cm.Refresh();
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkAll_Click(object sender, EventArgs e)
        {
            chkAll.Checked = true;
            lstWords.Enabled = false;
            txtWords.Enabled = false;
            chkSpec.Checked = false;
            chkRan.Checked = false;
        }

        private void chkSpec_Click(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            lstWords.Enabled = true;
            UpdateList();

            txtWords.Enabled = false;
            chkSpec.Checked = true;
            chkRan.Checked = false;
        }

        private void chkRan_Click(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            lstWords.Enabled = false;
            txtWords.Enabled = true;
            chkSpec.Checked = false;
            chkRan.Checked = true;
        }

        private void startButt_Click(object sender, EventArgs e)
        {
            Editor.Instance.ClearFlashCard();

            if (chkAll.Checked == true)
            {
                foreach (Word w in Editor.Instance.CurrentList.MyList)
                {
                    Flashcard f = new Flashcard(w);
                    Editor.Instance.FlashCard.Add(f);
                }

                Editor.Instance.showAllFlashCard();
            }
            else if (chkSpec.Checked == true)
            {
                foreach (Word w in Editor.Instance.CurrentList.MiniList[lstWords.SelectedIndex].MyList)
                {
                    Flashcard f = new Flashcard(w);
                    Editor.Instance.FlashCard.Add(f);
                }
                Editor.Instance.showAllFlashCard();
            }
            else
            {
                if (string.IsNullOrEmpty(txtWords.Text))
                {
                    MessageBox.Show(@"You must enter a number", @"Error");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                int max = int.Parse(txtWords.Text);

                if (max > Editor.Instance.CurrentList.MyList.Count)
                    max = Editor.Instance.CurrentList.MyList.Count;

                Random r = new Random();
                List<int> intList = new List<int>();

                for (int i = 0; i < max; i++)
                {
                    int rand = r.Next(Editor.Instance.CurrentList.MyList.Count);
                    while (intList.IndexOf(rand) != -1)
                    {
                        rand = r.Next(Editor.Instance.CurrentList.MyList.Count);
                    }
                    intList.Add(rand);
                }

                foreach (int i in intList)
                {
                    Flashcard f = new Flashcard(Editor.Instance.CurrentList.MyList[i]);
                    Editor.Instance.FlashCard.Add(f);
                }

                Editor.Instance.showAllFlashCard();
            }
        }


    }
}
