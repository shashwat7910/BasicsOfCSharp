using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class Polymorphismprogram
    {
        public static void Do()
        {
            ElementarySchoolGradecard e = new ElementarySchoolGradecard();
            e.maths = 90;
            e.english = 89;
            e.socialscience = 78;
            e.secondlanguage = 87;
            Console.WriteLine("Total marks=" + e.getTotalmarks());

            Middleschoolgradecard m = new Middleschoolgradecard();
            m.english = 78;
            m.secondlanguage = 89;
            m.geography = 77;
            m.history = 84;
            m.maths = 92;
            Console.WriteLine("Total marks=" + m.getTotalmarks());
        }
    }
}
