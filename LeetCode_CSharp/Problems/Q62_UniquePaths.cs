namespace LeetCode_CSharp.Problems
{
    internal class Q62UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 1 || n == 1) return 1;

            int maxMn, minMn;

            if (m > n)
            {
                maxMn = m - 1;
                minMn = n - 1;
            }
            else
            {
                maxMn = n - 1;
                minMn = m - 1;
            }

            long pathCount = 1;
            for (var x = m + n - 2; x > maxMn; x--)
                pathCount *= x;

            for (var x = minMn; x > 1; x--)
                pathCount /= x;

            return (int)pathCount;
        }
    }
}
