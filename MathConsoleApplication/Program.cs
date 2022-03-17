using System;

namespace MathConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int num1 = 0, result = 0;
            double quotient = 0.0;
            bool comparison = false;
            string temp = "";

            Console.WriteLine("Please enter an integer: ");
            temp = Console.ReadLine(); // get input from user
            num1 = int.Parse(temp); // convert to integer
            result =  num1 * 50; // calculate product
            Console.WriteLine(temp + " * 50 = " + result);

            Console.WriteLine("Please enter an integer: ");
            temp = Console.ReadLine(); // get input from user
            num1 = int.Parse(temp); // convert to integer
            result = num1 + 25; // calculate product
            Console.WriteLine(temp + " + 25 = " + result);

            Console.WriteLine("Please enter a number: ");
            temp = Console.ReadLine(); // get input from user
            num1 = int.Parse(temp); // convert to integer
            quotient = num1 / 12.5; // calculate quotient
            Console.WriteLine(temp + " / 12.5 = " + quotient);


            Console.WriteLine("Please enter an integer: ");
            temp = Console.ReadLine(); // get input from user
            num1 = int.Parse(temp); // convert to integer
            comparison = num1 > 50; // is num1 greater than 50
            Console.WriteLine(temp + " > 50 = " + comparison);

            Console.WriteLine("Please enter an integer: ");
            temp = Console.ReadLine(); // get input from user
            num1 = int.Parse(temp); // convert to integer
            result = num1 % 7; // calculate remainder, store as result
            Console.WriteLine(temp + " % 7 = " + result);

            Console.ReadLine();
        }
    }
}
