using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q560_SubarraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            var total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var currentSum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    currentSum += nums[j];

                    if (currentSum == k) total++;
                }
            }

            return total;
        }

        // TODO: Better solution, prefix sum
    }
}
