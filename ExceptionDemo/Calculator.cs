using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Calculator
    {
        public void Add(int a , int b)
        {
            int res = a + b;
            Console.WriteLine(a + ", " + b+" "+"="+ res);
        }
        public void sub(int a, int b)
        {
            {
                int res = a - b;
                Console.WriteLine(a + ", " + b + " " + "=" + res);
            }
        }
    }
}
