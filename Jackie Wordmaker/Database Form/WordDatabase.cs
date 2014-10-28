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
    public partial class WordDatabase : Form
    {
        NewWord _newWord;
        EditWord _editWord;

        CurrencyManager cm;

        public WordDatabase()
        {
            InitializeComponent();
        }

        public void UpdateDatabase()
        {
            txtDefinition.Text = "";
            
            listDatabase.DataSource = Editor.Instance.CurrentList.MyList;
            listDatabase.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MyList];

            UpdateDefinition();

            DatabaseUpdate();

        }

        public void DatabaseUpdate()
        {
            cm.Refresh();
            UpdateDefinition();
        }

        public void YesTheySure()
        {
            if (Editor.Instance.CurrentList.MyList.Count == 0)
                return;

            Editor.Instance.CurrentList.removeWord(Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex]);
            Editor.Instance.RefreshDatabaseList();
        }

        public void UpdateDefinition()
        {

            if (Editor.Instance.CurrentList.MyList.Count == 0)
                return;
            
            txtDefinition.Text = Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex].Definition;

            if (Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex].Difficulty == 0)
                lblDiff.Text = "Word Difficulty Level: Not yet rated";
            else
                lblDiff.Text = "Word Difficulty Level: " + Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex].Difficulty;

            if (Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex].Point == 0)
                lblPt.Text = "Word Difficulty Level: No point";
            else
                lblPt.Text = "Word's Point: " + Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex].Point;
        }

        private void listDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDefinition();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            _newWord = new NewWord();
            _newWord.Show();
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this word?", "Are you serious?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                YesTheySure();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                
            }
        }

        private void modifyButt_Click(object sender, EventArgs e)
        {
            _editWord = new EditWord(Editor.Instance.CurrentList.MyList[listDatabase.SelectedIndex]);
            _editWord.Show();
        }


    }
}
