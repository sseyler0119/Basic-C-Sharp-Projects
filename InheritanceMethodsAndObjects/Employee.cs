using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodsAndObjects
{
    public class Employee : Person // Employee class inherits from abstract Person class
    {
        public int Id;

        public override void SayName() // override abstract method from Person class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
