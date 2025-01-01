using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
  class subscriber
    {
        public void subMethod()
        {
            publisher p = new publisher();
            //p.myevent += delegate (int a, int b)
            //{
            //    int res = a + b;
            //    Console.WriteLine("sum of a and b is "+ res);
            //};
            p.myevent += (a, b) => (a + b);
            p.increment();
        }
    }
}
