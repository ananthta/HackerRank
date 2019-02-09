using System;
using System.IO;
using System.Collections.Generic;
using HackerRank.StringManipulations.Interfaces;

namespace HackerRank.StringManipulations
{
    public class AlternatingCharacters : IAlternatingCharacters
    {
        public int GetDifferenceOfAlternateCharacters(string s)
        {

            if (string.IsNullOrEmpty(s))
                return 0;

            var allowedCharacters = new List<char>{'a', 'b', 'A', 'B'};
            var previousCharacter = 'a';
            var charsToBeDeleted = 0;
            
            foreach (var t in s)
            {
                if (previousCharacter == t && allowedCharacters.Contains(t))
                    charsToBeDeleted++;
                else
                {
                    previousCharacter = t;
                }
            }

            return charsToBeDeleted;

        }

        public void Run(string[] args) {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var q = Convert.ToInt32(Console.ReadLine());

            for (var qItr = 0; qItr < q; qItr++) {
                var s = Console.ReadLine();

                var result = GetDifferenceOfAlternateCharacters(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}