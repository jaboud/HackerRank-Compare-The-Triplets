using System;
using System.Collections.Generic;

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
            
        }
    }
}
