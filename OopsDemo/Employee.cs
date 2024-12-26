using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class Employee
    {
        private int empid;
        private string ename;
        private double esal;
        
        private int yob;
        private int age;

        public int EmployeeID { 
            get { return empid; } 
            set { empid = value; } 
        }
        public string Ename { get { return ename; } set { ename = value; } }
        public double Esal { get { return esal; } set { esal = value; } }

        public int Yob
        {
            set
            {
                yob = value;
                if (age <= 18)
                {
                    Console.WriteLine("You are a minor");
                }
                else
                {
                    age = 2024 - yob;
                }
            }


        }
        public string getEmpDetails()
        {
            return $"{ename} is working with salary of {esal} in the age {age}";
        }
    }
}
