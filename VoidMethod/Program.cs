using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass object1 = new VoidClass(); // create class object and instantiate it

            try
            {
                Console.WriteLine("Enter an integer: ");
                int num1 = Convert.ToInt32(Console.ReadLine()); // get input from user as integer
                Console.WriteLine("Enter another integer: ");
                int num2 = Convert.ToInt32(Console.ReadLine()); // get input from user as integer
                object1.twoIntegers(num1, num2); // call twoIntegers function with passed in values
                object1.twoIntegers(num1: 15, num2: 45); // call twoIntegers function, specify parameters by name
            }
            catch (FormatException) // formatting error
            {
                Console.WriteLine("Input must be an integer.");
            }
            catch(Exception ex) // all other errors
            {
                Console.WriteLine(ex.Message); 
            }
            
            Console.ReadLine(); // keep console open
        }
    }
}
