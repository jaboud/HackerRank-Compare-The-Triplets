using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_Compare_The_Triplets
{
    class Program
    {
        static int[] CompareTriplets(int[] a, int[] b)
        {
            //List of integers to store the scores. Scores set to 0 at default
            int[] scores = new int[] { 0, 0 };

            //For loop to see if one element is greater than the other. Program will increment score if this is the case.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                    scores[0]++;
                else
                    scores[1]++;
            }

            return scores;
        }

        static void Main(string[] args)
        {
            using (TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true))
            {
                //For the user to input the first integer element into the console
                int[] a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToArray();

                //For the user to input the second integer element into the console
                int[] b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToArray();

                //Prints out the score comparisons
                int[] result = CompareTriplets(a, b);

                //Prints out the final result between the two elements
                textWriter.WriteLine(String.Join(" ", result));

                textWriter.Flush();
                textWriter.Close();
            }

            //To prevent the console from automatically closing upon completion of program
            Console.Read();
        }
    }
}
