using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = new DateTime(); // create and initialize new DateTime object
            currentTime = DateTime.Now; // get current time
            Console.WriteLine("The current time is: {0:dd} {0:y}, {0:t}", currentTime); // format current time and output to console
            Console.WriteLine("Enter a number:"); // get number from user
            int hours = Convert.ToInt32(Console.ReadLine()); // convert input to integer
            DateTime future = currentTime.AddHours(hours); // create new DateTime object and add user input to current time in hours
            Console.Write("In {0}", hours); // display number of hours to console, keep on one line
            Console.Write(" it will be: {0:dd} {0:y}, {0:t}", future); // format future time and display to console on same line
            Console.ReadLine(); // keep console from closing
        }
    }
}
