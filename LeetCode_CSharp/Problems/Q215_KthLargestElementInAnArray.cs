using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    internal class Q215_KthLargestElementInAnArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var startIndex = 0;
            var endIndex = nums.Length - 1;
            var expectedIndex = nums.Length - k;

            while (startIndex <= endIndex)
            {
                var pivotIndex = Partition(nums, startIndex, endIndex);

                if (pivotIndex == expectedIndex) return nums[pivotIndex];
                
                if (pivotIndex < expectedIndex)
                    startIndex = pivotIndex + 1;
                else
                    endIndex = pivotIndex - 1;
            }
            
            return int.MinValue;
        }

        private static int Partition(int[] nums, int startIndex, int endIndex)
        {
            var pivot = nums[endIndex];
            var swapIndex = startIndex;

            for (var index = startIndex; index < endIndex; index++)
            {
                if (nums[index] >= pivot) continue;

                (nums[swapIndex], nums[index]) = (nums[index], nums[swapIndex]);
                swapIndex++;
            }

            (nums[swapIndex], nums[endIndex]) = (nums[endIndex], nums[swapIndex]);
            return swapIndex;
        }
    }
}
