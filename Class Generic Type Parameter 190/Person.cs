using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Generic_Type_Parameter_190
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();

    }
}
