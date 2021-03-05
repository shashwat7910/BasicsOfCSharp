using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linkedlists
{
    class DLnode
    {
        private string data;
        private DLnode next = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public DLnode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public DLnode Prev { get; set; }
    }
}
