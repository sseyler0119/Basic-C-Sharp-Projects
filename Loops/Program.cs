using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dye = new Random(); // create random dye object
            int rollDice = 0; // rollDice variable to hold random number
            int count = 0; // counter
            char temp = ' '; // var to read in char input

            Console.WriteLine("How many tries will it take you to roll a 6?"); // output program purpose statement to console

            do // do-while loop, keep rolling dye until a 6 is rolled
            {
                rollDice = dye.Next(1, 7); // random roll between 1-6
                count++; // increment count for each roll 

                switch (rollDice)
                {
                    case 1:
                        Console.WriteLine("You rolled 1");
                        break;
                    case 2:
                        Console.WriteLine("You rolled 2");
                        break;
                    case 3:
                        Console.WriteLine("You rolled 3");
                        break;
                    case 4:
                        Console.WriteLine("You rolled 4");
                        break;
                    case 5:
                        Console.WriteLine("You rolled 5");
                        break;
                    case 6: // roll a 6
                        Console.WriteLine("FINALLY! You rolled a 6!");
                        Console.WriteLine("Should we try again (y/n)?"); // prompt user for input
                        temp = Console.ReadLine()[0]; // read in input from user
                        while(temp != 'n' && temp != 'N') // as long as answer is not 'no', keep running loop
                        {
                            // offer nothing of value other than staying in this loop forever
                            Console.WriteLine("...and around and around we go!");
                            Console.WriteLine("Are you sure (y/n)? We'll be stuck in this loop until you say no.");
                            temp = Console.ReadLine()[0];
                        }
                        Console.WriteLine("Thank you, we are finally free of this loop!"); 
                        break;
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }
            } while (rollDice != 6);

            // output number of attempts to roll a 6
            Console.WriteLine("It took you " + count + " tries to roll a 6.");
            Console.ReadLine(); // keep console from closing
        }
    }
}
