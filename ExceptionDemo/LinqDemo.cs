using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
     class LinqDemo
    {
        public void tryLinq()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };

            List<int> list2 = (from x in list where x>=30 select x).ToList();

            foreach (var x in list2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
