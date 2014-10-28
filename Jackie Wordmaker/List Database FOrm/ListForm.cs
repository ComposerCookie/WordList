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
    public partial class ListForm : Form
    {
        CurrencyManager cm;
        CurrencyManager cm2;
        List<WordList> _list;

        public ListForm()
        {
            InitializeComponent();      
            
                        
        }

        public void Initialize()
        {
            _list = Editor.Instance.CurrentList.MiniList;

            lstList.DataSource = Editor.Instance.CurrentList.MiniList;
            lstList.DisplayMember = "Name";



            cm = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MiniList];
        }

        public void UpdateDatabase()
        {
            cm.Refresh();
            UpdateWord();
            
        }

        public void UpdateWord()
        {
            lstWord.DataSource = Editor.Instance.CurrentList.MiniList[lstList.SelectedIndex].MyList;
            lstWord.DisplayMember = "Name";

            cm2 = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MiniList[lstList.SelectedIndex].MyList];
            cm2.Refresh();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            NewMiniList newList = new NewMiniList();
            newList.Show();
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this list?", "Are you serious?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                YesTheySure(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else

            }
        }

        public void YesTheySure(int x)
        {
            switch (x)
            {
                case 0:
                    if (Editor.Instance.CurrentList.MiniList.Count == 0)
                        return;

                    Editor.Instance.CurrentList.removeMiniList(Editor.Instance.CurrentList.MiniList[lstList.SelectedIndex]);
                    Editor.Instance.RefreshListForm();
                    break;

            }
        }

        private void buttDelW_Click(object sender, EventArgs e)
        {

        }

        private void buttAddW_Click(object sender, EventArgs e)
        {
            AddWordToList w = new AddWordToList(lstList.SelectedIndex);
            w.Show();
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            EditMiniList _edit = new EditMiniList(Editor.Instance.CurrentList.MiniList[lstList.SelectedIndex]);
            _edit.Show();
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWord();
        }
    }
}
