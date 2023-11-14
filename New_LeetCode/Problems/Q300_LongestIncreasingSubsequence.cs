using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q300_LongestIncreasingSubsequence
    {
        readonly Dictionary<int, List<(int, int)>> maxLengthDictionary = new();

        public int LengthOfLIS(int[] nums)
        {
            //TODO: Better Solution.

            var dp = new int[nums.Length + 1];
            Array.Fill(dp, 1);

            //start from the back of array till 0
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    //strictly increasing subsequence
                    if (nums[i] < nums[j])
                    {
                        dp[i] = Math.Max(dp[i], 1 + dp[j]);// if my current dp[i] is greater or sum of 1+dp[j] is greater
                        //here we add 1 since you would count that number itself so 1 + whatever dp is of following number
                    }
                }
            }
            return dp.Max();

            //if (nums.Length <= 1) return nums.Length;

            //var result = FindMaxLength(ref nums, 0, int.MinValue);

            //return result;
        }

        private int FindMaxLength(ref int[] nums, int startIndex, int currentNum)
        {
            if (startIndex > nums.Length - 1) return 0;
            if (startIndex == nums.Length - 1) return nums.Last() > currentNum ? 1 : 0;
            if (maxLengthDictionary.TryGetValue(nums.Length - startIndex, out var max))
            {
                foreach (var (n, m) in max)
                {
                    if (currentNum == n) return m;
                    if (currentNum > n && m == 0) return 0;
                }
            }

            if (!nums.Skip(startIndex).Any(_ => _ > currentNum)) return 0;

            var newNum = nums[startIndex];
            var newLength = nums.Length - startIndex - 1;

            int result;

            if (newNum > currentNum)
            {
                var max1 = FindMaxLength(ref nums, startIndex + 1, newNum);

                if (maxLengthDictionary.TryGetValue(newLength, out var maxList))
                {
                    maxList.Add((newNum, max1));
                }
                else
                {
                    maxLengthDictionary[newLength] = new List<(int, int)>() { (newNum, max1) };
                    maxList = maxLengthDictionary[newLength];
                }

                if (max1 == newLength) return max1 + 1;

                var max2 = FindMaxLength(ref nums, startIndex + 1, currentNum);
                maxList.Add((currentNum, max2));
                result = Math.Max(max1 + 1, max2);
            }
            else
            {
                var max2 = FindMaxLength(ref nums, startIndex + 1, currentNum);

                if (maxLengthDictionary.TryGetValue(newLength, out var maxList))
                {
                    maxList.Add((currentNum, max2));
                }
                else
                {
                    maxLengthDictionary[newLength] = new List<(int, int)>() { (currentNum, max2) };
                }

                result = max2;
            }

            return result;
        }
    }
}
