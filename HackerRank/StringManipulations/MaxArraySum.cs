namespace HackerRank.StringManipulations
{
    public class MaxArraySum
    {
        public int maxSubsetSum(int[] arr)
        {
            var excl = 0;
            var incl = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                var temp = incl > excl ? incl : excl;
                incl = excl + arr[i];
                excl = temp;
            }

            return incl > excl ? incl : excl;
        }      
    }
}