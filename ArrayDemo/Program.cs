using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // declare and populate string array
        string[] strArray = { "Dog", "Cat", "Fish", "Snake", "Chinchilla", "Lizard" }; // 1d-string array of animals
        int[] numArray = { 20, 25, 30, 35, 40, 45, 50 }; // 1d-integer array
        List<string> strList = new List<string>();
        int len = 0; // number of array entries
        int index = 0; // index position


        /* This section asks the user to choose an index (that exists) from the string array and then displays 
          the contents at that position. */

        len = strArray.Length; // get length of string array
        // output number of entries in array, ask user to choose a position between 0 and lenth - 1
        Console.WriteLine("The array contains " + len + " entries. \nChoose a # between 0 and " + (len - 1) + " to display the contents at that position: ");
        index = Convert.ToInt32(Console.ReadLine()); // get integer value of position
        while(index < 0 || index > (len-1))
        {
            Console.WriteLine("Index is out-of-bounds. Please pick an index between 0 and " + (len - 1) + ".");
            index = Convert.ToInt32(Console.ReadLine()); // get integer value of position
        }
        Console.WriteLine("Index # " + index + " contains: " + strArray[index]); //output contents at position

        /* This section asks the user to choose an index (that exists) from the integer array and then displays 
          the contents at that position. */

        len = numArray.Length; // get length of integer array                               
        // output number of entries in array, ask user to choose a position between 0 and lenth - 1
        Console.WriteLine("The array contains " + len + " entries. \nChoose a # between 0 and " + (len - 1) + " to display the contents at that position: ");
        index = Convert.ToInt32(Console.ReadLine()); // get integer value of position
        while (index < 0 || index > (len - 1))
        {
            Console.WriteLine("Index is out-of-bounds. Please pick an index between 0 and " + (len - 1) + ".");
            index = Convert.ToInt32(Console.ReadLine()); // get integer value of position
        }
        Console.WriteLine("Index # " + index + " = " + numArray[index]); //output contents at position

        /* This section populates a list with colors, then prompts the user to choose an index position and displays the contents of 
            the list at that position */
        
        // populate list with colors
        strList.Add("Red");
        strList.Add("Orange");
        strList.Add("Yellow");
        strList.Add("Green");
        strList.Add("Blue");
        strList.Add("Purple");

        // get list size
        len = strList.Count;

        Console.WriteLine("The list of colors contains " + len + " entries. \nChoose a # between 0 and " + (len - 1) + " to display the contents at that position: ");
        index = Convert.ToInt32(Console.ReadLine()); // get integer value of position
        while (index < 0 || index > (len - 1))
        {
            Console.WriteLine("Index is out-of-bounds. Please pick an index between 0 and " + (len - 1) + ".");
            index = Convert.ToInt32(Console.ReadLine()); // get integer value of position
        }
        Console.WriteLine("Index # " + index + " = " + strList[index]); //output contents at position

        Console.ReadLine(); // keep console open
    }
}

