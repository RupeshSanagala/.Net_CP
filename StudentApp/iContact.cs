using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal interface iContact
    {
        public long mobno {  get; set; }
        public string email { get; set; }

        public string getContactDetails();
    }
}
