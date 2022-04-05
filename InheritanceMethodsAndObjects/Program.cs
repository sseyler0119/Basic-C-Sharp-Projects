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

            Console.WriteLine("Testing '==' operator: \nCompare employee and employee2");
            if (employee == employee2) // this should be false
            {
                Console.WriteLine("This is the same employee");
                Console.WriteLine(employee.Id + " == " + employee2.Id);
            }
            else // this should be true
            {
                Console.WriteLine("These are two different people");
                Console.WriteLine(employee.Id + " != " + employee2.Id);
            }
            if (employee == employee) // same employee id, should be true
            {
                Console.WriteLine(employee.Id + " = " + employee.Id);
            }
            else // should be false
            {
                Console.WriteLine("These are two different people");
                Console.WriteLine(employee.Id + " != " + employee.Id); // impossible
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
