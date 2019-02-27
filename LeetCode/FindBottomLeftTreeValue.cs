using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    static class FindBottomLeftTreeValue
    {
        public static int Solve(TreeNode root)
        {
            var candidates = new Dictionary<int, int>(); //key - level, value - value
            candidates.Add(0, root.val);
            VisitAllNodes(root, null, 1, candidates);

            var maxLevel = candidates.Keys.Max();
            return  candidates[maxLevel];
        }

        private static void VisitAllNodes(TreeNode root, TreeNode parent, int level, Dictionary<int, int> candidates)
        {
            candidates[level] = root.val;
            if (root.right != null) {
                VisitAllNodes(root.right, root, level +1, candidates);
            }
            if (root.left != null) {
                VisitAllNodes(root.left, root, level + 1, candidates);
            }
        }
    }
}
