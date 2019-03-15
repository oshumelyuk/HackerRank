using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    static class MinimumDepthOfBinaryTree
    {
        public static int Solve(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var pathes = new List<int>();
            FindMinLength(root, pathes, 0);
            return pathes.Min();
        }

        private static void FindMinLength(TreeNode root, List<int> pathes, int level)
        {
            level++;
            if (root.left == null && root.right == null)
            {
                pathes.Add(level);
                return;
            }
            if (root.left != null)
            {
                FindMinLength(root.left, pathes, level);
            }
            if (root.right != null)
            {
                FindMinLength(root.right, pathes, level);
            }

        }
    }
}
