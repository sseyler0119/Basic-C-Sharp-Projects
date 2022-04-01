using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>{1,15,220,630,450,-7,-5,42}; // list of integers
               
        try
        {
            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine()); // read in user input as integer
            int result = 0;
            foreach (int i in integers) // iterate through integer list
            {
                result = i / number; // divide each integer 'i' in list by 'number', store in 'result'
                Console.WriteLine(i + " / " + number + " = " + result); // output result to console
            }
            Console.ReadLine(); // keep console open
        }
        catch(FormatException) // incorrect input format
        {
            Console.WriteLine("Must enter a non-zero integer.");
        }
        catch(DivideByZeroException) // divide by zero exception
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        catch(Exception ex) // all other errors
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Break from try/catch block!"); // display message outside of block
        Console.ReadLine(); // keep console open
    }
}

