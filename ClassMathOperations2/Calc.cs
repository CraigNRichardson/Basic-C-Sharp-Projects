using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperations2
{
    public class Calc
    {
        public Calc()
        {

        }

        public int Add(int num)
        {
            
            return num + num;
        }

        public decimal Mult(decimal num)
        {
            return num * num;
        }

        public int Div(string num)
        {
            int num2 = Convert.ToInt32(num);
            return (num2 +17) / num2;
        }

    }
}
