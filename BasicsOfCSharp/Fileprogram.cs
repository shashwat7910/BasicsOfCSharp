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
            w.WriteLine("Name: shashwat; Age: 22; Dept: maths");
            w.WriteLine("Name: ankit; Age: 22 ; Dept: physics");
            w.WriteLine("Name: onkar; Age: 22; Dept: chemistry");
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
                string[] content = File.ReadAllLines(filename);
                for(int i = 1; i < content.Length - 1; i++)
                {
                    for(int j = 0; j < content.Length - 1 - i; j++)
                    {
                        if(content[j+1].CompareTo(content[j])<0)
                        {
                            string temp = content[j];
                            content[j] = content[j + 1];
                            content[j + 1] = temp;
                        }
                    }
                }
                foreach (string line in content) Console.WriteLine(line);
                Console.WriteLine("Enter record to search");
                string input = Console.ReadLine();
                bool flag = true;
                foreach(string line in content)
                {
                    if (line.Contains(input))
                    {
                        Console.WriteLine(line);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    Console.WriteLine("Record not found");
                
            }
        }
    }
}
