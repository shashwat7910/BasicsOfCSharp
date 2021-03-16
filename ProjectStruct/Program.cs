using System;

namespace ProjectStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] t = new Teacher[3];
            string[] tname = new string[] { "Mr.x", "Mr. Y", "Mr. Z" };
            Student[] s = new Student[3];
            string[] sname = new string[] { "Ankit", "Shashwat", "Onkar" };
            Subject[] su = new Subject[3];
            string[] suname = new string[] { "Physics", "Biology", "Chemistry" };
            string[] sucode = new string[] { "001", "002", "003" };
            for(int i = 0; i < 3; i++)
            {
                t[i].Name = tname[i];
                t[i].ClassandSection = i.ToString();
                s[i].Name = sname[i];
                s[i].ClassandSection = i.ToString();
                su[i].NameOfSub = suname[i];
                su[i].SubjectCode = sucode[i];
            }
            Console.WriteLine("Student details are as follows");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name of Student - " + s[i].Name + ", " + "Class and section - " + s[i].ClassandSection);
            }
            Console.WriteLine("Teacher details are as follows");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name of Teacher - " + t[i].Name + ", " + "Class and section - " + t[i].ClassandSection);
            }
            Console.WriteLine("Subject details are as follows");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name of Subject - " + su[i].NameOfSub + ", " + "Subject code - " + su[i].SubjectCode);
            }
        }
    }
    struct Teacher
    {
        public string Name { get; set; }
        public string ClassandSection { get; set; }
    }
    struct Student
    {
        public string Name { get; set; }
        public string ClassandSection { get; set; }
    }
    struct Subject
    {
        public string NameOfSub { get; set; }
        public string SubjectCode { get; set; }
    }
}
