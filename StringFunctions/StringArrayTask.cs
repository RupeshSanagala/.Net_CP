using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
     class StringArrayTask
    {
        public void tryStringArray()
        {
            string[] fruits = { "Apple", "banana", "mango", "guava" };

            //Console.Write("Enter the fruit name you want to replace: ");
            

            bool fruitFound = false;

            Console.WriteLine("Welcome to menu: 1.Display fruits \n 2.Update Fruits \n 3.Remove Fruits");
            int uinput = int.Parse( Console.ReadLine() );
            if (uinput == 1) {
                Console.WriteLine("Let me display fruits list:");
                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.WriteLine($"{i}: {fruits[i]}");
                }

            }
            
            if (uinput == 2) {
                Console.WriteLine("Are you want to update fruit:");
                string input = Console.ReadLine();
                if (!fruitFound)
                {
                    Console.WriteLine($"{input} is not present in the fruits array.");
                }

                for (int i = 0; i < fruits.Length; i++)
                {
                    if (fruits[i] == input)
                    {
                        fruitFound = true;
                        Console.WriteLine($"{input} is found. Enter the new fruit name to replace it with:");

                        string addFruit = Console.ReadLine();
                        fruits[i] = fruits[i].Replace(fruits[i], addFruit);
                        break;
                    }
                }

            }

            if (uinput == 3) {
                Console.WriteLine("Are you want to delete");
                string input1 = Console.ReadLine();

                for(int i = 0; i < fruits.Length; i++)
                {
                    if (fruits[i] == input1)
                    {
                        fruits[i].Remove(input1);
                    }
                }
            
            }




            

            Console.WriteLine("\nUpdated fruits list:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{i}: {fruits[i]}");
            }

        }
    }
}
