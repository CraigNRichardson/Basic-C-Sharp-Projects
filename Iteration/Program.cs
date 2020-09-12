using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] presidents = { "George Washington", "John Adams", "Thomas Jefferson", "James Madison", "James Monroe", "John Quincy Adams", "Andrew Jackson", "Martin Van Buren", 
            "William Henry Harrison", "John Tyler", "James K. Polk", "Zachary Taylor", "Millard Fillmore", "Franklin Pierce", "James Buchanan", "Abraham Lincoln", "Andrew Johnson", 
            "Ulysses S. Grant", "Rutherford B. Hayes", "James Garfield", "Chester A. Arthur", "Grover Cleveland", "Benjamin Harrison", "Grover Cleveland", "William McKinley", 
            "Theodore Roosevelt", "William Howard Taft", "Woodrow Wilson", "Warren G. Harding", "Calvin Coolidge", "Herbert Hoover", "Franklin D. Roosevelt", "Harry S. Truman", 
            "Dwight D. Eisenhower", "John F. Kennedy", "Lyndon B. Johnson", "Richard M. Nixon", "Gerarld Ford", "Jimmy Carter", "Ronald Reagan", "George Herbert Walker Bush", "Bill Clinton",
            "George W. Bush", "Barrack Obama", "Donald Trump" };
            Console.WriteLine("Welcome to \"Things Presidents Did\"!");
            Console.WriteLine();
            Console.WriteLine("Please enter a verb in past tense: ");
            string verb = Console.ReadLine();
            Console.WriteLine("Now, enter a noun: ");
            string noun = Console.ReadLine();
            Console.WriteLine();

            foreach (string president in presidents)
            {
                Console.WriteLine(president + " " + verb + " a " + noun + ".");
            }

            int i = 0;
            Random rand = new Random();
            while (i < presidents.Length - 44)
            {            
                int index = rand.Next(presidents.Length);
                Console.WriteLine();
                Console.WriteLine("Do you really believe that " + presidents[index] + " " + verb + " a " + noun + "?  [y] or [n]: ");
                i++;               
            }

            string ans = Console.ReadLine();
            int index1 = rand.Next(presidents.Length);
            if (ans == "y")
            {
                
                Console.WriteLine("It was actually " + presidents[index1] + " who " + verb + " a " + noun + ".");
            }
            else
            {
                Console.WriteLine("Of course you know better than that! You're probably well aware that it was actually " + presidents[index1] + " who " + verb + " a " + noun + ".");
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Here's a random list of 10 Presidents: ");

            
            while (i <= 10)
            {
                int index3 = rand.Next(presidents.Length);
                Console.WriteLine(presidents[index3]);
                i++;
            }

            List<string> favorabilityPres = new List<string>() { "George Washington", "Abraham Lincoln", "Thomas Jefferson", "Theodore Roosevelt", "Franklin Roosevelt", "John Kennedy", "John Adams",
                "James Madison", "Ronald Reagan", "Dwight Eisenhower", "Harry Truman", "Andrew Jackson", "Gerald Ford", "John Quincy Adams", "Ulysses S. Grant", "George H.W. Bush", "Jimmy Carter", 
            "William Howard Taft", "Woodrow Wilson", "Bill Clinton", "James Monroe", "Herbert Hoover", "Lyndon Johnson", "Andrew Johnson", "Chester Arthur", "James Garfield", "William McKinley",
            "George W. Bush", "Grover Cleveland", "Calvin Coolidge", "Rutherford B. Hayes", "Richard Nixon", "Benjamin Harrison", "Warren Harding", "James Buchanan", "James K. Polk", "Zachary Taylor", 
            "Martin Van Buren", "William Henry Harrison", "Franklin Pierce", "Millard Fillmore", "John Tyler" };
            Console.WriteLine();
            Console.WriteLine("Enter the name of a, pre-2007, US president to see where they ranked in a 2007 Rasmussen study on Presidential Favorability: ");
            string choice = Console.ReadLine();
            int n = favorabilityPres.IndexOf(choice);

            bool found = false;
            foreach (string president in favorabilityPres)
            {
                if (favorabilityPres.Contains(choice))
                {
                    Console.WriteLine(n + 1);
                    found = true;
                    break;
                }
            }
            if(found == false)
            {
                Console.WriteLine("You have entered an invalid name");
                Console.ReadLine();
                
            }

            List<string> vicePresidents = new List<string>() { "John Adams", "Thomas Jefferson", "Aaron Burr", "George Clinton", "George Clinton", "Elbridge Gerry", "Daniel Tompkins", "John Calhoun",
            "John Calhoun" };
            Console.WriteLine("Enter the name of one of the first 7 Vice Presidents of the United States: ");

            var a = 0;
            string vpChoice = Console.ReadLine();
            List<int> foundVicePresident = new List<int>() { };

            if (vicePresidents.Contains(vpChoice))
            {
                foreach (var vicePresident in vicePresidents)
                {
                    if (vicePresident == vpChoice)
                    {
                        foundVicePresident.Add(a);
                    }
                    a++;
                }

                foreach (int k in foundVicePresident)
                {
                    Console.WriteLine(vpChoice + " index #: " + k);
                }
            }
            else
            {
                Console.WriteLine("Vice President name not found");
            }
            Console.ReadLine();

            
        }
    }
}
