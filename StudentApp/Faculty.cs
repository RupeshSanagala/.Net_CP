using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Faculty:iPerson,IAddress,iContact
    {
        public string pname { get; set; }
        public char pgender { get; set; }

        public long mobno { get; set; }
        public string email { get; set; }

        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }

        public string getPersonDetails()
        {
            return $"{pname} gender is {pgender}";
        }

        public string getAddress()
        {
            return $"{city} is in {state} with zipcode {zipCode}";
        }

        public string getContactDetails()
        {
            return $"{mobno} belongs to {email}";
        }
    }
}
