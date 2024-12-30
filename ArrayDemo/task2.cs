using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
  class task2
    {

        public void stringArray()
        {
            string[] array = { "Apple", "Banana", "guava", "orange" };
            Console.WriteLine("Enter the fruit you want to search:");
            string input = Console.ReadLine();
            
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = array[i].ToLower();
                if (input.Equals(array[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{input} is present in your array");
                    break;
                }
                else
                {
                    Console.WriteLine($"{input} is not present");
                    break;
                }
                //Console.WriteLine(array[i]);
            }


            //int res = Array.IndexOf(array, input);
            //if (res != -1)
            //{
            //    Console.WriteLine($"{input} is present in your array");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not present");
            //}
        }
    }
}
