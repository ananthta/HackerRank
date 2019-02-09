using System;
using System.Linq;
using HackerRank.StringManipulations.Interfaces;
using NLog;

namespace HackerRank.StringManipulations
{
    public class SherlockAndValidString : ISherlockAndValidString
    {
        public string IsValid(string s)
        {
            var input = s.ToLower();
            const string isValid = "YES";
            const string isNotValid = "NO";

            var charCounts = new int[26];

            foreach (var ch in input)
            {
                charCounts[ch - 'a']++;
            }

            var countOfCharsInInput = 0;
            var totalCountOfChars = 0;

            foreach (var ct in charCounts)
            {
                if (ct <= 0) continue;
                countOfCharsInInput++;
                totalCountOfChars += ct;
            }

            double average = (totalCountOfChars / countOfCharsInInput);
            var averageCountOfChars = (int) Math.Ceiling(average);
            
            Logger.Info(averageCountOfChars);
            Logger.Info(totalCountOfChars);
            Logger.Info(countOfCharsInInput);
            

            return totalCountOfChars <= ((countOfCharsInInput * averageCountOfChars) + 1) ? isValid : isNotValid;
        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}