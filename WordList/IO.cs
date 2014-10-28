using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Jackie_s_WordList
{
    public class IO
    {
        BinaryReader br;
        BinaryWriter bw;

        public IO()
        {
            
        }

        public WordList Load(string path)
        {
            WordList wl = new WordList();

            
            using (br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                wl.Name = br.ReadString();
                wl.Path = br.ReadString();
                wl.Author = br.ReadString();
                wl.Description = br.ReadString();

                int max = br.ReadInt32();

                for (int i = 0; i < max; i++)
                {
                    Word newWord = new Word();
                    newWord.Name = br.ReadString();
                    newWord.Definition = br.ReadString();
                    newWord.Difficulty = br.ReadInt32();
                    newWord.Point = br.ReadInt32();

                    wl.MyList.Add(newWord);
                }

                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    WordList newWordList = new WordList();
                    newWordList.Name = br.ReadString();
                    newWordList.Description = br.ReadString();
                    int secondmax = br.ReadInt32();

                    for (int s = 0; s < secondmax; s++)
                    {
                        Word newWord = new Word();
                        newWord.Name = br.ReadString();
                        newWord.Definition = br.ReadString();
                        newWord.Difficulty = br.ReadInt32();
                        newWord.Point = br.ReadInt32();

                        newWordList.addWord(newWord);
                    }

                    wl.MiniList.Add(newWordList);
                   
                }
            }


            return wl;
        }

        public void Save(string path, WordList wl)
        {

            using (bw = new BinaryWriter(File.Open(path , FileMode.Create)))
            {
                bw.Write(wl.Name);
                bw.Write(wl.Path);
                bw.Write(wl.Author);
                bw.Write(wl.Description);

                //Keep this below everything for simplicity plz

                bw.Write(wl.MyList.Count);

                foreach (Word w in wl.MyList)
                {
                    bw.Write(w.Name);
                    bw.Write(w.Definition);
                    bw.Write(w.Difficulty);
                    bw.Write(w.Point);
                }

                bw.Write(wl.MiniList.Count);

                foreach (WordList mwl in wl.MiniList)
                {
                    bw.Write(mwl.Name);
                    bw.Write(mwl.Description);
                    bw.Write(mwl.MyList.Count);
                    foreach (Word w in mwl.MyList)
                    {
                        bw.Write(w.Name);
                        bw.Write(w.Definition);
                        bw.Write(w.Difficulty);
                        bw.Write(w.Point);
                    }
                }
            }

        }
    }
}
