using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            // declare and initialize variables
            string temp = ""; 
            double payRate = 0.0;
            byte hoursWorked = 0; 
            double salary1 = 0.0, salary2 = 0.0;
            bool compareSalary = false;

            Console.WriteLine("Anonymous Income Comparison Program"); // write program name to screen
            /* Collect user input for person1, then calculate salary (payrate * hoursWorked * 52 weeks per year) */
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly wage: ");
            temp = Console.ReadLine();
            payRate = double.Parse(temp); // convert payrate to double
            Console.WriteLine("Enter number of hours worked per week: ");
            temp = Console.ReadLine();
            hoursWorked = byte.Parse(temp); // convert hours worked to byte
            salary1 = payRate * hoursWorked * 52; // calculate annual salary of person 1

            /* Collect user input for person2, then calculate salary (payrate * hoursWorked * 52 weeks per year)*/
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly wage: ");
            temp = Console.ReadLine();
            payRate = double.Parse(temp); // convert payrate to double
            Console.WriteLine("Enter number of hours worked per week: ");
            temp = Console.ReadLine();
            hoursWorked = byte.Parse(temp); // convert hours worked to byte
            salary2 = payRate * hoursWorked * 52; // calculate annual salary of person 2

            Console.WriteLine("Annual salary of Person 1:\n" + salary1);
            Console.WriteLine("Annual salary of Person 2:\n" + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n");
            compareSalary = salary1 > salary2;
            Console.WriteLine(compareSalary);
            Console.ReadLine(); // prevent console from closing 

        }
    }
}
