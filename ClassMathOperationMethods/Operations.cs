using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperationMethods
{
    public class Operations
    {
        public Operations()
        {

        }

        public double AreaCircle(int num)
        {
            return 3.1415 * (num * num);
        }

        public double VolumeSphere(int num)
        {
            return (4 / 3 * 3.1415) * (num * num * num);
        }

        public double VolumeCube(int num)
        {
            return 6 * (num * num);
        }
    }
}
