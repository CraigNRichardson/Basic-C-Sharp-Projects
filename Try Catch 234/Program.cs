using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Try_Catch_234
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age...");
                int age = Convert.ToInt32(Console.ReadLine());
                BirthYear birthYear1 = new BirthYear(age);
                DateTime now = DateTime.Today;
                Console.WriteLine("Depending on your birth month, you were born in either " + (now.Year - age) + " or " + (now.Year - age - 1) + ".");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Error: {0}", outOfRange.Message);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("You have encountered an error, please contact tech support.");
                Console.ReadLine();
            }
            
            
            

            


        }
    }
    class BirthYear
    {

        public BirthYear(int age)
        {
            if (age == 0)
                throw new ArgumentOutOfRangeException("Age", "You must be older than 0.");

            if (age < 0)
                throw new ArgumentOutOfRangeException("Age", "You have entered a negative number. That's interesting, but not possible.");
        }
        

    }
}
