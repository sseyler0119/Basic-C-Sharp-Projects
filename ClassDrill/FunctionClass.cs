using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class FunctionClass
    {
        /* void function that divides the data passed to it by 2 and displays the result to the console */
        public void integerOutput(int num)
        {
            int result = num / 2; // divide num by 2, assign to result
            Console.WriteLine(num + " / 2 = " + result);
        }
        
        /* overload a function */
        public void integerOutput(int num1, int num2)
        {
            int result = num1 * num2; // multiply num1 by num2, store as result
            Console.WriteLine(num1 + " * " + num2 + " = " + result); 
        }
        /* create a method with output parameters */
        public void outputDemo(out int output)
        {
            output = 16; // send this value out of the function
        }

    }
}
