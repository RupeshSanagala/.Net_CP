using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class innerClassDemo
    {
        public int count = 0;
        class innerClass
        {
            public int count = 0;
            public void increment()
            {
                count += 5;
                Console.WriteLine("inside innerclass:"+ count);
            }
        }
        //public void outside()
        //{
        //    Console.WriteLine("outside of inner class"+ count);

        //}
    }
}
