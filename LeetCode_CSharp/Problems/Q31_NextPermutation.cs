using System;

namespace LeetCode_CSharp.Problems
{
    internal class Q31NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            for (var x = nums.Length - 1; x > 0; x--)
            {
                if (nums[x] > nums[x - 1])
                {
                    var changeIndex = x;

                    for (var y = x; y < nums.Length; y++)
                    {
                        if (nums[x - 1] < nums[y] && nums[y] < nums[changeIndex])
                            changeIndex = y;
                    }

                    Swap(x - 1, changeIndex, ref nums);

                    Array.Sort(nums, x, nums.Length - x);

                    return;
                }
            }

            Array.Sort(nums);
        }

        private void Swap(int sIndex, int eIndex, ref int[] nums)
        {
            (nums[sIndex], nums[eIndex]) = (nums[eIndex], nums[sIndex]);
        }
    }
}
