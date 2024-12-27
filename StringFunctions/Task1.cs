using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Task1
    {
        string name;
        string res = "";

        public void converttoCamelCase(string name)
        {
            
            res = char.ToUpper(name[0])+name.Substring(1);
            for (int i = 1; i <res.Length;i++) 

            {
                char c = res[i - 1];
                if (c == ' ') { c = char.ToUpper(c); }
                else { res += c; }


            }
            Console.WriteLine(res);
            

        }
        
    }
}
