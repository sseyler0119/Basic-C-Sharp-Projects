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
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; // instantiate and initialize Employee object
            employee.SayName(); // call SayName function on Employee object
            Console.ReadLine(); // keep console open
        }
    }
}
