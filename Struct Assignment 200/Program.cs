using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.x = 3.14m;
            Console.WriteLine(number.x);
            Console.ReadLine();
        }
    }
}
