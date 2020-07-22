using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationsOptionalParameter
{
    class Calc
    {
        public Calc()
        {

        }

        public int Add(int num, int num2 = 5)
        {
            return num + num2;
        }

    }
}
