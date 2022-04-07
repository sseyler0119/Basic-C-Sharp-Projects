using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>(); // employee list
            List<Employee> joeList = new List<Employee>(); // list of joes

            /* add 10 employees to list */
            employeeList.Add(new Employee { FirstName = "Janice", LastName = "Smith", Id = 1 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Bradford", Id = 2 });
            employeeList.Add(new Employee { FirstName = "Candice", LastName = "Epp", Id = 3 });
            employeeList.Add(new Employee { FirstName = "Carol", LastName = "Johnson", Id = 4 });
            employeeList.Add(new Employee { FirstName = "Diane", LastName = "Ginsburg", Id = 5 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Sobell", Id = 6 });
            employeeList.Add(new Employee { FirstName = "Sam", LastName = "Hall", Id = 7 });
            employeeList.Add(new Employee { FirstName = "Chris", LastName = "Hoffmann", Id = 8 });
            employeeList.Add(new Employee { FirstName = "John", LastName = "Stone", Id = 9 });
            employeeList.Add(new Employee { FirstName = "Linda", LastName = "Rock", Id = 10 });
            
            /* Using a foreach loop, add employees to a joeList if their first name "Joe"*/
            foreach(Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                    joeList.Add(employee);
            }
            Console.WriteLine("Resulting list from foreach loop:");
            foreach (Employee joe in joeList) // output resulting list to console
            {
                Console.WriteLine("Id: " + joe.Id + " " + joe.FirstName + " " + joe.LastName);
            }

            /* Using a lambda expression, if first name = "Joe" add Joes to listOfJoes */
            List<Employee> listOfJoes = employeeList.Where(joe => joe.FirstName == "Joe").ToList();
            
            Console.WriteLine("\nResulting list from lambda expression: ");
            foreach(Employee employee in listOfJoes) // output resulting list to console
            {
                Console.WriteLine("Id: " + employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }

            /* Using a lambda expression, add all employees with Id > 5 to idList */
            List<Employee> idList = employeeList.Where(emp => emp.Id > 5).ToList();

            Console.WriteLine("\nList of employees with Id > 5: ");
            foreach(Employee employee in idList) // output resulting list to console
            {
                Console.WriteLine("Id: " + employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine(); // keep console open
        }
    }
}
