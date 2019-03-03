using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    static class RangeSumBST
    {
        public static int Solve(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;
            var sum = GetCombinations(root, L, R);
            return sum;
        }

        private static int GetCombinations(TreeNode root, int min, int max)
        {
            var sum = 0;
            if (root.val >= min && root.val <= max) {
                sum += root.val;
            }
            if (root.left != null) {
                sum += GetCombinations(root.left, min, max);
            }
            if (root.right != null) {
                sum += GetCombinations(root.right, min, max);
            }
            return sum;
        }
    }
}
