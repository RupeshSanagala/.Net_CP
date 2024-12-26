using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
   namespace Banking
    {
        partial class BankAccount
        {
            public double cbal = 100000;
            public int accno = 3453;
            public string accHolder = "Rupesh";

            public void deposit(double amount)
            {
                cbal += amount;
            }


        }
    }
}
