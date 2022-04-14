using System.Collections.Generic;

namespace LeetCode_CSharp.Problems
{
    internal class Q4MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var addedList = new List<int>();
            addedList.AddRange(nums1);
            addedList.AddRange(nums2);
            addedList.Sort();

            if (addedList.Count % 2 == 0)
            {
                return (addedList[addedList.Count / 2] + addedList[addedList.Count / 2 - 1]) / 2.0;
            }

            return addedList[addedList.Count / 2];
        }
    }
}
