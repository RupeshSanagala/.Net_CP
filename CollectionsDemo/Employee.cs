using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public string EmpDesg;

        public Employee() { }

        public Employee(int empId, string empName, string empDesg)
        {
            EmpId = empId;
            EmpName = empName;
            EmpDesg = empDesg;
        }
    }

    class EmployeeManagement
    {
        private List<Employee> list = new List<Employee>();

        public EmployeeManagement()
        {
           
            list.Add(new Employee(100, "Rupesh", "Developer"));
            list.Add(new Employee(101, "Narasimha", "Manager"));
            list.Add(new Employee(102, "Vinay", "Senior Developer"));
            list.Add(new Employee(103, "Rahul", "Jr Developer"));
            list.Add(new Employee(104, "Ritesh", ".Net Dev"));
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\nWelcome to Employee Management System");
            Console.WriteLine("1. Display Employee List");
            Console.WriteLine("2. Add Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
        }

        public void DisplayEmployeeList()
        {
            Console.WriteLine("\nEmployee List:");
            foreach (var emp in list)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpDesg: {emp.EmpDesg}");
            }
        }

        public void AddEmployee()
        {
            Console.WriteLine("\nEnter Employee ID:");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation:");
            string empDesg = Console.ReadLine();

            if (list.Exists(emp => emp.EmpId == empId))
            {
                Console.WriteLine($"Employee with ID {empId} already exists.");
            }
            else
            {
                list.Add(new Employee(empId, empName, empDesg));
                Console.WriteLine("Employee added successfully!");
            }
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("\nEnter the Employee ID you want to update:");
            int empId = int.Parse(Console.ReadLine());

            var employee = list.Find(emp => emp.EmpId == empId);
            if (employee != null)
            {
                Console.WriteLine($"Updating Employee: {employee.EmpName}, {employee.EmpDesg}");
                Console.WriteLine("Enter new Employee Name:");
                employee.EmpName = Console.ReadLine();
                Console.WriteLine("Enter new Employee Designation:");
                employee.EmpDesg = Console.ReadLine();
                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine($"Employee with ID {empId} not found.");
            }
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("\nEnter the Employee ID you want to delete:");
            int empId = int.Parse(Console.ReadLine());

            var employee = list.Find(emp => emp.EmpId == empId);
            if (employee != null)
            {
                list.Remove(employee);
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Employee with ID {empId} not found.");
            }
        }

        public void Start()
        {
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("\nEnter your choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayEmployeeList();
                        break;
                    case "2":
                        AddEmployee();
                        break;
                    case "3":
                        UpdateEmployee();
                        break;
                    case "4":
                        DeleteEmployee();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program...");
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}