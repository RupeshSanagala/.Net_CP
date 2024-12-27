using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class StringMethods
    {
        string fullname = "Rupesh Kumar Reddy";
        string lastname = new string("sanagala");

        public void tryStringMethods()
        {
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(lastname.ToUpper());
            Console.WriteLine(fullname[0]);
            Console.WriteLine(lastname.Substring(0,4));
            Console.WriteLine(fullname.Remove(1,5));
            Console.WriteLine(fullname.StartsWith("Rupesh"));
            Console.WriteLine(fullname.EndsWith("Reddy"));
            Console.WriteLine(fullname.Contains("Rup"));
            Console.WriteLine(fullname.Equals(lastname));
            Console.WriteLine(fullname.CompareTo(lastname));
            Console.WriteLine(fullname.IndexOf('e'));
            Console.WriteLine(string.Format("Good Afternoon {lastname}",lastname));
            Console.WriteLine(fullname.ToCharArray());
            string[] nameArr = fullname.Split(' ');
            Console.WriteLine(string.Join(' ',nameArr));

        }
    }
}
