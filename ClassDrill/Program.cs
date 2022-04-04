using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionClass obj1 = new FunctionClass(); // create class object and instantiate it
            
            try
            {
                Console.WriteLine("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine()); // get input from user as integer
                obj1.integerOutput(num);
                // call method with output parameters
                int output = 0;
                obj1.outputDemo(out output);
                Console.WriteLine("Output = " + output);

                // call overloaded method
                Console.WriteLine("Enter an integer: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another integer: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                obj1.integerOutput(num, num2);

                // call temperature converter function from static class
                Console.WriteLine("Enter current temperature in degrees Fahrenheit: ");
                double temp = Convert.ToDouble(Console.ReadLine());
                double celsius = TemperatureConverter.fahrenheitToCelsius(temp);
                Console.WriteLine(temp + " degrees F = " + celsius + " degrees C.");
            }
            catch(FormatException ex) // format error
            {
                Console.WriteLine("Invalid format: " + ex.Message);
            }
            catch(Exception ex) // all other errors
            {
                Console.WriteLine(ex.Message); 
            }
            Console.ReadLine(); // keep console open
        }
    }
}
