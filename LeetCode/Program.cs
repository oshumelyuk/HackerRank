using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 0, 2 };
            var profit = BestTimeBuyAndSellStockwithCooldown.Solve(nums);
            Console.WriteLine(profit);
        }
    }
}