using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie_s_WordList
{
    public class Word
    {

        #region Field

        string _name;
        string _definition;

        int _point;
        int _difficulty;

        #endregion Field

        #region Constructor

        public Word()
        {
        }

        public Word(string name)
        {
            _name = name;
        }

        public Word(string name, string def)
        {
            _name = name;
            _definition = def;
        }

        public Word(string name, string def, int pt)
        {
            _name = name;
            _definition = def;
            _point = pt;
        }

        public Word(string name, string def, int pt, int dif)
        {
            _name = name;
            _definition = def;
            _point = pt;
            _difficulty = dif;
        }

        #endregion Constructor

        #region Property

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Definition
        {
            get { return _definition; }
            set { _definition = value; }
        }

        public int Point
        {
            get { return _point; }
            set { _point = value; }
        }

        public int Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; }
        }

        #endregion Property
    }
}
