using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q416_PartitionEqualSubsetSum
    {
        private Dictionary<(int, int), bool> dp;

        public bool CanPartition(int[] nums)
        {
            if (nums.Length == 1) return false;

            var sum = nums.Sum();

            if (sum % 2 != 0) return false;

            var half = sum / 2;

            dp = new Dictionary<(int, int), bool>();

            return BackTracing(nums.ToList(), half);
        }

        private bool BackTracing(List<int> nums, int target)
        {
            if (target == 0) return true;
            if (target < 0) return false;
            if (!nums.Any()) return false;

            if (dp.TryGetValue((nums.Count, target), out var value)) return value;

            var current = nums.First();
            var newList = nums.Skip(1).ToList();

            Console.WriteLine($"Target: {target}, nums: {string.Join(", ", nums)}");

            var result = BackTracing(newList, target - current) || BackTracing(newList, target);

            dp[(nums.Count, target)] = result;

            return result;
        }
    }
}
