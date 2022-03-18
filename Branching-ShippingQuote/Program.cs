using System;

namespace Branching_ShippingQuote
{
    class Program
    {
        static void Main()
        {
            // declare and initialize variables
            short weight = 0, height = 0, width = 0, length = 0, dimensions = 0; // package attributes
            double cost = 0.0; // shipping cost
            string temp = ""; // temporary string variable

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: "); // get package weight
            temp = Console.ReadLine();
            weight = short.Parse(temp); // convert string to short

            if(weight > 50) // package too heavy
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else // continue, ask for package dimensions
            {
                Console.WriteLine("Please enter the package width: ");
                temp = Console.ReadLine();
                width = short.Parse(temp); // convert string to short
                Console.WriteLine("Please enter the package height: ");
                temp = Console.ReadLine();
                height = short.Parse(temp); // convert string to short
                Console.WriteLine("Please enter the package length: ");
                temp = Console.ReadLine();
                length = short.Parse(temp); // convert string to short
                dimensions = (short)(width + height + length); // calculate total dimensions

                if(dimensions > 50) // package too large to ship
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    cost = (double)((width * height * length * weight)/100); // calculate cost, convert value to double
                    // display shipping cost, format cost to two decimal places
                    Console.WriteLine("Your estimated total for shipping this package is: $" + cost.ToString("0.00") + "\nThank you!");
                }
            }

            Console.ReadLine(); // keep console from closing
        }
    }
}
