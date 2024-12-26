using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student:iPerson,IAddress
    {
        public int rollno;
        public string name { get; set; }
        public char gender { get; set; }

        public string pname { get; set; }
        public char pgender { get; set; }

        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }

        public string getPersonDetails()
        {
            return $"{pname} gender is {pgender}";
        }

        public string getAddress()
        {
            return $"{city} is in {state} with zipcode {zipCode}";
        }
        public static int id = 0;
        public static int incrementid()
        {
            return ++id;
        }
        

        public void displayDetails(int rollno = 0, string name = "", char gender = ' ')
        {
            if (rollno > 0)
            {
                Console.WriteLine("Roll No:" + rollno);
            }
            if (name != null)
            {
                Console.WriteLine("name of student" + name);
            }
            if (gender != 0)
            {
                Console.WriteLine("Gender is:" + gender);
            }
        }
    }
}
