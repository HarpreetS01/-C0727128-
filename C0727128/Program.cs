using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Assignment
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {

            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();
        }

        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {

            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("Beowulf.txt"))
            {

                int counter = 0;                //section A

                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();

                counter = File.ReadLines("Beowulf.txt").Count();

                Console.WriteLine("\n This file contains " + counter + " lines");
            }
        }

        public int FindNumberOfBlankeSpaces(string line)
        {

            // https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
            
        }

    }
}
