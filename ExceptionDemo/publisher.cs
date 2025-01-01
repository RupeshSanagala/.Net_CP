using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
   class publisher
    {
        public event mydelegate myevent;

        public int x = 0 , y=0;

        public void increment()
        {
            x++;
            y++;
           int res = myevent(x,y);
            Console.WriteLine("sum of and b is" + res);
        }

    }
}
