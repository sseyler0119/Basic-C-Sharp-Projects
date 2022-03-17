using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize variables
            string name = "";
            string course = "";
            short pageNum = 0;
            bool needHelp = false;
            string posExperience = "";
            string feedback = "";
            byte hours = 0;
            string tempVar = "";

            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();
            Console.WriteLine("What page number?");
            tempVar = Console.ReadLine();
            pageNum = short.Parse(tempVar); // convert page number to short
            Console.WriteLine("Do you need help with anythign? Please answer \"true\" or \"false.\"");
            tempVar = Console.ReadLine();
            needHelp = bool.Parse(tempVar); // convert to boolean value
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            posExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            tempVar = Console.ReadLine();
            hours = byte.Parse(tempVar);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // keep console from automatically closing
        }
    }
}
