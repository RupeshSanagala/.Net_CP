using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class MathMethods
    {
        double num1;
        double num2;
        
        public void tryMathMethods(double num1,
        double num2)
        {
            Console.WriteLine(Math.Floor(num1));
            Console.WriteLine(Math.Ceiling(num1));
            Console.WriteLine(Math.Abs(num2));
            Console.WriteLine(Math.Round(num1));
            Console.WriteLine(Math.Abs(Math.Round(num2)));
            Console.WriteLine(Math.Pow(num1, 2));
            Console.WriteLine(Math.Sqrt(num1 - num2));
            Console.WriteLine(Math.Min(num1, num2));    
            Console.WriteLine(Math.Max(num1, num2));    
        }
    }
}
