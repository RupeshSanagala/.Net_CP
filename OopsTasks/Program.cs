using System;
using OopsTasks;
namespace OopsTasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
              //PhotoBook.cs
                PhotoBook p = new PhotoBook(16);

                Console.WriteLine(p.GetNoOfPages());

                PhotoBook p1 = new PhotoBook(24);

                Console.WriteLine(p1.GetNoOfPages());


                BigPhotoBook b = new BigPhotoBook(64);
                Console.WriteLine(b.GetNoOfPages1());
            
             //person.cs
            int total = 3;
            person[] persons = new person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
             //Shapes.cs
            Circle c1 = new Circle();
            Console.WriteLine("Area of circle is:"+ c1.Area(5));
            Console.WriteLine("Perimeter of circle is:" + c1.Perimeter(5));

            Rectangle r1 = new Rectangle();

            Console.WriteLine("Area of rectangle is: " + r1.Area(3, 3));
            Console.WriteLine("Perimeter of rectangle is: " + r1.Perimeter(3, 3));

            //interface1.cs
            Car c4 = new Car(0);
           
            Console.WriteLine("Enter the amount of refuel you want:");
            int amountOfFuelNeed = int.Parse(Console.ReadLine());
            if (c4.Refuel(amountOfFuelNeed))
            {
                c4.Drive();
            }

            //Animal.cs

             Dog a = new Dog();
             Console.WriteLine("Enter the Dog Name:");
             string dogName = Console.ReadLine();
             Console.WriteLine(dogName);
 
             a.Eat();

        }
    }
}
