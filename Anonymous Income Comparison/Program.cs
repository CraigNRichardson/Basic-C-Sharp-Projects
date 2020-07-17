using System;


namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Incomce Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate:");
            string rate1 = Console.ReadLine();
            decimal rt1 = Convert.ToDecimal(rate1);
            Console.WriteLine("Enter number of hours worked per week:");
            string weeklyHours1 = Console.ReadLine();
            decimal wklyhrs1 = Convert.ToDecimal(weeklyHours1);
            decimal annualSalary1 = rt1 * wklyhrs1 * 52;
            
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate:");
            string rate2 = Console.ReadLine();
            decimal rt2 = Convert.ToDecimal(rate2);
            Console.WriteLine("Enter number of hours worked per week:");
            string weeklyHours2 = Console.ReadLine();
            decimal wklyhrs2 = Convert.ToDecimal(weeklyHours2);
            decimal annualSalary2 = rt2 * wklyhrs2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salCompare = annualSalary1 > annualSalary2;
            Console.WriteLine(salCompare);
            Console.ReadLine();


        }
    }
}
