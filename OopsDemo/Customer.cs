using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    abstract class Customer
    {
        public int cid;
        public string cname;
        public decimal bal { get; set; }
        public string branchName;
        public abstract string GetTotalBal();
    }

    class SavingsAccount : Customer
    {
        public override string GetTotalBal()
        {
            return "Your's savings acc balance is:" + bal;
        }

        public string branchAddress()
        {
            return "Your branch is located at" + branchName;
        }
    }
    class CurrentAccount : Customer
    {
        public override string GetTotalBal()
        {
            return "Yours currentAccount balance is " + bal;
        }
    }
}
