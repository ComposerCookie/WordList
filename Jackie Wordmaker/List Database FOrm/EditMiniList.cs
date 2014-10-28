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
    public partial class EditMiniList : Form
    {
        WordList w;
        public EditMiniList(WordList wl)
        {
            InitializeComponent();
            txtName.Text = wl.Name;
            txtDescription.Text = wl.Description;
            w = wl;
        }

        private void buttModify_Click(object sender, EventArgs e)
        {
            w.Name = txtName.Text;
            w.Description = txtDescription.Text;
            Editor.Instance.RefreshListForm();
            Close();
        }

        private void EditMiniList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Editor.Instance.RefreshListForm();
        }
    }
}
