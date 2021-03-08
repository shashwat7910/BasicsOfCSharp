using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class BasicGradeCard
    {
        protected int totalmarks;
        public BasicGradeCard()
        {
            totalmarks = 0;
        }
        public virtual int getTotalmarks()
        {
            return totalmarks;
        }
    }
}
