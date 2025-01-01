using ExceptionDemo;
using System.Security.Cryptography.X509Certificates;
delegate int  mydelegate(int a,int b);
internal class Program
{
    public delegate void calc(int a, int b);
    private static void Main(string[] args)
    {
        //calc c;
        //Calculator c1 = new Calculator();
        //c = c1.Add;
        ////c= c1.sub;
        //c(20, 10);
        //subscriber s=new subscriber();
        //s.subMethod();
        
        //fileInfoDemo f1 = new fileInfoDemo();
        //f1.tryFileInfo();
        //DirectoryInfoDemo d = new DirectoryInfoDemo();
        //d.tryDirectoryMethods();
        //OnlineAttendance o = new OnlineAttendance();
        //o.onlineAttemdanceDemo();
        LinqDemo l = new LinqDemo();
        l.tryLinq();
        //void Message(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //try
        //{
        //    int a = 10;
        //    int b = 0;
        //    Message("I am from try block");
        //    int res = a / b;
        //    Console.WriteLine(res);
           

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
            
        //    Console.WriteLine("Code Executed in Final Block");
        //}
    }
}