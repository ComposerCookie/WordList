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
    public partial class AddWordToList : Form
    {
        CurrencyManager cm;
        CurrencyManager cm2;
        List<Word> toAdd;

        public AddWordToList(int l)
        {
            InitializeComponent();

            toAdd = Editor.Instance.CurrentList.MiniList[l].MyList;

            lstBank.DataSource = Editor.Instance.CurrentList.MyList;
            lstBank.DisplayMember = "Name";

            lstWord.DataSource = toAdd;
            lstWord.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MyList];
            cm2 = (CurrencyManager)BindingContext[toAdd];

            
        }

        public void UpdateDatabase()
        {
            cm.Refresh();
            cm2.Refresh();
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            if (toAdd.Any(Word => Word.Name == Editor.Instance.CurrentList.MyList[lstBank.SelectedIndex].Name))
                return;

            toAdd.Add(new Word(Editor.Instance.CurrentList.MyList[lstBank.SelectedIndex].Name, Editor.Instance.CurrentList.MyList[lstBank.SelectedIndex].Definition, Editor.Instance.CurrentList.MyList[lstBank.SelectedIndex].Point, Editor.Instance.CurrentList.MyList[lstBank.SelectedIndex].Difficulty));
            UpdateDatabase();
            Editor.Instance.RefreshListForm();
        }

        private void buttRev_Click(object sender, EventArgs e)
        {
            toAdd.RemoveAt(lstWord.SelectedIndex);
            UpdateDatabase();
            Editor.Instance.RefreshListForm();
        }


    }
}
