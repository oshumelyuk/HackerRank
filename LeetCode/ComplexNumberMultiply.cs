using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    static class ComplexNumberMultiply
    {
        public static string Solve(string a, string b)
        {
            var partsA = a.Split("+");
            var partsB = b.Split("+");

            var intA = int.Parse(partsA[0]);
            var intB = int.Parse(partsB[0]);

            var iPartA = int.Parse(partsA[1].Substring(0, partsA[1].Length - 1));
            var iPartB = int.Parse(partsB[1].Substring(0, partsB[1].Length - 1));

            var intResult = (intA * intB) + (iPartA * iPartB * -1);
            var iResult = (intA * iPartB) + (intB * iPartA);

            return $"{intResult}+{iResult}i";
        }

    }
}
