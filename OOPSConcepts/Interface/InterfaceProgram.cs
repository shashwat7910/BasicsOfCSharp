using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Interface
{
    class InterfaceProgram
    {
        public static void Do()
        {
            Teacher t = new Teacher();
            t.dateofjoining = DateTime.Today;
            t.address = "Mumbai";
            t.name = "MR. Onkar";
            Console.WriteLine(t.getinfo() + "\n" + t.gettypeofperson());
            Student s = new Student();
            s.name = "Shashwat";
            s.dateofjoining = DateTime.Today;
            s.address = "Pune";
            Console.WriteLine(s.getinfo() + "\n" + s.gettypeofperson());

        }
    }
}
