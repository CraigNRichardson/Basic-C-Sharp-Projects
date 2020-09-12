using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Hello! Please enter a number:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + x + " hours, the time will be: " + DateTime.Now.AddHours(x));
            Console.ReadLine();
        }
    }
}
