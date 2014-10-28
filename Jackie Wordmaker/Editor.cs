using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

using Jackie_s_WordList;
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using WeifenLuo.WinFormsUI.Docking;

namespace Jackie_Wordmaker
{
    public partial class Editor : Form
    {

        #region Field

        WordDatabase _wordDatabase;
        WordList _currentList;
        NewList _newList;
        WordBank _wordBank;
        ListForm _listForm;
        FlashcardTest _flashcardTest;
        Export _export;
        MultipleChoiceTest _mcTest;
        FillInTheBlankTest _fbTest;

        bool changeMade = false;

        List<Flashcard> _flashcards;

        static Editor _instance;

        #endregion Field

        #region Constructor

        public Editor()
        {
            InitializeComponent();

            _instance = this;

            _wordDatabase = new WordDatabase();

            _currentList = new WordList();

            _newList = new NewList();

            _wordBank = new WordBank();

            _flashcards = new List<Flashcard>();

            _listForm = new ListForm();

            _flashcardTest = new FlashcardTest();

            _export = new Export();

            _mcTest = new MultipleChoiceTest();

            _fbTest = new FillInTheBlankTest();

            GeneratePremade();

            OpenWordBank();
            

            DisableTool();
        }

        #endregion Constructor

        #region Property

        public static Editor Instance
        {
            get { return _instance; }
        }

        public WordList CurrentList
        {
            get { return _currentList; }
        }

        public List<Flashcard> FlashCard
        {
            get { return _flashcards; }
        }

        public bool ChangeMade
        {
            get { return changeMade; }
            set { changeMade = value; }
        }

        #endregion Property

        #region Method

        public void GeneratePremade()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\Premade1\List.jrpw"))
                return;

            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\Premade1");
            WordList premadeWordList = new WordList("Jackie", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\", "Premade1", "");

            PreMadeList.Premade(1, premadeWordList);
            SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\Premade1\List.jrpw", premadeWordList);
        }

        public void showAllFlashCard()
        {


            foreach (Flashcard f in _flashcards)
            {
                
                f.Show();
            }
        }

        public void showFlashCard(int which)
        {

            _flashcards[which].Show();
        }

        public void showFlashCard(Flashcard which)
        {
            
            which.Show();
        }

        public void ClearFlashCard()
        {
            _flashcards.Clear();
        }

        private void wordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _wordDatabase = new WordDatabase();

            _wordDatabase.Show(dockPanel1);
            _wordDatabase.UpdateDatabase();
            
        }

        public void OpenWordBank()
        {
            if (_wordBank.Visible != true)
            _wordBank.Show(dockPanel1, DockState.DockRight);
        }

        public void RefreshListForm()
        {
            _listForm.UpdateDatabase();
        }

        public void RefreshDatabaseList()
        {
            _wordDatabase.DatabaseUpdate();
            _wordBank.updateStatus();
            
        }

        private void CloseList()
        {
            _currentList = new WordList();

            DisableTool();
        }

        public void NewList(WordList wl)
        {
            CloseList();

            _currentList = wl;

            string _listPath = Path.Combine(_currentList.Path, _currentList.Name);

            Directory.CreateDirectory(_listPath);

            _listPath += "\\" + "List.jrpw";

            SaveFile(_listPath, _currentList);

            
            updateTitle();

            EnableTool();
        }

        public void OpenList()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = @"Select list file";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\";

                var result = dialog.ShowDialog(this);

                if (result != DialogResult.OK) return;

                var path = Path.GetDirectoryName(dialog.FileName);

                if (_currentList.Path == path)
                {
                    MessageBox.Show(@"The list is already open.", @"Error opening game");
                    return;
                }

                if (!File.Exists(path + @"\List.jrpw"))
                {
                    MessageBox.Show(@"Cannot find list file.", @"Error opening list");
                    return;
                }

                CloseList();

                _currentList = LoadFile(path + @"\List.jrpw");

                updateTitle();

                EnableTool();
            }
        }

        public void SaveList()
        {
            SaveFile(_currentList.Path + "\\" + _currentList.Name + "\\list.jrpw", _currentList);
            changeMade = false;
            updateTitle();
        }

        public void SaveFile(string path, WordList wl)
        {
            IO saving = new IO();
            saving.Save(path, wl);
        }

        public WordList LoadFile(string path)
        {
            IO loading = new IO();
            return loading.Load(path);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newList = new NewList();
            _newList.Show();
        }

        private void updateTitle()
        {
            if (changeMade == false)
                this.Text = "Jackie's Wordmaker: " + _currentList.Name;
            else
                this.Text = "*Jackie's Wordmaker: " + _currentList.Name;
        }

        public void DisableTool()
        {
            wordsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            listsToolStripMenuItem.Enabled = false;
            flashcardToolStripMenuItem.Enabled = false;
            printToolStripMenuItem.Enabled = false;
            multipleChoiceToolStripMenuItem.Enabled = false;
            fillInTheBlankToolStripMenuItem.Enabled = false;

            _wordBank.Detialize();
        }

        public void EnableTool()
        {
            wordsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            listsToolStripMenuItem.Enabled = true;
            flashcardToolStripMenuItem.Enabled = true;
            printToolStripMenuItem.Enabled = true;
            multipleChoiceToolStripMenuItem.Enabled = true;
            fillInTheBlankToolStripMenuItem.Enabled = true;

            _wordBank.Initialize();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveList();
        }

        private void wordsBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWordBank();
        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _listForm = new ListForm();
            _listForm.Initialize();
            _listForm.Show();
        }

        private void flashcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _flashcardTest = new FlashcardTest();
            _flashcardTest.Show();
        }


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _export = new Export();
            _export.Show();
        }

        #endregion Method

        private void multipleChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mcTest = new MultipleChoiceTest();
            _mcTest.Show();
        }

        private void fillInTheBlankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fbTest = new FillInTheBlankTest();
            _fbTest.Show();
        }

        
        

        

    }
}
