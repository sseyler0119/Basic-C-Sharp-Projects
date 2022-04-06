using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is it?"); // prompt user to enter day of the week
                string day = Console.ReadLine().ToLower(); // read in input from user, convert to lower, store in day
                day = CapitalizeFirstLetter(day); // captialize first letter
                DaysOfWeek current = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), day); // parse enum with passed in data stored in 'day'

                // if DayOfWeek exists, output data to console
                if (current == DaysOfWeek.Sunday || current == DaysOfWeek.Monday || current == DaysOfWeek.Tuesday ||
                    current == DaysOfWeek.Wednesday || current == DaysOfWeek.Thursday || current == DaysOfWeek.Friday ||
                    current == DaysOfWeek.Saturday)
                {
                    Console.WriteLine("Today is " + current);
                }
            }
            catch (ArgumentException) // invalid entry
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine(); // keep console open
        }
        /* function that reads in a string 's', converts it to a temporary char array, capitalizes the first character, 
         * then returns the char array back to the main program as a new string */
        public static string CapitalizeFirstLetter(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] temp = s.ToCharArray(); // convert string to temporary char array
            temp[0] = char.ToUpper(temp[0]); // capitalize first letter
            return new string(temp); // return converted string
        }

        // enum for days of the week
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
