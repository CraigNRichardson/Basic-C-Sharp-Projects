using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceInterface_182
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + fullName);
        }
        public static bool operator == (Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.Id == employee2.Id)
            {
                status = true;
            }

            if (employee1.Id != employee2.Id)
            {
                status = false;
            }
            return status;
            
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.Id != employee2.Id)
            {
                status = false;
            }
            return status;
        }

        public void Quit()
        {
            Console.WriteLine("Employee has quit.");

        }
    }
}