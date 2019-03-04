using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = KeysAndRooms.Solve(new [] { new int[]{1,3 }, new int[] { 3, 0, 1}, new int[] { 2}, new int[] { 0 } });
            Console.WriteLine(res);
        }

        private static TreeNode BuildTree()
        {
            var one = new TreeNode(1);
            var two = new TreeNode(2);
            var three = new TreeNode(3);
            var four = new TreeNode(4);
            var five = new TreeNode(5);
            var six = new TreeNode(6);
            var seven = new TreeNode(7);

            one.left = two;
            one.right = three;
            two.left = four;
            three.left = five;
            three.right = six;
            five.left = seven;

            return one;
        }
    }
}