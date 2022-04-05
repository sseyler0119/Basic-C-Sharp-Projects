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

            // prompt user to enter first and last name
            Console.WriteLine("Enter first name: ");
            employee.FirstName = Console.ReadLine(); // read in input, store as FirstName
            Console.WriteLine("Enter last name: ");
            employee.LastName = Console.ReadLine(); // read in input, store as LastName

            employee.SayName(); // call SayName function on Employee object

            employee.Quit(employee); // call Quit function from IQuittable interface on Employee object

            Console.ReadLine(); // keep console open
        }
    }
}
