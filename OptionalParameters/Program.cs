using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Options x = new Options(); // create Options object and instantiate
            int result = 0; // var to store result

            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine()); // get input as integer
            Console.WriteLine("Would you like to enter a second number (y/n)?"); // ask if user wants to enter second number
            char input = Console.ReadLine().ToLower()[0]; // read in character input, convert to lowercase
            
            if(input == 'y') // get second number from user
            {
                Console.WriteLine("Please enter a second integer: ");
                int number2 = Convert.ToInt32(Console.ReadLine()); // get input as integer
                result = x.addTwoNumbers(number, number2); // call addTwoNumbers function, pass in both numbers, store as result
                Console.WriteLine(number + " + " + number2 + " = " + result); // output both numbers and result to console
            }
            else // just pass in first number
            {
                result = x.addTwoNumbers(number); // call addTwoNumbers function, pass in number, store as result
                Console.WriteLine(number + " + 0  = " + result); // output number and result to console
            }
            
            Console.ReadLine(); // keep console open
        }
    }
}
