using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class VoidClass
    {
        // take in two integers as parameters, perform a math operation on first integer, display the second integer to console
        public void twoIntegers(int num1, int num2)
        {
            int result = num1 * 5; // multiple num1 * 5
            Console.WriteLine("The second number you entered is: " + num2);
        }
    }
}
