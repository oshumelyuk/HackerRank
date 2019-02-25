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

            var indexOfElem = x <= arr[0] ? 0 : IndexOf(arr, x);

            var subarr = new List<int>();
            subarr.Add(arr[indexOfElem]);
            var idxFirst = indexOfElem - 1;
            var idxSecond = indexOfElem + 1;
            while (subarr.Count != k)
            {
                if (idxFirst < 0)
                {
                    subarr.Add(arr[idxSecond]);
                    idxSecond++;
                    continue;
                }

                if (idxSecond >= arr.Length)
                {
                    subarr.Insert(0, arr[idxFirst]);
                    idxFirst--;
                    continue;
                }

                if (Math.Abs(x - arr[idxFirst]) <= Math.Abs(x - arr[idxSecond]))
                {
                    subarr.Insert(0, arr[idxFirst]);
                    idxFirst--;
                }
                else
                {
                    subarr.Add(arr[idxSecond]);
                    idxSecond++;
                }
            }

            return subarr.ToArray();
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
                    var res = Math.Abs(arr[searchIndex] - x) >= Math.Abs(arr[searchIndex - 1]) ? searchIndex - 1 : searchIndex;
                    return res;
                }
                var temp = newSearchIndex;
                newSearchIndex = searchIndex;
                searchIndex = temp;
            } while (true);
        }
    }
}
