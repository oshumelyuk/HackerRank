using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = MinimumDepthOfBinaryTree.Solve(BuildTree());
            Console.WriteLine(res);
        }

        private static TreeNode BuildTree()
        {
            var three = new TreeNode(3);
            var nine = new TreeNode(9);
            var twenty = new TreeNode(20);
            var fifteen = new TreeNode(15);
            var seven = new TreeNode(7);

            three.left = nine;
            three.right = twenty;
            twenty.left = fifteen;
            twenty.right = seven;
            return three;
        }
    }
}