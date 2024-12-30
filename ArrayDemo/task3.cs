using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayDemo
{
    class task3
    {
        public void displayMenu()
        {
            Console.WriteLine("You can perform below Opereations:" +
                "1.Display Fruits" +
                "2.Find Fruit");
        }
        string[] fruits = { "Apple", "Banana", "orange", "kiwi" };
        public void displayFruits()
        {
            foreach (string fruit in fruits) Console.WriteLine(fruit);

        }
        
        //string input = Console.ReadLine();
        
        public void FindFruit()
        {
            Console.WriteLine("Enter the fruit u want to search for:");
            string input = Console.ReadLine();
            for (int i = 0; i < fruits.Length; i++)
            {
                //array[i] = array[i].ToLower();
                if (input.Equals(fruits[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{input} is present in your array");
                    break;
                }
                else
                {
                    Console.WriteLine($"{input} is not present");
                    break;
                }

            }

        }
        
    }
}
