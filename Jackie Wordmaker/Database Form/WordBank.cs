using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;
using Jackie_s_WordList;

namespace Jackie_Wordmaker
{
    public partial class WordBank : DockContent
    {
        CurrencyManager cm;
       
        public WordBank()
        {
            InitializeComponent();

            
        }

        public void Detialize()
        {
            listDatabase.DataSource = null;
            listDatabase.DisplayMember = null;

            cm = null;
        }

        public void Initialize()
        {

            listDatabase.DataSource = Editor.Instance.CurrentList.MyList;
            listDatabase.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MyList];

            updateStatus();
        }

        public void updateStatus()
        {
            cm.Refresh();
        }

        private void listDatabase_DoubleClick(object sender, EventArgs e)
        {

            Flashcard flash = new Flashcard(Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex]);

            if (Editor.Instance.FlashCard.Any(Flashcard => Flashcard.word.Name == flash.word.Name))
                return;

            Editor.Instance.FlashCard.Add(flash);
            Editor.Instance.showFlashCard(flash);
            
        }
    }
}
