using HackerRank.StringManipulations.Interfaces;

namespace HackerRank.StringManipulations
{
    public class PallindromicSubstring : IPallindromicSubstring
    {
        public long substrCount(int n, string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (n == 1)
                return 1;

            long count = n;

            for (var i = 0; i < n; i++)
            {
                for (var j = i+1; j <= n-1; j++)
                    
                {
                    if (IsPallindromicSubString(s, i, j))
                        count++;
                }
            }

            return count;
        }

  

        private bool IsPallindromicSubString(string input, int start, int end)
        {
            if (start == end)
                return true;
            if (end - start == 1)
            {
                return input[start] == input[end];
            }
                

            var mid = (start + end) / 2;
            var firstChar = input[start];
            var isEven = ((end-start)+1) % 2 == 0;
            
            for (var i = start; i <= end; i++)
            {
                if (!isEven && i == mid)
                    continue;
                
                if (input[i] != firstChar)
                    return false;
            }

            return true;
        }
    }
    
}