using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enum_195
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your favorite day of the week?");
            string myFavDay = Console.ReadLine();
            DaysOfTheWeek.Days day;
            try
            {
                day = (DaysOfTheWeek.Days) Enum.Parse(typeof(DaysOfTheWeek.Days), myFavDay);
                Console.WriteLine("Thanks for telling me that your favorite day is " + myFavDay +".");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                
            }    
                

                
            
            
            
                
            
           
        }
    }
}
