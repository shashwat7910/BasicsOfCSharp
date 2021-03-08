using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Interface
{
    class Teacher : IPerson
    {
        public string name { get; set; }
        public string address { get; set; }
        public DateTime dateofjoining { get; set; }
        public string getinfo()
        {
            return this.name + ", " + this.address + ", " + this.dateofjoining;
        }

        public string gettypeofperson()
        {
            return "Teacher" ;
        }
    }
}
