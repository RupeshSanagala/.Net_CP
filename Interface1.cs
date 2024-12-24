using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTasks
{
    internal interface Interface1
    {
        abstract void Drive();
        abstract bool Refuel(int amountOfGas);
    }
    class Car : Interface1
    {
        int starting_fuel;

        public Car(int starting_fuel)
        {
            this.starting_fuel = starting_fuel;
        }

        public void Drive()
        {
            if (starting_fuel > 0)
            {
                Console.WriteLine("Car is in Driving Mode");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }

        public bool Refuel(int amountOfGas)
        {
            starting_fuel += amountOfGas;
            return true;
        }
    }
}
