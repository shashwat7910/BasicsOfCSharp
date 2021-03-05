using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Arrays
    {
        public static void Do()
        {
            string[] students = new string[6] { "john", "doe", "shashwat", "singh", "ankit", "harshit" };
            foreach (string student in students)
                Console.WriteLine(student);
            string s = "my name is shashwat singh and i am an intern at teksystems";
            string[] array = s.Split();
            foreach (string a in array) Console.WriteLine(a);
            int[] marks = new int[5];
            marks[0] = 44;
            marks[1] = 43;
            marks[2] = 42;
            marks[3] = 41;
            marks[4] = 40;
            int total = 0;
            foreach (int x in marks) total += x;
            Console.WriteLine("Total marks " + total);

        }
    }
}
