using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Generic_Type_Parameter_190
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }

        public List<T> things = new List<T>();

        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + fullName);
        }

        public void Quit()
        {
            Console.WriteLine("Employee has quit.");

        }
    }
}
