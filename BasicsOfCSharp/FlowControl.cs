using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class FlowControl
    {
        public static void Flowc()
        {
            int a = 100;
            if (a == 100)
            {
                Console.WriteLine("value is 100");
            }
            else
                Console.WriteLine("value is not 100");
            int[] array = { 10, 20, 30, 40, 50 };
            foreach (var s in array)
                Console.WriteLine(s);
            int x = 10;
            do
            {
                Console.WriteLine(x);
            } while (x != 10);
        }
    }
}
