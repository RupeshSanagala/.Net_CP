using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTasks
{
    abstract class Animal
    {
        string Name{get; set; }

       public abstract void Eat();
    }
    class Dog: Animal { 
       public override void Eat()
        {
            Console.WriteLine("dog is Eating");
        }
    }
}
