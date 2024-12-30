using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class task1
    {
        public void getElement()
        {
            int[] nums = { 51, 21, 36, 59, 18 };
            Console.WriteLine("Enter the element u want to search for:");
            int input = int.Parse(Console.ReadLine());
            bool isPresent = false;
            foreach (int i in nums)
            {
                if (i == input)
                {
                    isPresent = true;
                    Console.WriteLine($"yes,{input} is present in your array");
                    break;
                }
                else if (i != input)
                {
                    Console.WriteLine($"sorry,{input} is not found in your array");
                    break;
                }
            }
        }
    }
}
