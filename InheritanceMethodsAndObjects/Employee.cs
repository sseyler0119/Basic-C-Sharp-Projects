using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodsAndObjects
{
    public class Employee : Person, IQuittable // Employee class inherits from abstract Person class and IQuittable interface
    {
        public int Id;
        public string Department;

        /* Constructor 1 */
        public Employee(string fName, string lName) : this(fName, lName, "Unassigned")
        {

        }

        /* Constructor 2 */
        public Employee(string fName, string lName, string department)
        {
            FirstName = fName;
            LastName = lName;
            Department = department;
        }

        public override void SayName() // override abstract method from Person class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // implement Quit function with passed in Person object parameter
        public void Quit(Person person)
        {
            // employee quits! 
            Console.WriteLine(FirstName + " " + LastName + " has left the building!");
        }

        // overload '==' operator
        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }
        // overload '!=' operator
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Id != e2.Id;
        }
    }
}
