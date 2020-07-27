using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceInterface_182
{
    public class Employee : Person, IQuittable
    {
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
