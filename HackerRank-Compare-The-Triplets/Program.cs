using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_Compare_The_Triplets
{
    class Program
    {
        static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            //List of integers to store the scores. Scores set to 0 at default
            List<int> scores = new List<int>() { 0, 0 };

            //For loop to see if one element is greater than the other. Program will increment score if this is the case.
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) scores[0]++;
                else if (a[i] < b[i]) scores[1]++;
            }

            return scores;
        }

            static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //For the user to input the first integer element into the console
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            //For the user to input the second integer element into the console
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            //Prints out the score comparisons
            List<int> result = CompareTriplets(a, b);

            //Prints out the final result between the two elements
            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();

            //To prevent the console from automatically closing upon completion of program
            Console.Read();
        }
    }
}
