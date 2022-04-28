using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            using(StreamWriter file = new StreamWriter(@"C:\Users\sseyl\Desktop\Logs\log.txt", true))
            {
                file.WriteLine(number);
            }
            Console.WriteLine("Your number is: {0}", number);
            Console.ReadLine();
        }
    }
}
