namespace StudentApp{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Student Application Management Sysytem");
            //Student s1 = new Student();
            //s1.rollno = 234;
            //s1.name = "alekhya";
            //s1.gender = 'F';
            //s1.displayDetails(name: s1.name, rollno: s1.rollno, gender: s1.gender);
            //s1.displayDetails(4534, "Rupesh", 'M');
            //s1.rollno = Student.incrementid();
            //s1.name = "Rupesh Reddy";
            //s1.gender = 'M';
            //Console.WriteLine("sid:"+ s1.rollno);
            //Console.WriteLine("name:"+ s1.name);
            //Console.WriteLine("gender:"+ s1.gender);
            //Student s2 = new Student();
            //s2.rollno = Student.incrementid();
            //s2.name = "praboss";
            //s2.gender = 'M';
            //Console.WriteLine("sid:" + s2.rollno);
            //Console.WriteLine("name:" + s2.name);
            //Console.WriteLine("gender:" + s2.gender);

            //int day = 2;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}
            //int[] arr = { 1, 2, 3 };
            //Array.Reverse(arr);
            //Array.IndexOf(arr, 2);
            //foreach (int i in arr) Console.WriteLine(i);
            //Student s = new Student();
            //s.state = "Ap";
            //s.city = "ongole";
            //s.zipCode = 523001;
            //Console.WriteLine(s.getAddress());
            //s.pname = "Vinay";
            //s.pgender = 'M';
            //Console.WriteLine(s.getPersonDetails());

            //Faculty f = new Faculty();
            //f.email = "rupesh@gmail.com";
            //f.mobno = 7075482237;
            //f.pname = "ravi";
            //f.pgender = 'M';
            //f.city = "Siruser";
            //f.state = "Tamil Nadu";
            //f.zipCode = 600103;
            //Console.WriteLine(f.getAddress());
            //Console.WriteLine(f.getPersonDetails());
            //Console.WriteLine(f.getContactDetails());

            //StudentApp.Banking.BankAccount b = new StudentApp.Banking.BankAccount();    
            //Console.WriteLine("Before Deposit:" + b.cbal);
            //b.deposit(2000);
            //Console.WriteLine("After Deposit:"+ b.cbal);
            //b.Withdraw(10000);
            //Console.WriteLine("After Withdraw:"+ b.cbal);

            int[] arr = { 1, 2, 3 };
            int[] arr1 = new int[3];
            
            Console.WriteLine(Array.IndexOf(arr, 3));
            Array.Copy(arr,arr1,arr.Length);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            



            Console.ReadKey();
        }

    }
    
}