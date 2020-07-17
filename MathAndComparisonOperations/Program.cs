using System;
using System.Net.Http.Headers;

namespace MathAndComparisonOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a whole number...");
            string userNumber = Console.ReadLine();
            int uNum = Convert.ToInt32(userNumber);
            int product = uNum * 50;
            Console.WriteLine(uNum +" multiplied by 50 equals: "+product);
            Console.ReadLine();

            Console.WriteLine("Enter a whole number...");
            string userNumber2 = Console.ReadLine();
            int uNum2 = Convert.ToInt32(userNumber2);
            int sum = uNum2 + 25;
            Console.WriteLine(uNum2 + " plus 25 equals: " + sum);
            Console.ReadLine();

            Console.WriteLine("Enter a whole number...");
            string userNumber3 = Console.ReadLine();
            double uNum3 = Convert.ToDouble(userNumber3);
            double result = uNum3 / 12.5;
            Console.WriteLine(uNum3 + " divided by 12.5 equals: " + result);
            Console.ReadLine();

            Console.WriteLine("Enter a whole number...");
            string userNumber5 = Console.ReadLine();
            int uNum5 = Convert.ToInt32(userNumber5);
            bool result5 = uNum5 > 50;
            Console.WriteLine(result5.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a whole number...");
            string userNumber6 = Console.ReadLine();
            int uNum6 = Convert.ToInt32(userNumber6);
            int remainder = uNum6 % 7;
            Console.WriteLine(uNum6 + " divided by 7 leaves a remainder of: " + remainder);
            Console.ReadLine();
        }
    }
}
