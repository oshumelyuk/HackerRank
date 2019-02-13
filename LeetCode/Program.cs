using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var len = LongestSubstringWithoutRepeatingCharacters.Solve(Console.ReadLine());
            var comb = GenerateParentheses.Solve(int.Parse(Console.ReadLine()));
            foreach (var res in comb)
            {
                Console.WriteLine(res);
            }

        }
    }
}