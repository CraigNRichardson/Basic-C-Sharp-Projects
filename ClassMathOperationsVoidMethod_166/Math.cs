using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationsVoidMethod_166
{
    public class Math
    {
        
        int num1, num2 = 4;

        public void Math1()
        {
            
            Console.WriteLine("The Second number is: " + num2);
        }

        public void Math2()
        {
            this.num1 = 3;
            int num3 = num1 * num2;
            Console.WriteLine("The Result is {0}", num3);
        }

        
    }
}
