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
            /* Task 1: Create const variable */
            const string company = "HCS Financial Services"; // constant string variable
            Console.WriteLine("Welcome to {0}, please enter employee information: ", company);

            /* Enter employee information for employee 1 */
            Console.WriteLine("Enter First Name: "); // get first name from user
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: "); // get last name from user
            string lastName = Console.ReadLine();

            /* Task 3: Part 1 Chain two constructors together */ 
            Employee employee = new Employee(firstName, lastName); // create employee object, instantiate using constructor 1 
            
            // output employee object to console using "default Department assignment" from constructor 1
            Console.WriteLine(employee.FirstName + " " + employee.LastName + "\nDepartment: " + employee.Department);

            /* assign variables for second employee */
            firstName = "Sally";
            lastName = "Thompson";
            string department = "Accounting";

            /* Task 2: Create a variable using the keyword "var" 
               * Task 3: Part 2, Chain two constructors together */
            var employee1 = new Employee(firstName, lastName, department); // create employee object using var, instantiate with constructor 2

            // output employee1 object to console using user-defined variables from constructor 2
            Console.WriteLine(employee1.FirstName + " " + employee1.LastName + "\nDepartment: " + employee1.Department);

            Console.ReadLine(); // keep console open
        }
    }
}
