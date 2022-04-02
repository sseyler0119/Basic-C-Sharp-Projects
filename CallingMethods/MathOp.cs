using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class MathOp
    {
        public int addTwo(int num)
        {
            int result = num + 2; // add two to passed in number, store in result
            return result;
        }

        public int multiplyByFive(int num)
        {
            int product = num * 5; // multiply passed in number by 5, store in product
            return product;
        }

        public int subtractSeven(int num)
        {
            int result = num - 7;
            return result;
        }


    }
}
