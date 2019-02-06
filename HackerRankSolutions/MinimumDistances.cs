using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRankSolutions
{
    internal class MinimumDistances
    {
        public static int minimumDistances(int[] a)
        {
            var processedNumbers = new Dictionary<int, int>(a.Length);
            var minDistance = int.MaxValue;
            for (var i = 0; i < a.Length; i++)
            {
                if (processedNumbers.ContainsKey(a[i]))
                {
                    var distance = i - processedNumbers[a[i]];
                    if (minDistance > distance) {
                        minDistance = distance;
                    }
                }
                processedNumbers[a[i]] = i;
            }
            return minDistance == int.MaxValue ? -1 : minDistance;
        }

        public static void Solve(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int result = minimumDistances(a);
        }
    }
}
