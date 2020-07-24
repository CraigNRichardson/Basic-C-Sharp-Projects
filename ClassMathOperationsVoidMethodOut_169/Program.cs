using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationsVoidMethodOut_169
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Div div = new Div();
            div.DivBy2(num1, out int result);
            Console.WriteLine(num1 + " divided by 2 = {0}", result);
            Console.ReadLine();
            Div.DivByX(num1, out int result1, out int result2);
            Console.ReadLine();
        }
    }
}
