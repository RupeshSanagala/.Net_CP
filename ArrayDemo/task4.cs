using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class task4
    {
        public void dispplaymenu()
        {
            //Console.WriteLine("Welcome to Menu:");
            //Console.WriteLine("1.Display Fruit");
            //Console.WriteLine("2.Add Fruit");
            //Console.WriteLine("3.Update Fruit");
            //Console.WriteLine("4.Delete Fruit");
            //Console.WriteLine("5.Exit");

            CommonLogics.displayMenu();
        }
        List<string> list = new List<string>() { "Apple", "Banana", "orange", "kiwi" };
        public void dispplayFruits() {
            //for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }
            CommonLogics.displayFruits();
        }
       
        public void AddFruit()
        {
            //Console.WriteLine("Enter the fruit u want to Add for:");
            //string input = Console.ReadLine();
            //bool isFound1 = false;
            //for (int i = 0; i < list.Count; i++)
            //{
            
            //    if (input.Equals(list[i], StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"{input} is already present in your list");
            //        isFound1 = true;
            //        break;
            //    }
                
            //}
            //if (!isFound1)
            //{
            
            //        list.Add(input);
            //        Console.WriteLine("Successfully Added");
                
            //}
            CommonLogics.AddFruit();
            
        }
        public void UpdateFruit()
        {
            //Console.WriteLine("Enter the fruit you want to replace with");
            //string input3 = Console.ReadLine(); // aPPle, Apple
            //bool isFound = false;

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (input3.Equals(list[i], StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"{input3} is present in your list");
            //        Console.WriteLine("Now enter the fruit name you want to update:");
            //        string input4 = Console.ReadLine();

            //        // Update the fruit
            //        list[i] = input4;
            //        Console.WriteLine("Updated Successfully");
            //        isFound = true; 
            //        break;
            //    }
            //}

            //if (!isFound)
            //{
            //    Console.WriteLine($"The fruit '{input3}' is not present in the list.");
            //}
            CommonLogics.UpdateFruit();
        }
       
        public void RemoveFruit() {
            //Console.WriteLine("Enter the fruit u want to Remove for:");
            //string input1 = Console.ReadLine();
           
            //bool isfound = false;

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (input1.Equals(list[i], StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"{input1} is present in your list,wait a second I will remove it");
            //        list.Remove(input1);
            //        Console.WriteLine("Removed Successfully");
            //        isfound = true;
            //        break;
            //    }
            //}

            //if(!isfound)
            //{
            //    Console.WriteLine($"The fruit '{input1}' is not present in the list to Remove.");
            //}
            CommonLogics.RemoveFruit(); 
        }
        public void Exit()
        {
            //Console.WriteLine("Exiting the Menu");
            //Environment.Exit(0);
            CommonLogics.Exit();
        }

       
    }
}
