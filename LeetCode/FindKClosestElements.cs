using System;
using System.Collections.Generic;

namespace LeetCode
{
    static class FindKClosestElements
    {
        public static int[] Solve(int[] arr, int k, int x)
        {
            if (k >= arr.Length || arr.Length == 0)
            {
                return arr;
            }

            var indexOfElem = IndexOf(arr, x);
            var startingPoint = indexOfElem - ((int)Math.Ceiling(k / 2.0));
            if (startingPoint < 0)
            {
                startingPoint = 0;
            }
            if (startingPoint + k > arr.Length) {
                startingPoint = arr.Length - k;
            }

            var subArr = SubArray(arr, startingPoint, k, indexOfElem);
            return subArr;
        }

        private static int[] SubArray(int[] arr, int startingPoint, int k, int excludeIndex)
        {
            var subArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                subArr[i] = arr[startingPoint + i];
            }
            return subArr;
        }

        private static int IndexOf(int[] arr, int x)
        {
            var searchIndex = arr.Length / 2;
            var len = arr.Length / 2;
            var newSearchIndex = 0;
            do
            {
                if (x == arr[searchIndex]) { return searchIndex; }
                if (x < arr[searchIndex]) { newSearchIndex = searchIndex - (int)Math.Floor(Math.Abs(searchIndex - newSearchIndex) / 2.0); }
                if (x > arr[searchIndex]) { newSearchIndex = searchIndex + (int)Math.Floor(Math.Abs(searchIndex - newSearchIndex) / 2.0); }

                if (newSearchIndex == searchIndex)
                {
                    return -1;
                }
                var temp = newSearchIndex;
                newSearchIndex = searchIndex;
                searchIndex = temp;
            } while (true);
        }
    }
}
