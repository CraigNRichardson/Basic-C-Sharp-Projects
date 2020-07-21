using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int> { 44, 11, 72, 16, 5 };
            

            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the numbers in the list...");
                foreach (int i in numbers)
                {
                    int numberTwo = i / numberOne;
                    Console.WriteLine(i + " divided by " + numberOne + " equals: " + numberTwo);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
