using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadMethods m = new OverloadMethods(); // create class object and instantiate it

            try
            {
                /* function 1: function will take passed in number and calculate the following:
                    ((number * number) + number) / ((number * 2) - number) */
                Console.WriteLine("Enter an integer:\n");
                int choice = Convert.ToInt32(Console.ReadLine()); // read in input from user, convert to integer
                int result = m.manipulateValue(choice); // call overloaded function with passed in integer value
                // output result to console
                Console.WriteLine("Int to Int: ((" + choice + "*" + choice + ") + " + choice + ") / ((" + choice + "*2) -" + choice + ") = " + result); 

                /* function 2: function will take passed in decimal value, convert to integer, add 3 and return the result as an integer */
                Console.WriteLine("Enter a decimal:\n");
                decimal choice2 = Convert.ToDecimal(Console.ReadLine()); // read in input from user, convert to decimal
                result = m.manipulateValue(choice2); // call overloaded function with passed in decimal value
                Console.WriteLine("Decimal to int: " + choice2 + " + 3 = " + result); //output result to console

                /* function 3: function will take in a string, convert it to an integer if possible, multiply the value by 2 then return as int, if math operation is not possible, function will return value of -1 and output error message */
                Console.WriteLine("Enter a string:\n");
                string choice3 = Console.ReadLine(); // read in string
                result = m.manipulateValue(choice3); // call overloaded function with passed in string value
                if(result == -1) // error, string could not be converted to integer
                {
                    Console.WriteLine("Could not compute result.");
                }
                else // output result to console
                    Console.WriteLine("String to int: " + choice3 + " * 2 = " + result);

                Console.ReadLine(); // keep console open
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
