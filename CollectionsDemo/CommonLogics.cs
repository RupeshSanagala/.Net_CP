//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CollectionsDemo
//{
//    class CommonLogics
//    {
        //1
        //public static void displayEmpManagement()
        //{
        //    string[] operations = { "Welcome to EmpManagement:", "1.Display EmpList", "2.Add EmpDetails", "3.Update EmpDetails", "4.Delete EmpDetails", "5.Exit" };
        //    foreach (string operation in operations) { Console.WriteLine(operation); }
        //}
        ////2
        ////static List<string> list = new List<string>() { "Apple", "Banana", "orange", "kiwi" };
        //static List<Employee>list = new List<Employee>();
        //public void createObjects()
        //{
        //    list.Add(new Employee(100, "rupesh", "Developer"));
        //    list.Add(new Employee(101, "narasimha", "Manager"));
        //    list.Add(new Employee(102, "Vinay", "Senior Developer"));
        //    list.Add(new Employee(103, "Rahul", "Jr Developer"));
        //    list.Add(new Employee(104, "Ritesh", ".Net Dev"));
        //}
        //public static void displayEmpDetails()
        //{
        //    for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }
        //}
        //3
//        public static void AddEmployee()
//        {
//            Console.WriteLine("Enter the EmpId");
//            int idInput = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the EmpName");
//            string Nameinput = Console.ReadLine();
//            Console.WriteLine("Enter the Emp Designation");
//            string roleinput = Console.ReadLine();
//            bool isFound1 = false;
//            for (int i = 0; i < list.Count; i++)
//            {

//                if (input.Equals(list[i], StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine($"{input} is already present in your list");
//                    isFound1 = true;
//                    break;
//                }

//            }
//            if (!isFound1)
//            {

//                list.Add(input);
//                Console.WriteLine("Successfully Added");

//            }

//        }
//        //4
//        public static void UpdateFruit()
//        {
//            Console.WriteLine("Enter the fruit you want to replace with");
//            string input3 = Console.ReadLine(); // aPPle, Apple
//            bool isFound = false;

//            for (int i = 0; i < list.Count; i++)
//            {
//                if (input3.Equals(list[i], StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine($"{input3} is present in your list");
//                    Console.WriteLine("Now enter the fruit name you want to update:");
//                    string input4 = Console.ReadLine();

//                    // Update the fruit
//                    list[i] = input4;
//                    Console.WriteLine("Updated Successfully");
//                    isFound = true;
//                    break;
//                }
//            }

//            if (!isFound)
//            {
//                Console.WriteLine($"The fruit '{input3}' is not present in the list.");
//            }
//        }
//        //5
//        public static void RemoveFruit()
//        {
//            Console.WriteLine("Enter the fruit u want to Remove for:");
//            string input1 = Console.ReadLine();

//            bool isfound = false;

//            for (int i = 0; i < list.Count; i++)
//            {
//                if (input1.Equals(list[i], StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine($"{input1} is present in your list,wait a second I will remove it");
//                    list.Remove(input1);
//                    Console.WriteLine("Removed Successfully");
//                    isfound = true;
//                    break;
//                }
//            }

//            if (!isfound)
//            {
//                Console.WriteLine($"The fruit '{input1}' is not present in the list to Remove.");
//            }
//        }
//        //6
//        public static void Exit()
//        {
//            Console.WriteLine("Exiting the Menu");
//            Environment.Exit(0);
//        }
//    }
//}
