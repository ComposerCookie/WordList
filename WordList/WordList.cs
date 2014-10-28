using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_WordList
{
    public class WordList
    {

        #region Field

        List<Word> _myList;
        List<WordList> _miniList;
        
        string _author;
        string _path;
        string _name;
        string _description;

        #endregion Field

        #region Constructor

        public WordList()
        {
            _myList = new List<Word>();
            _miniList = new List<WordList>();
            _author = "";
            _path = "";
            _name = "";
            _description = "";
        }

        public WordList(string name)
        {
            _myList = new List<Word>();
            _miniList = new List<WordList>();

            _name = name;
            _author = "";
            _path = "";
            _description = "";
        }

        public WordList(string name, string des)
        {
            _myList = new List<Word>();
            _miniList = new List<WordList>();

            _name = name;
            _author = "";
            _path = "";
            _description = des;
        }

        public WordList(string author, string path, string name, string des)
        {
            _myList = new List<Word>();
            _miniList = new List<WordList>();
            _author = author;
            _path = path;
            _name = name;
            _description = des;
        }

        #endregion Constructor

        #region Property

        public List<Word> MyList
        {
            get { return _myList; }
        }

        public List<WordList> MiniList
        {
            get { return _miniList; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion Property

        #region Method
        
            #region Checking

        public bool CheckExist(Word w)
        {
            return _myList.Contains(w);
        }

        public bool ListExist(WordList list)
        {
            return _miniList.Contains(list);
        }

        public bool CheckbyWord(string word)
        {
            return _myList.Any(Word => Word.Name == word);
        }

        public bool checkListByName(string listname)
        {
            return _miniList.Any(WordList => WordList.Name == listname);
        }

        public bool CheckbyDef(string def)
        {
            return _myList.Any(Word => Word.Definition == def);
        }

            #endregion Checking

            #region AddRemove

        public void addWord(Word w)
        {
            if (CheckExist(w))
                return;

            _myList.Add(w);
        }

        public void addWord(string name)
        {
            if (CheckbyWord(name))
                return;

            _myList.Add(new Word(name));
        }

        public void addWord(string name, string def)
        {
            if (CheckbyWord(name))
                return;

            _myList.Add(new Word(name, def));
        }

        public void addWord(string name, string def, int pt)
        {
            if (CheckbyWord(name))
                return;

            _myList.Add(new Word(name, def, pt));
        }

        public void addWord(string name, string def, int pt, int dif)
        {
            if (CheckbyWord(name))
                return;

            _myList.Add(new Word(name, def, pt, dif));
        }

        public void removeWord(Word w)
        {
            if (CheckExist(w))
                _myList.Remove(w);
        }

        public void removeWord(string name)
        {
            for (int i = 0; i < _myList.Count; i++)
            {
                if (_myList[i].Name == name)
                    _myList.RemoveAt(i);
            }

        }

        public void newMiniList(string name)
        {
            if (checkListByName(name))
                return;

            _miniList.Add(new WordList(name));
        }

        public void newMiniList(string name, string des)
        {
            if (checkListByName(name))
                return;

            _miniList.Add(new WordList(name, des));
        }

        public void addMiniList(WordList list)
        {
            if (ListExist(list))
                return;

            _miniList.Add(list);
        }

        public void removeMiniList(WordList list)
        {
            if (ListExist(list))
                _miniList.Remove(list);
        }

        public void removeMiniList(string name)
        {
            for (int i = 0; i < _miniList.Count; i++)
            {
                if (_miniList[i].Name == name)
                    _miniList.RemoveAt(i);
            }
        }

            #endregion AddRemove

            #region Flashcard Utility

        public Word getRandom()
        {
            Random rnd = new Random();
            return _myList[rnd.Next(_myList.Count)];
        }

            #endregion Flashcard Utility

            #region Sort

        public void Sort(int type)
        {
            switch (type)
            {
                case 0: //sort by alphabet ascending order
                    SortByAlpAsc();
                    break;

                case 1: //sort by alphabet descending order
                    SortByAlpDsc();
                    break;
            }
        }

        public void SortByAlpAsc()
        {

        }

        public void SortByAlpDsc()
        {

        }

            #endregion Sort

        #endregion Method
    }
}
