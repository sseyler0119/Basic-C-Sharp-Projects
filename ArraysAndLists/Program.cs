using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;
        Console.WriteLine(numArray[3]);

        int[] numArray1 = new int[] { 6, 40, 65, 2500 };
        int[] numArray2 = { 6, 66, 666, 6666, 666, 66, 6 };
        numArray2[2] = 999;
        Console.WriteLine(numArray2[2]);


        // lists
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(14);
        Console.WriteLine(intList[0]);
        Console.ReadLine();
    }
}

