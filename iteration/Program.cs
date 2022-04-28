using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for(int i = 0; i < testScores.Length; i++)
        {
            if(testScores[i] > 85) // passing score
            {
                Console.WriteLine("Passing score: " + testScores[i]);
            }
        }

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
        for(int j = 0; j < names.Length; j++)
        {
            Console.WriteLine(names[j]);
        }

        List<int> testScores1 = new List<int>();
        testScores1.Add(98);
        testScores1.Add(99);
        testScores1.Add(81);
        testScores1.Add(72);
        testScores1.Add(70);
        testScores1.Add(90);

        List<int> passingScores = new List<int>();

        foreach (int score in testScores1)
        {
            if(score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);


        List<string> names1 = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
        foreach(string name in names1)
        {
            if(name == "Jesse")
            {
                Console.WriteLine(name);
            }
        }

        Console.ReadLine();
    }
}

