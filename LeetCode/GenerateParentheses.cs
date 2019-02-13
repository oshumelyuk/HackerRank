using System.Collections.Generic;

namespace LeetCode
{
    static class GenerateParentheses
    {
        public static IList<string> Solve(int n)
        {
            var allCombinations = GetCombinations(n);
            return allCombinations;
        }

        private static IList<string> GetCombinations(int n)
        {
            if (n == 1)
            {
                return new[] { "()" };
            }
            else
            {
                var previousSolutionCombs = GetCombinations(n - 1);
                var currentSolutionCombs = new List<string>(previousSolutionCombs.Count * 2);
                foreach (var comb in previousSolutionCombs)
                {
                    currentSolutionCombs.Add("(" + comb + ")");
                    currentSolutionCombs.Add(comb + "()");
                    if (comb + "()" != "()" + comb)
                    {
                        currentSolutionCombs.Add("()" + comb);
                    }
                }
                return currentSolutionCombs;
            }
        }
    }
}
