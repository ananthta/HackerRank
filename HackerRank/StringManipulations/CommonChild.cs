using System;
using HackerRank.StringManipulations.Interfaces;

namespace HackerRank.StringManipulations
{
    public class CommonChild : ICommonChild
    {
        public int commonChild(string s1, string s2)
        {
            var T = new int[s1.Length+1, s2.Length+1];

            for (var i = 0; i <= s1.Length; i++)
            {
                for (var j = 0; j <= s2.Length; j++)
                {
                    Console.WriteLine("---------------------------");
                    Print(T);
                    Console.WriteLine("---------------------------");
                    if (i == 0 || j == 0)
                        T[i, j] = 0;
                    else if(s1[i-1] == s2[j-1])
                    {
                        Console.WriteLine($"match = {s1[i-1]} and {s2[j-1]}");
                        Console.WriteLine($" i = {i} and j = {j}");
                        T[i, j] = 1 + T[i - 1, j - 1];
                    }
                    else
                    {
                        T[i, j] = Math.Max(T[i - 1, j], T[i, j - 1]);
                    }
                }
            }

            Print(T);
            return T[s1.Length, s2.Length];
        }

        public void Print(int[,] T)
        {
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    Console.Write($"{T[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        
    }
}