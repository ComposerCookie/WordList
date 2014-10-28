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
    public partial class NewMiniList : Form
    {
        public NewMiniList()
        {
            InitializeComponent();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(@"You must enter a name", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            Editor.Instance.CurrentList.MiniList.Add(new WordList(txtName.Text, txtDescription.Text));
            Editor.Instance.RefreshListForm();

            this.Close();
        }
    }
}
