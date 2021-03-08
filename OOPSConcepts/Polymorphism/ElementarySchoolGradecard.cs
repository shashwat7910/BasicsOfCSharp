using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class ElementarySchoolGradecard : BasicGradeCard
    {
        public int maths { get; set; }
        public int english { get; set; }
        public int secondlanguage { get; set; }
        public int socialscience { get; set; }
        
        public ElementarySchoolGradecard()
        {
            this.maths = 0;
            this.english = 0;
            this.secondlanguage = 0;
            this.socialscience = 0;
        }
        public override int getTotalmarks()
        {
            return this.maths + this.english + this.secondlanguage + this.socialscience;
        }
    }
}
