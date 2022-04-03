using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class OverloadMethods
    {
        /* method one: take in an integer, perform a match operation on it, then return as int*/
        public int manipulateValue(int number)
        {
            // perform math operations on integer, store as result
            int result = ((number * number) + number) / ((number * 2) - number);
            return result;
        }

        /* method two: take in a decimal, perform a math operation on it, return result as integer */
        public int manipulateValue(decimal number)
        {
            // perform math operation on decimal value, store as result
            int result = (Convert.ToInt32(number) + 3);
            return result;
        }

        /* method three: take in a string, perform a math operation on it, return result as integer */
        public int manipulateValue(string number)
        {
            // perform math operation on decimal value, store as result
            try
            {
                int result = (Convert.ToInt32(number) * 2);
                return result;
            }
            catch(FormatException)
            {
                Console.WriteLine("Mathmatical operations cannot be performed on " + number);
                return -1;
            }
        }

    }
}
