using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class Company
    {
        private int cid;
        private string cname;
         
        public Company(int cid, string cname)
        {
            this.cid = cid;
            this.cname = cname;
        }

        public void displaydetails()
        {
            Console.WriteLine("my emp id is :" + cid);
        Console.WriteLine("My name is :"+ cname);
        }
    }
}
