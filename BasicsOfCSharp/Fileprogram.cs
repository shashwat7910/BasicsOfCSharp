using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasicsOfCSharp
{
    class Fileprogram
    {
        public static void Do()
        {

            WriteText();
            ReadText();

        }
        private static void WriteText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (File.Exists(filename))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File doesn't exist");
            StreamWriter w = File.CreateText(filename);
            w.WriteLine("shashwat 22 maths");
            w.WriteLine("ankit 22 physics");
            w.WriteLine("onkar 22 chemistry");
            w.Close();


        }
        private static void ReadText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (!File.Exists(filename))
                Console.WriteLine("File does not Exist");
            else
            {
                Console.WriteLine("File exists");
                string content = File.ReadAllText(filename);
                Console.WriteLine(content);
            }
        }
    }
}
