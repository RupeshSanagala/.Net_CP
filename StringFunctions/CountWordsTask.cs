using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class CountWordsTask
    {

        public void CountWords()
        {
            string input = "She sells sea shells on the sea shore";

            string[] arr = input.Split(" ");
            Console.WriteLine("No of words present in string is" + arr.Length);
            Console.WriteLine("Enter the char u want to find count");
            char ch = char.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if (ch == input[i])
                {
                    {
                        Count++;
                    }
                }
           
            }
            Console.WriteLine($"count of {ch} in string is:" + Count);
        }
    }
}
    
