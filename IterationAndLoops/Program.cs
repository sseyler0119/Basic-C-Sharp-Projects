using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Part One: Create a one-dimensional array of strings, get input from user
             *      Iterate through the array, append input to strings in array
             *      Output each string to console
             */
            int i = 0;
            string[] people = { "Beth", "Thomas", "Vanessa", "Molly", "Ben", "Troy" };
            string input = " ";

            Console.WriteLine("Enter an animal: ");
            input = Console.ReadLine(); // read in input from user

            for (i = 0; i < people.Length; i++)
            {
                people[i] = people[i] + " would like a " + input; // append string and input to array contents
            }
            for (int j = 0; j < people.Length; j++)
            {
                Console.WriteLine(people[j]); // output contents to screen
            }

            /* Part Two: Create an infinite loop, then fix so it executes correctly
             */
            int count = 0;
            while (count < 10) 
            {
                count++; // increment count so condition is met and loop will terminate 
                Console.WriteLine(count); // output count to console
            }

            /* Part Three: Create a loop that uses the < comparison operator, 
             * then create a loop that uses <= comparison operator
             */
            int apples = 0;

            while (apples < 10)
            {
                apples++;
            }
            Console.WriteLine(apples + " apples were added to your basket.");

            count = 0;
            while(apples <= 15) // we already have 10 apples, now we need to see how many rounds to get to 15
            {
                apples++; 
                count++;
            }
            Console.WriteLine("It took " + count  +" more rounds to  get to 15 apples.");

            /* Part Four: Create a list of strings where each item is unique, get input from user to search list
             * Iterate through list and display index of matching item (if it exists)
             * Determine if item is not in list, notifiy user of result
             * Stop loop from executing once a match has been found
             */

            List<string> animals = new List<string>{ "lion", "tiger", "monkey", "elephant", "flamingo", "python" };
            i = 0;
            bool found = false; 

            Console.WriteLine("Search for an animal in the list: ");
            input = Console.ReadLine().ToLower();
            while(!found)
            {
                foreach (string animal in animals)
                {
                    if (animal == input) // match found
                    {
                        // display index position
                        Console.WriteLine(input + " was found at index " + i);
                        found = true;
                        break; 
                    }
                    i++; // iterate i
                }
                if (!found) // animal was not in list
                {
                    Console.WriteLine(input + " was not in the list.");
                    break; // break from loop
                }
            }

            /* Part Five: Create a list of strings where at least two strings are identical, get input from user to search list
             * Iterate through list and display indices of matching items (if match exists)
             * Determine if item is not in list, notifiy user of result
             */
            List<string> ingredients = new List<string> { "flour", "sugar", "butter", "chocolate", "sugar", "baking powder" };
            i = 0;
            found = false;

            Console.WriteLine("Search for an ingredient in the list: ");
            input = Console.ReadLine().ToLower();
            
            foreach (string ingredient in ingredients)
            {
                if (ingredient == input) // match found
                {
                    // display index position
                    Console.WriteLine(input + " was found at index " + i);
                    found = true;
                }
                i++; // iterate i
            }
            if (!found) // ingredient was not in list
            {
                Console.WriteLine(input + " was not in the list.");
            }

            /* Part Six: Create a list of strings where at least two strings are identical, 
             * Iterate through list using a foreach loop that displays a message showing the 
             * string and if it has already appeared in the list 
             */

            List<string> dailyMenu = new List<string> { "apple", "eggs", "toast", "coffee", "water", "apple", "cheese", "water", "peanut butter", "jam", "bread", "chicken", "salad", "water", "rice", "wine", "chocolate", "almonds"};

            List<string> duplicates = new List<string>(); // empty list to hold duplicates

            Console.WriteLine("\nShow whether an item has already appeared in this list: ");
            foreach(string item in dailyMenu) // iterate through each item in the list
            {
                if (duplicates.Contains(item)) // duplicate item
                {
                    Console.WriteLine("DUPLICATE: " + item + " has already appeared in the list.");
                }
                else // first appearance in list
                {
                    Console.WriteLine("* " + item + " has NOT already appeared in the list.");
                    duplicates.Add(item); // add to duplicates list
                }
            }
            Console.ReadLine(); // keep console open
        }
    }
}
