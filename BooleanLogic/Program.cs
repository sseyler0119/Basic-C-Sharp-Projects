using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            // declare and intialize variables
            byte age = 0; // applicant age
            bool hasDUI= false; // var that states if applicant has a DUI
            byte speedingTickets = 0; // number of speeding tickets applicant has
            string temp = ""; // temp var to read in string
            char getChar = ' '; // temp var to read in char
            bool dataChecker = false; // validates input

            // ask user for age
            Console.WriteLine("What is your age?");
            temp = Console.ReadLine();
            dataChecker = byte.TryParse(temp, out age);
            
            while(!dataChecker) // verify input is an integer
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
                Console.WriteLine("What is your age?");
                temp = Console.ReadLine();
                dataChecker = byte.TryParse(temp, out age);
            }
            

            // ask user about DUI status
            Console.WriteLine("Have you ever had a DUI? (please enter 'y' for Yes or 'n' for No)");
            getChar = Console.ReadLine()[0]; // read in char from user
            
            // validate char is yes or no
            while(getChar != 'y' && getChar != 'Y' && getChar != 'n' && getChar != 'N')
            {
                Console.WriteLine("Invalid input! Answer must be either 'y' or 'n'.");
                Console.WriteLine("Have you ever had a DUI? (please enter 'y' for Yes or 'n' for No)");
                getChar = Console.ReadLine()[0]; // read in char from user
            }
                        
            // check condition, if getChar = y or Y, hasDUI = true
            if(getChar == 'y' || getChar == 'Y')
            {
                hasDUI = true;
            }
            else if (getChar == 'n' || getChar == 'N')
            {
                hasDUI = false;
            }

            // ask user about number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            temp = Console.ReadLine();
            dataChecker = byte.TryParse(temp, out speedingTickets);
            
            while (!dataChecker) // verify input is an integer
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
                Console.WriteLine("How many speeding tickets do you have?");
                temp = Console.ReadLine();
                dataChecker = byte.TryParse(temp, out speedingTickets);
            }

            /* Determine if applicant qualifies for car insurance 
                Applicant > 15, must have no DUIs, and have less than 3 speeding tix */

            if(age > 15 && hasDUI == false && speedingTickets <= 3)
            {
                Console.WriteLine("Congratulations! Applicant qualifies for car insurance.");
            }
            else
            {
                Console.WriteLine("Applicant is NOT qualified for car insurance at this time.");
            }
            Console.ReadLine(); // keep console from closing
        }
    }
}
