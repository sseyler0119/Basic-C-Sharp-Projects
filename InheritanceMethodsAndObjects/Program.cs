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

            /* Employee<string> thing1 = new Employee<string>();
            thing1.things = new List<string> { "cup", "bowl", "pencil", "plant", "bird"};
            
            Employee<int> thing2 = new Employee<int>();
            thing2.things = new List<int> { 1, 0, 10, 11, 100, 110, 101, 111 };

            // output string list
            Console.WriteLine("\nList of String things: \n");
            foreach (string item in thing1.things)
            {
                Console.WriteLine(item);
            }

            // output int list
            Console.WriteLine("\nList of Integer things: \n");
            foreach(int item in thing2.things)
            {
                Console.WriteLine(item);
            }
            */
            
            //prompt user to enter first and last name
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
