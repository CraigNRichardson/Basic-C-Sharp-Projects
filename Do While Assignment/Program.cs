using System;
using System.Security.AccessControl;

namespace Do_While_Assignment
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is the best season of the year? Enter \"spring\", \"summer\", \"fall\", or \"winter\":");
            string seasonChoice = Console.ReadLine();
            bool right = false;

            while (!right)
            switch (seasonChoice)
            {
                case "spring":
                    Console.WriteLine("You selected Spring. Spring is the 2nd best season of the year. Try again.");
                    Console.WriteLine("What is the best season of the year?");
                    seasonChoice = Console.ReadLine();
                    break;

                case "summer":
                    Console.WriteLine("You selected Summer. Summer is the 3rd best season of the year. Try again.");
                    Console.WriteLine("What is the best season of the year?");
                    seasonChoice = Console.ReadLine();
                        break;

                case "fall":
                    Console.WriteLine("You selected Fall. Yes! You are correct! Fall is the best season of the year.");
                    right = true;
                    int i = 0;
                        do
                        {
                            Console.WriteLine("Fall is the best season of the year!", i);
                            i++;
                        } while (i < 16);
                    break;

                case "winter":
                    Console.WriteLine("You selected Winter. Winter is the worst season of the year. Try again.");
                    Console.WriteLine("What is the best season of the year?");
                    seasonChoice = Console.ReadLine();
                    break;
                }
            Console.ReadLine();

        }
    }
}
