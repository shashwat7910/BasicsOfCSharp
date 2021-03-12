using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhaseEnd
{
    class FileProgram3
    {
        public static void Do()
        {

            WriteText();
            ReadText();
            Update();
            Console.WriteLine("After updates");
            ReadText();

        }
        private static void WriteText()
        {
            string dir = "C:\\Users\\shassingh\\Desktop";
            string filename = dir + "\\TeacherRecords.txt";
            if (File.Exists(filename))
                Console.WriteLine("File Exists");
            else
            {
                Console.WriteLine("File doesn't exist");
                StreamWriter w = File.CreateText(filename);
                w.WriteLine("Walter 56 Physics 001");
                w.WriteLine("Andrew 48 ML 002");
                w.WriteLine("Tim 53 Java 003");
                w.Close();
            }
        }
        private static void ReadText()
        {
            string dir = "C:\\Users\\shassingh\\Desktop";
            string path = dir + "\\TeacherRecords.txt";
            string[] arr = File.ReadAllLines(path);
            Console.WriteLine("The Records of Teachers are as follows");
            foreach (string s in arr)
            {
                string[] arr2 = s.Split(" ");
                Console.Write("Name: " + arr2[0] + "; " + "Age: " + arr2[1] + "; " + "Department: " + arr2[2] + "; " + "Id: " + arr2[3]);
                Console.Write("\n");
            }
        }
        private static void Update()
        {
            Console.WriteLine("Enter the Id");
            string name = Console.ReadLine();
            string dir = "C:\\Users\\shassingh\\Desktop";
            string path = dir + "\\TeacherRecords.txt";
            StreamWriter w = new StreamWriter("newfile");
            int count = 0;
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("Press A for updating all attributes");
            Console.WriteLine("Press B for updating a specific attribute");
            string choice = Console.ReadLine();
            string[] attributes = new string[] { "Name", "Age", "Department", "Id" };
            if (choice.Equals("A"))
            {
                foreach (string s in lines)
                {
                    if (s.Contains(name))
                    {
                        Console.WriteLine("Enter new details separated by space");
                        string record = Console.ReadLine();
                        lines[count] = record;
                    }
                    else
                        count++;
                }
                File.WriteAllLines(path, lines);
            }
            else
            {
                Console.WriteLine("Enter the attribute you want to update");
                string attribute = Console.ReadLine();
                int j = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (attributes[i].Equals(attribute))
                    {
                        j = i;
                        break;
                    }
                }
                Console.WriteLine("Enter the new value");
                string updatedvalue = Console.ReadLine();
                for(int i=0;i<lines.Length;i++)
                {
                    if (lines[i].Contains(name))
                    {
                        string[] array = lines[i].Split(" ");
                        array[j] = updatedvalue;
                        lines[i] = array[0]+" "+array[1]+" "+array[2]+" "+array[3];
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }
    }
}
