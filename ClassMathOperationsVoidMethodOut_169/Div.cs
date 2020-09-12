using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationsVoidMethodOut_169
{
    public class Div
    {
        public void DivBy2(int num1, out int result)
        {
            result = num1 / 2;
        }

        public static void DivByX(int num1, out int result1, out int result2)
        {
            result1 = num1 / 2;
            result2 = num1 / 4;

            Console.WriteLine(num1 + " divided by 2 = {0}", result1);
            Console.WriteLine(num1 + " divided by 4 = {0}", result2);
        }
        public static void DivByX(decimal num1, out decimal result1, out decimal result2)
        {
            result1 = num1 / 3;
            result2 = num1 / 5;
        }
    }
}
