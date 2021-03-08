using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.LessonEnd
{
    class Student:Person
    {
        public string Name { get; set; }

        public int Class { get; set; }
        public string Section { get; set; }
     

        public string getinfo()
        {
            return this.Name + ", " + this.Class + ", " + this.Section;
        }

        public string gettypeofperson()
        {
            return "Student";
        }
    }
}
