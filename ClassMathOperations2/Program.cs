using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperations2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Calc calc = new Calc();

            Console.WriteLine(calc.Add(3));
            Console.WriteLine(calc.Mult(Convert.ToDecimal(4.11)));
            Console.WriteLine(calc.Div("3"));
            Console.ReadLine();
        }
        
    }
}
