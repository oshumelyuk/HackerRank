﻿using System;
using System.Collections.Generic;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // TheTimeInWords.Solve(args);
            var len = LengthOfLongestSubstring(Console.ReadLine());

        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            int len = 1;
            int lastStartedIndex = 0;
            var chars = new HashSet<char>(s.Length);
            for (var i = 0; i < s.Length; i++)
            {
                if (chars.Contains(s[i]))
                {
                    if (len < chars.Count)
                    {
                        len = chars.Count;
                    }
                    chars.Clear();
                    lastStartedIndex++;
                    i = lastStartedIndex - 1;
                }
                else
                {
                    chars.Add(s[i]);
                }
            }
            return len > chars.Count ? len : chars.Count;
        }
    }
}
