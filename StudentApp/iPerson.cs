using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    interface iPerson
    {
        public string pname {  get; set; }
        public char pgender { get; set; }

        abstract string getPersonDetails();
    }
}
