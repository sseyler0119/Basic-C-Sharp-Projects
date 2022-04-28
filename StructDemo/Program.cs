using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers amount = new Numbers();
            amount.Amount= 6.675650m;
            Console.WriteLine(amount.Amount);
            Console.ReadLine(); // keep console open
        }
    }
}
