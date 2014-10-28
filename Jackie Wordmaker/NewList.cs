using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

using Jackie_s_WordList;

namespace Jackie_Wordmaker
{
    public partial class NewList : Form
    {
        WordList _newWordList;
        string _path;

        public WordList NewWordList
        {
            get { return _newWordList; }
        }

        public string Path
        {
            get { return _path; }
        }

        public NewList()
        {
            InitializeComponent();

            txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show(@"You must enter a name and location.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (Directory.Exists(System.IO.Path.Combine(txtLocation.Text, txtName.Text)))
            {
                MessageBox.Show(@"A project with this name already exists in this directory.", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            _newWordList = new WordList(txtAuthor.Text, txtLocation.Text, txtName.Text, txtDescription.Text);
            _path = txtLocation.Text;

            Editor.Instance.NewList(_newWordList);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = @"Select folder to create game in.";
                folderDialog.SelectedPath = txtLocation.Text;

                var folderResult = folderDialog.ShowDialog();

                if (folderResult == DialogResult.OK)
                {
                    txtLocation.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}
