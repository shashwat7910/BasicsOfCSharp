using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasicsOfCSharp
{
    class Fileprogram2
    {
        public static void Do()
        {
            ReadText();
        }
        public static void ReadText()
        {
            string dir = "C:\\Users\\shassingh\\Desktop\\git";
            string path = dir + "\\files.txt";
            string[] arr = File.ReadAllLines(path);
            foreach(string s in arr)
            {
                string[] arr2 = s.Split(" ");
                Console.Write("Name: " + arr2[0]+" " + "Age: " + arr2[1]+" " + "Department: " + arr2[2]);
                Console.Write("\n");
            }
        }
    }
}
