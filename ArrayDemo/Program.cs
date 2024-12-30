using ArrayDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayMethods a = new ArrayMethods();
        //a.showArrayFun();
        //task1 t = new task1();
        //t.getElement();
        //task2 t1 = new task2();
        //t1.stringArray();
        //task3 t3 = new task3();
        //bool isvalid = false;
        //while (true)
        //{
        //    t3.displayMenu();
        //    Console.WriteLine("Enter the option you want to perform:");
        //    int userOption = int.Parse(Console.ReadLine());
        //    if (userOption == 1) { t3.displayFruits(); }
        //    else if (userOption == 2) { t3.FindFruit(); }
        //    else{ 
        //        //isvalid = false;
        //        break;
        //    }
        //}
        task4 t4 = new task4();
        while (true)
        {
            t4.dispplaymenu();
            Console.WriteLine("Enter the option you want to perform:");
            int userOption = int.Parse(Console.ReadLine());
            if (userOption == 1) { t4.dispplayFruits(); }
            else if (userOption == 2) { t4.AddFruit(); }
            else if (userOption == 3) { t4.UpdateFruit(); }
            else if (userOption == 4) { t4.RemoveFruit(); }
            else if (userOption == 5) { t4.Exit(); }
        }

        //switch (userOption)
        //{

        //        case 1:
        //        t3.displayFruits();
        //        break;
        //        case 2:
        //        t3.FindFruit();
        //        break;




        //}
        //t3.displayMenu();
    }
}