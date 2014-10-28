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
    public partial class MultipleChoice : Form
    {
        List<Word> myList;
        
        int currentQ = 0;
        int correctA;
        int personA;
        int State = 0;
        int totalCorrect = 0;
        bool alreadyCorrected = false;

        bool qisword = false;

        public MultipleChoice(List<Word> theList)
        {
            InitializeComponent();

            myList = new List<Word>();

            foreach (Word w in theList)
                myList.Add(w);

            UpdateStatic();
        }

        public void UpdateStatic()
        {
            if (State == 0)
            {
                lblNumCor.Text = "";
                lblPercentage.Text = "";
                lblQ.Text = "";
            }

            if (State > 0)
            {
                lblNumCor.Text = totalCorrect + "/" + myList.Count;
                lblPercentage.Text = ((totalCorrect * 100) / myList.Count) + "%";
                lblQ.Text = "" + currentQ;
            }
        }

        public void setUp(Word w)
        {
            Random r = new Random();

            int truefalse = r.Next(2);
            if (truefalse == 0)
                qisword = true;
            else
                qisword = false;

            List<int> intList = new List<int>();
            int correctPos = r.Next(4);

            for (int i = 0; i < 3; i++)
            {
                int rand = r.Next(Editor.Instance.CurrentList.MyList.Count);
                while (intList.IndexOf(rand) != -1)
                {
                    rand = r.Next(Editor.Instance.CurrentList.MyList.Count);
                }
                intList.Add(rand);
            }

            if (qisword)
            {
                txtQuestion.Text = w.Name;            

                switch (correctPos)
                {
                    case 0:
                        txtA.Text = w.Definition;
                        txtB.Text = Editor.Instance.CurrentList.MyList[intList[0]].Definition;
                        txtC.Text = Editor.Instance.CurrentList.MyList[intList[1]].Definition;
                        txtD.Text = Editor.Instance.CurrentList.MyList[intList[2]].Definition;

                        break;
                    case 1:
                        txtA.Text = Editor.Instance.CurrentList.MyList[intList[0]].Definition;
                        txtB.Text = w.Definition;
                        txtC.Text = Editor.Instance.CurrentList.MyList[intList[1]].Definition;
                        txtD.Text = Editor.Instance.CurrentList.MyList[intList[2]].Definition;

                        break;
                    case 2:
                        txtA.Text = Editor.Instance.CurrentList.MyList[intList[0]].Definition;
                        txtB.Text = Editor.Instance.CurrentList.MyList[intList[1]].Definition;
                        txtC.Text = w.Definition;
                        txtD.Text = Editor.Instance.CurrentList.MyList[intList[2]].Definition;

                        break;
                    case 3:
                        txtA.Text = Editor.Instance.CurrentList.MyList[intList[0]].Definition;
                        txtB.Text = Editor.Instance.CurrentList.MyList[intList[1]].Definition;
                        txtC.Text = Editor.Instance.CurrentList.MyList[intList[2]].Definition;
                        txtD.Text = w.Definition;

                        break;
                }
                    
            }

            else
            {
                txtQuestion.Text = w.Definition;

                switch (correctPos)
                {
                    case 0:
                        txtA.Text = w.Name;
                        txtB.Text = Editor.Instance.CurrentList.MyList[intList[0]].Name;
                        txtC.Text = Editor.Instance.CurrentList.MyList[intList[1]].Name;
                        txtD.Text = Editor.Instance.CurrentList.MyList[intList[2]].Name;

                        break;
                    case 1:
                        txtA.Text = Editor.Instance.CurrentList.MyList[intList[0]].Name;
                        txtB.Text = w.Name;
                        txtC.Text = Editor.Instance.CurrentList.MyList[intList[1]].Name;
                        txtD.Text = Editor.Instance.CurrentList.MyList[intList[2]].Name;

                        break;
                    case 2:
                        txtA.Text = Editor.Instance.CurrentList.MyList[intList[0]].Name;
                        txtB.Text = Editor.Instance.CurrentList.MyList[intList[1]].Name;
                        txtC.Text = w.Name;
                        txtD.Text = Editor.Instance.CurrentList.MyList[intList[2]].Name;

                        break;
                    case 3:
                        txtA.Text = Editor.Instance.CurrentList.MyList[intList[0]].Name;
                        txtB.Text = Editor.Instance.CurrentList.MyList[intList[1]].Name;
                        txtC.Text = Editor.Instance.CurrentList.MyList[intList[2]].Name;
                        txtD.Text = w.Name;

                        break;
                }
            }

            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = false;
            chkD.Checked = false;

            lblCorrect.Text = "";

            alreadyCorrected = false;

            personA = -1;

            correctA = correctPos;
        }

        public void RandomizeList()
        {
            List<Word> tempList = new List<Word>();
            foreach (Word w in myList)
                tempList.Add(w);

            myList = new List<Word>();

            Random r = new Random();
            List<int> intList = new List<int>();

            for (int i = 0; i < tempList.Count; i++)
            {
                int rand = r.Next(tempList.Count);
                while (intList.IndexOf(rand) != -1)
                    rand = r.Next(tempList.Count);

                intList.Add(rand);
            }

            for (int i = 0; i < tempList.Count; i++)
            {
                myList.Add(tempList[intList[i]]);
            }
        }

        private void buttNext_Click(object sender, EventArgs e)
        {
            if (State == 0)
                return;

            if (lblCorrect.Text.Equals("") && personA < 0)
            {
                DialogResult dialogResult = MessageBox.Show("You haven't answered yet, do you want to skip? You can't go back and it will be counted as wrong", "Are you serious?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    if (currentQ == myList.Count)
                    {
                        MessageBox.Show(@"It's over :P You are at the last question", @"Error");
                        DialogResult = DialogResult.Cancel;
                        return;
                    }

                    currentQ++;
                    setUp(myList[currentQ]);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    return;
                }
            }

            if (currentQ == myList.Count)
            {
                MessageBox.Show(@"It's over :P You are at the last question", @"Error");
                DialogResult = DialogResult.Cancel;
                return;
            }

            currentQ++;
            UpdateStatic();
            setUp(myList[currentQ]);
        }

        private void chkA_Click(object sender, EventArgs e)
        {
            chkA.Checked = true;
            chkB.Checked = false;
            chkC.Checked = false;
            chkD.Checked = false;

            personA = 0;
        }

        private void chkB_Click(object sender, EventArgs e)
        {
            chkA.Checked = false;
            chkB.Checked = true;
            chkC.Checked = false;
            chkD.Checked = false;

            personA = 1;
        }

        private void chkC_Click(object sender, EventArgs e)
        {
            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = true;
            chkD.Checked = false;

            personA = 2;
        }

        private void chkD_Click(object sender, EventArgs e)
        {
            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = false;
            chkD.Checked = true;

            personA = 3;
        }

        private void buttStart_Click(object sender, EventArgs e)
        {
            buttStart.Text = "Retry";
            totalCorrect = 0;
            State = 1;
            currentQ = 0;
            UpdateStatic();

            chkA.Enabled = true;
            chkB.Enabled = true;
            chkC.Enabled = true;
            chkD.Enabled = true;

            RandomizeList();
            setUp(myList[currentQ]);
        }

        private void buttSubmit_Click(object sender, EventArgs e)
        {
            if (personA == correctA)
            {
                lblCorrect.Text = "CORRECT!";
                if (alreadyCorrected != true)
                    totalCorrect++;
                
                UpdateStatic();
            }
            else
            {
                lblCorrect.Text = "FALSE!";
                UpdateStatic();
            }

            alreadyCorrected = true;
        }
    }
}
