using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class Student
    {
        public int sid;
        public string sname;
        public static string collegename = "Bharath University";
        public const int noOfSems = 8;

        public Student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }

        public string GetStudentDetails()
        {
            return $"{sname} is studying in {Student.collegename}";
        }
       
}
}
