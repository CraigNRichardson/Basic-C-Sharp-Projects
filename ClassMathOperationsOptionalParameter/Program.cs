using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationsOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("Enter a number (required): ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number (optional): ");

            int num2;
            int result;
            if(int.TryParse(Console.ReadLine(), out num2))
            {
                result = calc.Add(num, num2);
            }
            else
            {
                result = calc.Add(num);
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
