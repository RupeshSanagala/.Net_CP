using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class CommonLogics
    {
        //1
        public static void displayMenu()
        {
            string[] operations = { "Welcome to Menu:", "1.Display Fruit", "2.Add Fruit", "3.Update Fruit", "4.Delete Fruit", "5.Exit" };
            foreach (string operation in operations) { Console.WriteLine(operation); }
        }
        //2
        static List<string> list = new List<string>() { "Apple", "Banana", "orange", "kiwi" };
        public static void displayFruits()
        {
            for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }
        }
        //3
        public static void AddFruit()
        {
            Console.WriteLine("Enter the fruit u want to Add for:");
            string input = Console.ReadLine();
            bool isFound1 = false;
            for (int i = 0; i < list.Count; i++)
            {

                if (input.Equals(list[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{input} is already present in your list");
                    isFound1 = true;
                    break;
                }

            }
            if (!isFound1)
            {

                list.Add(input);
                Console.WriteLine("Successfully Added");

            }

        }
        //4
        public static void UpdateFruit()
        {
            Console.WriteLine("Enter the fruit you want to replace with");
            string input3 = Console.ReadLine(); // aPPle, Apple
            bool isFound = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (input3.Equals(list[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{input3} is present in your list");
                    Console.WriteLine("Now enter the fruit name you want to update:");
                    string input4 = Console.ReadLine();

                    // Update the fruit
                    list[i] = input4;
                    Console.WriteLine("Updated Successfully");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"The fruit '{input3}' is not present in the list.");
            }
        }
        //5
        public static void RemoveFruit()
        {
            Console.WriteLine("Enter the fruit u want to Remove for:");
            string input1 = Console.ReadLine();

            bool isfound = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (input1.Equals(list[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{input1} is present in your list,wait a second I will remove it");
                    list.Remove(input1);
                    Console.WriteLine("Removed Successfully");
                    isfound = true;
                    break;
                }
            }

            if (!isfound)
            {
                Console.WriteLine($"The fruit '{input1}' is not present in the list to Remove.");
            }
        }
        //6
        public static void Exit()
        {
            Console.WriteLine("Exiting the Menu");
            Environment.Exit(0);
        }
    }
}
