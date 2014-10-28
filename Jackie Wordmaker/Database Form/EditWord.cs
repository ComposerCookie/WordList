using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

using Jackie_s_WordList;

namespace Jackie_Wordmaker
{
    public partial class EditWord : Form
    {
        Word word;

        public EditWord(Word w)
        {
            InitializeComponent();

            word = w;

            txtName.Text = w.Name;
            txtDefinition.Text = w.Definition;
            txtDiff.Text = w.Difficulty.ToString();
            txtPt.Text = w.Point.ToString();
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

        private void saveButt_Click(object sender, EventArgs e)
        {
            word.Name = txtName.Text;
            word.Definition = txtDefinition.Text;

            int pt, dif;

            if (txtPt.Text != "")
                pt = int.Parse(txtPt.Text);
            else
                pt = 0;

            if (txtPt.Text != "")
                dif = int.Parse(txtDiff.Text);
            else
                dif = 0;

            word.Point = pt;
            word.Difficulty = dif;

            Editor.Instance.RefreshDatabaseList();
            
            this.Close();
        }


    }
}
