using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Employee: Person
    {
        public int Id;
        

        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Id != e2.Id;
        }
    }
}
