
namespace OopsDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Company c = new Company(4569, "Rupesh Reddy");
            //c.displaydetails();

            //Employee e = new Employee();
            //e.EmployeeID = 4569;
            //e.Ename = "Rupesh Kumar Reddy";
            //e.Esal = 35000.00;
            //e.Yob = 2008;

            //string res = e.getEmpDetails();

            //Console.WriteLine(res);

            //Customer customer = new SavingsAccount();
            //customer.cid = 1000;
            //customer.cname = "Rupesh Sanagala";
            //customer.bal = 20000;
            //Console.WriteLine(customer.GetTotalBal());

            //Customer customer1 = new CurrentAccount();
            //customer1.bal = 50000;
            //Console.WriteLine(customer1.GetTotalBal());

            Student s1 = new Student(362,"Rupesh");
            Console.WriteLine("Student id is:"+ s1.sid);
            Console.WriteLine(Student.collegename);
            Console.WriteLine("student name is:"+ s1.sname);
            Console.WriteLine(Student.noOfSems);
            Console.WriteLine(s1.GetStudentDetails());
            int num = int.Parse(Console.ReadLine());
            
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num--;
            }


        }
    }
}
