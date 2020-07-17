using System;


namespace Branching_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int totalDimension = width + height + length;
            decimal quote = ((width * height * length) * weight) / 100;

            string result = totalDimension > 50 ? "Your package is too large to ship via Package Express." : "Your estimated total for shipping this package is: $" + quote +".00";
            Console.WriteLine(result);
            Console.WriteLine("Thank you.");
            Console.ReadLine();

        }
    }
}
