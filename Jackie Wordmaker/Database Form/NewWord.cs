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
    public partial class NewWord : Form
    {

        public NewWord()
        {
            InitializeComponent();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            int pt;
            int dif;

            if (txtPt.Text != "")
                pt = int.Parse(txtPt.Text);
            else
                pt = 0;

            if (txtPt.Text != "")
                dif = int.Parse(txtDiff.Text);
            else
                dif = 0;

            Editor.Instance.CurrentList.addWord(txtName.Text, txtDefinition.Text, pt, dif);
            Editor.Instance.RefreshDatabaseList();

            this.Close();
        }

        private void txtDiff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
