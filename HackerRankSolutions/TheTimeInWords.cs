using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankSolutions
{
    class TheTimeInWords
    {
        private static readonly Dictionary<int, string> numToString = new Dictionary<int, string>() {
            { 1, "one"},
            { 2, "two"},
            { 3, "three"},
            { 4, "four"},
            { 5, "five"},
            { 6, "six"},
            { 7, "seven"},
            { 8, "eight"},
            { 9, "nine"},
            { 10, "ten"},
            { 11, "eleven"},
            { 12, "twelve"},
            { 13, "thirteen"},
            { 14, "fourteen"},
            { 15, "fifteen"},
            { 16, "sixteen"},
            { 17, "seventeen"},
            { 18, "eighteen"},
            { 19, "nineteen"},
            { 20, "twenty"},
            { 30, "thirty"},
            { 40, "fourty"},
            { 50, "fifty"}
        };

        private static readonly Dictionary<int, string> definedMinutesPrefixes = new Dictionary<int, string>() {
            { 15, "quarter past"},
            { 30, "half past"},
            { 45, "quarter to"},
        };

        static string timeInWords(int h, int m)
        {
            var timeInWords = new StringBuilder();

            if (m == 0)
            {
                timeInWords.Append(GetHoursString(h));
                timeInWords.Append(" o' clock");
                return timeInWords.ToString();
            }

            if (HasMinutesReservedWord(m))
            {
                timeInWords.Append(GetMinutesPrefix(m));
                timeInWords.Append(" ");
                timeInWords.Append(GetHoursString(m > 30 ? (h + 1) : h));
                return timeInWords.ToString();
            }

            if (MinutesInFirstHalf(m))
            {
                timeInWords.Append(GetMinutesString(m));
                timeInWords.Append(" past ");
                timeInWords.Append(GetHoursString(h));
                return timeInWords.ToString();
            }

            if (MinutesInSecondHalf(m))
            {
                timeInWords.Append(GetMinutesString(60 - m));
                timeInWords.Append(" to ");
                timeInWords.Append(GetHoursString(h));
                return timeInWords.ToString();
            }

            throw new ArgumentOutOfRangeException($"{h} Hours and {m} minutes is out of range");
        }

        private static bool MinutesInSecondHalf(int m)
        {
            return m > 30 && m < 60;
        }

        private static bool MinutesInFirstHalf(int m)
        {
            return m > 0 && m < 30;
        }

        private static string GetMinutesPrefix(int m)
        {
            return definedMinutesPrefixes[m];
        }

        private static bool HasMinutesReservedWord(int m)
        {
            return definedMinutesPrefixes.ContainsKey(m);
        }

        private static string GetMinutesString(int minutes)
        {
            var minutesInWords = new StringBuilder();

            var minuteNumbersAsString = MinutesIsComposite(minutes)
                ? GetCompositeMinutesString(minutes)
                : GetSimpleMinutesString(minutes);

            minutesInWords.Append(minuteNumbersAsString);
            minutesInWords.Append(" ");
            minutesInWords.Append(minutes % 10 == 1 ? "minute" : "minutes");
            return minutesInWords.ToString();
        }

        private static string GetSimpleMinutesString(int minutes)
        {
            return numToString[minutes];
        }

        private static string GetCompositeMinutesString(int minutes)
        {
            var iteration = 1;
            var initialMinutes = minutes;
            var minutesInWords = new StringBuilder();
            do
            {
                var lastNum = (initialMinutes % 10) * iteration;
                initialMinutes = initialMinutes / 10;
                iteration = iteration * 10;
                minutesInWords.Insert(0, numToString[lastNum] + " ");
            } while (initialMinutes > 0);

            return minutesInWords.Remove(minutesInWords.Length - 1, 1).ToString();
        }

        private static bool MinutesIsComposite(int minutes)
        {
            return !numToString.ContainsKey(minutes);
        }

        private static string GetHoursString(int hours)
        {
            return numToString[hours];
        }

        public static string Solve(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);
            return result;
        }
    }

}
