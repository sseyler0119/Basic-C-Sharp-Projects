using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int result = 0; // store result
            MathOp m = new MathOp(); // create and instantiate MathOp object

            Console.WriteLine("Enter an integer: ");
            try 
            {
                int number = Convert.ToInt32(Console.ReadLine()); // read in integer from user
                result = m.addTwo(number); // call addTwo function
                Console.WriteLine(number + " + 2 = " + result);
                result = m.multiplyByFive(number); // call multiplyByFive function
                Console.WriteLine(number + " * 5 = " + result);
                result = m.subtractSeven(number); // call subractSeven function
                Console.WriteLine(number + " - 7 = " + result);
                Console.ReadLine(); // keep console open
            }
            catch(FormatException) // incorrect format
            {
                Console.WriteLine("Input must be an integer.");
            }
            catch(Exception ex) // all other error messages
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine(); // keep console open
        }
    }
}
