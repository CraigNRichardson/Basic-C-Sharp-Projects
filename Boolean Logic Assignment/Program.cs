using System;


namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            byte uAge = Convert.ToByte(userAge);
            Console.WriteLine("Have you ever had a DUI? Please type \"true\" or \"false\".");
            string userDUI = Console.ReadLine();
            bool uDUI = Convert.ToBoolean(userDUI);
            byte dui = Convert.ToByte(uDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string userTickets = Console.ReadLine();
            byte uTickets = Convert.ToByte(userTickets);

            Console.WriteLine("Qualified?");
            bool qualifies = uAge > 15 && dui < 1 && uTickets < 4;
            Console.WriteLine(qualifies);
            Console.ReadLine();
        }
    }
}
