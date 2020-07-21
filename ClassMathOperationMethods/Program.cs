using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Operations operations = new Operations();
            Console.WriteLine("The area of a circle with a radius of " + num + " is: " + operations.AreaCircle(num) + ".");
            Console.WriteLine("The volume of a sphere with a radius of " + num + " is: " + operations.VolumeSphere(num) + ".");
            Console.WriteLine("The volume of a cube with a segment length of " + num + " is: " + operations.VolumeCube(num) + ".");

            Console.ReadLine();


            

            

        
        
            
        }
    }
}
