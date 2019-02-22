using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    static class SingleElementInSortedArray
    {
        public static int Solve(int[] nums)
        {
            int res = 0;
            foreach (var num in nums) {
                res = res ^ num;
            }
            return res;
        }
    }
}
