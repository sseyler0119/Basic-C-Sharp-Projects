using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate and initialize Employee object

            /* test operator == overload */
            employee.FirstName = "Joe";
            employee.LastName = "Smith";
            employee.Id = 100;

            Employee employee2 = new Employee();
            employee2.FirstName = "Sandra";
            employee2.LastName = "Thomas";
            employee2.Id = 101;


            Employee employee3 = new Employee();
            employee3.FirstName = "Sandra";
            employee3.LastName = "Thomas";
            employee3.Id = 101;

            Console.WriteLine("Testing '==' operator:\n\nTest1: \nCompare employee and employee2");
            if (employee == employee2) // this should be false
            {
                Console.WriteLine("This is the same employee Id");
                Console.WriteLine(employee.Id + " == " + employee2.Id);
            }
            else // this should be true
            {
                Console.WriteLine("These are two different employee Ids");
                Console.WriteLine(employee.Id + " != " + employee2.Id);
            }

            Console.WriteLine("\nTest 2: \nCompare employee2 and employee3");
            if (employee2 == employee3) // this should be true
            {
                Console.WriteLine("This is the same employee Id");
                Console.WriteLine(employee2.Id + " == " + employee3.Id);
            }
            else // this should be false
            {
                Console.WriteLine("These are two different employee Ids");
                Console.WriteLine(employee2.Id + " != " + employee3.Id);
            }

            //prompt user to enter first and last name
            //Console.WriteLine("Enter first name: ");
            //employee.FirstName = Console.ReadLine(); // read in input, store as FirstName
            //Console.WriteLine("Enter last name: ");
            //employee.LastName = Console.ReadLine(); // read in input, store as LastName

            //employee.SayName(); // call SayName function on Employee object

            //employee.Quit(employee); // call Quit function from IQuittable interface on Employee object

            Console.ReadLine(); // keep console open
        }
    }
}
