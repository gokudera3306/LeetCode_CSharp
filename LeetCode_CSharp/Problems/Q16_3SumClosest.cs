using System;

namespace LeetCode_CSharp.Problems
{
    internal class Q163SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            var minDistance = Int32.MaxValue;
            var isNeg = false;

            for (var x = 0; x <= nums.Length - 3; x++)
            {
                var frontIndex = x + 1;
                var endIndex = nums.Length - 1;

                while (frontIndex < endIndex)
                {
                    var sum = nums[frontIndex] + nums[endIndex] + nums[x];
                    
                    if (sum > target)
                    {
                        if ((sum - target) < minDistance)
                        {
                            minDistance = sum - target;
                            isNeg = false;
                        }

                        endIndex--;
                    }
                    else if (sum < target)
                    {
                        if ((target - sum) < minDistance)
                        {
                            minDistance = target - sum;
                            isNeg = true;
                        }

                        frontIndex++;
                    }
                    else if (sum == target)
                    {
                        return sum;
                    }
                }
            }

            return target + (isNeg ? -minDistance : minDistance);
        }
    }
}
