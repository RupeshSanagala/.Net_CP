using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class DateTimeMethods
    {
        public void tryDateTimeMethods()
        {
            DateTime d;
            d = DateTime.Now;
            Console.WriteLine(d.Day);
            Console.WriteLine(d.Hour);
            Console.WriteLine(d.Minute);
            Console.WriteLine(d.Second);
            Console.WriteLine(d.Millisecond);
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(d.CompareTo(d));
            Console.WriteLine(d.ToLocalTime());
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Year);
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.Kind);
         Console.WriteLine(d.AddDays(1));
            Console.WriteLine(d.AddHours(5.25));
            Console.WriteLine(d.AddYears(1));
            Console.WriteLine(d.GetType());
            Console.WriteLine(d.ToString("dd-MM-yyyy"));

        }



    }
        

    
}
