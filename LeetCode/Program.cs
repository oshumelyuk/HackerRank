using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 0, 1, 2, 3, 3, 4, 7, 7, 8};
            var res = FindKClosestElements.Solve(nums, 3, 5);
            foreach (var num in res)
            {
                Console.WriteLine(num);
            }

        }
    }
}