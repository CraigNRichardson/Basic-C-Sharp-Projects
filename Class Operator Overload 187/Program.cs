using ClassInheritanceInterface_182;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Operator_Overload_187
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee();
            employee1.FirstName = "Bill";
            employee1.LastName = "Smith";
            employee1.Id = 1;
            Employee employee2 = new Employee();
            employee2.FirstName = "William";
            employee2.LastName = "Smith";
            employee2.Id = 2;

            if (employee1 == employee2)
            {
                Console.WriteLine("This is the same employee.");
            }
            else
            {
                Console.WriteLine("These are different employees.");
            }
            Console.ReadLine();
        }
    }
}
