using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsTasks
{
    class person
    {
        protected string pname { get; set; }

        public person(string Name)
        {
            Name = pname;

        }

        public override string ToString()
        {
            return $"The name of the person is :" + pname;

        }
    }

    class Student:person {
    
        public void Study()
        {
            Console.WriteLine("Student is Studying");
        }

        public Student(string Name) : base(Name)
        {
            Name =  pname;
        }



    }
    class Teacher:person {

        public Teacher(string Name) : base(Name)
        {
            Name = pname;
        }
        public void Explain()
        {
            Console.WriteLine("Teacher is Explaining");
        }
    }
}
