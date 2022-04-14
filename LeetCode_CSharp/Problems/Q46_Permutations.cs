using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_CSharp.Problems
{
    internal class Q46Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = GetCombinations(nums);

            return result;
        }

        public bool NextPermutation(ref int[] nums)
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

                    return true;
                }
            }

            return false;
        }

        public void Swap(int sIndex, int eIndex, ref int[] nums)
        {
            (nums[sIndex], nums[eIndex]) = (nums[eIndex], nums[sIndex]);
        }

        public List<IList<int>> GetCombinations(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums.Length == 1)
                result.Add(new List<int>() { nums[0] });
            else
            {
                var numList = nums.ToList();

                for (var x = 0; x < nums.Length; x++)
                {
                    var newArray = nums.Where(val => val != nums[x]).ToArray();

                    var temp = GetCombinations(newArray);
                    foreach (var t in temp)
                    {
                        var r = new List<int>() { nums[x] };
                        r.AddRange(t);
                        result.Add(r);
                    }
                }
            }

            return result;
        }
    }
}
