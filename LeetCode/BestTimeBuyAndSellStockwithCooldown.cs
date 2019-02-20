using System;

namespace LeetCode
{
    static class BestTimeBuyAndSellStockwithCooldown
    {
        //from https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/discuss/75931/Easiest-JAVA-solution-with-explanations
        public static int Solve(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;

            int b0 = -prices[0], b1 = b0;
            int s0 = 0, s1 = 0, s2 = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                b0 = Math.Max(b1, s2 - prices[i]);
                s0 = Math.Max(s1, b1 + prices[i]);
                b1 = b0; s2 = s1; s1 = s0;
            }
            return s0;
        }

    }
}
