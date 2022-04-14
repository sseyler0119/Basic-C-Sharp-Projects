using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = 0;
                bool validAnswer = false;
                while (!validAnswer)
                {
                    Console.WriteLine("Enter your age: ");
                    validAnswer = int.TryParse(Console.ReadLine(),out age); // verify age is in integer format
                    if (!validAnswer)
                        Console.WriteLine("Please enter digits only, no decimals.");
                    if(age <= 0) // age must be greater than 0
                    {
                        Console.WriteLine("Age must be a digit greater than 0.");
                        validAnswer = false;
                    }
                }
                if(validAnswer)
                {
                    DateTime currentDay = new DateTime();
                    currentDay = DateTime.Today;
                    DateTime getYear = currentDay.AddYears(-age); // get birth year by subtracting current age
                    int birthYear = getYear.Year; // store birth year as int
                    Console.WriteLine("You were born in the year: " + birthYear);
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Age must be a digit greater than 0.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
