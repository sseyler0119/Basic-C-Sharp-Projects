using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Serena ";
            string quote = @"Hi there, \look\ at this."; // @ tells the compiler that everything in the quotes is part of string

            bool trueOrFalse = name.Contains("S");
            Console.WriteLine(trueOrFalse);
            trueOrFalse = name.EndsWith("s");
            Console.WriteLine(trueOrFalse);
            int length = name.Length;
            Console.WriteLine(length);
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.WriteLine(quote);
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Serena");
            sb.Append("\nToday I am writing a basic C# app.");
            sb.Append("\tIn this particular app, I am testing strings and the StringBuilder function");
            sb.Append("\n\tI just added another line.");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
