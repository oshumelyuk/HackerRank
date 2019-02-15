using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 17, 13, 11, 2, 3, 5, 7 };
            var cards = RevealCardsInIncreasingOrder.Solve(nums);
            foreach (var res in cards)
            {
                Console.Write(res);
                Console.Write(" ");
            }

        }
    }
}