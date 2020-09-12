using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Variable_Constructor_Chain_230
{
    class Program
    {
        static void Main(string[] args)
        {
            const int locationCode = 3221;
            var locationName = "Aspen";
            Employee employee = new Employee(1, "George Anderson");
            Console.WriteLine(employee.name + " ID#: " + employee.id + ", " + "works in " + locationName + " at site #" + locationCode);
            Console.ReadLine();
        }
    }
}
