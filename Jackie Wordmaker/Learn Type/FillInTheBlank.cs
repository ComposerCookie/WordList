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
    public partial class FillInTheBlank : Form
    {
        List<Word> myList;

        int currentQ = 0;
        int State = 0;
        int totalCorrect = 0;
        bool alreadyCorrected = false;

        public FillInTheBlank(List<Word> theList)
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
            txtDefinition.Text = w.Definition;
            txtWord.Text = "";

            lblCorrect.Text = "";

            alreadyCorrected = false;

            lblCA.Text = "";

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

            if (lblCorrect.Text.Equals("") && txtWord.Text.Equals(""))
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

        private void buttSubmit_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.Equals(myList[currentQ].Name))
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
                lblCA.Text = "Correct Answer: " + myList[currentQ].Name;
            }

            alreadyCorrected = true;
        }

        private void buttStart_Click(object sender, EventArgs e)
        {
            buttStart.Text = "Retry";
            totalCorrect = 0;
            State = 1;
            currentQ = 0;
            UpdateStatic();

            RandomizeList();
            setUp(myList[currentQ]);
        }


    }
}
