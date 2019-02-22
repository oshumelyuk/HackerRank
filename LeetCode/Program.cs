using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 3, 3, 7, 7, 10, 11, 11 };
            var res = SingleElementInSortedArray.Solve(nums);
            Console.WriteLine(res);
        }
    }
}