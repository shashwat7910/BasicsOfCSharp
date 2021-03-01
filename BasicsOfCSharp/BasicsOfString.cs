using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class BasicsOfString
    {
        public static void Do()
        {
            string mary = "mary had a little lamb";
            Console.WriteLine("clone of string = {0}", mary.Clone());
            Console.WriteLine("original string = {0}", mary);
            Console.WriteLine("Mary contains had? {0}", mary.Contains("had"));
            Console.WriteLine("Mary ends with xyz? {0}", mary.EndsWith("xyz"));
            string[] parts = mary.Split(" ");
            foreach(string s in parts)
            {
                Console.WriteLine(s);
            }
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 9; i++)
                sb.Append(i.ToString() + " ");
            Console.WriteLine(sb);

        }
    }
}
