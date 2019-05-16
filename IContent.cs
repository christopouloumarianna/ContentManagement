using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContentManagement
{
    public interface IContent
    {
        int CountWords();
        string GetLengthiestWord();
        bool LoadText(string fileName);
        bool SaveText(string fileName);
    }
    public class SimpleText : IContent
    {
        List<string> sentences = new List<string>();

        public SimpleText()
        {
            sentences.Add("flag");

        }

        public SimpleText(List<string> sentences)
        {
            this.sentences = sentences;
        }

        public int CountWords()
        {
            int NumberOfWords = 0;
            foreach (string sent in sentences)
            {
                string[] words = sent.Split(" ");
                NumberOfWords += words.Length;

            }
            return NumberOfWords;

        }

        public string GetLengthiestWord()
        {
            string biggest = null;
            int NumberOfWords = 0;
            foreach (string sent in sentences)
            {
                string[] words = sent.Split(" ");
                NumberOfWords += words.Length;


                foreach (string w in words)

                {

                    if (biggest.Length < w.Length)

                    {

                        biggest = w;

                    }

                }

            }
            return biggest;

        }
        public bool LoadText(string fileName)

        {

            try

            {
                var list = new List<string>();

                var fileStream = new FileStream

                    (@"file1.txt", FileMode.Open, FileAccess.Read);

                using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileStream,
                                                                                        Encoding.UTF8))

                {

                    string line;

                    while ((line = streamReader.ReadLine()) != null)

                    {

                        list.Add(line);

                    }

                }
                foreach (String s in list)

                {

                    Console.WriteLine("----------------");

                    Console.WriteLine(s);
                }

            }

            catch (Exception)

            {

                return false;

            }
            return true;

        }




        public bool SaveText(string fileName)
        {
            throw new NotImplementedException();
        }
    }

}

