namespace New_LeetCode.Problems;

public class Q153_FindMinimumInRotatedSortedArray
{
    public int FindMin(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        return nums[0] < nums.Last() ? nums[0] : SpecialBinarySearch(nums);
    }

    private int SpecialBinarySearch(int[] nums)
    {
        var startIndex = 0;
        var endIndex = nums.Length - 1;

        while (startIndex + 1 < endIndex)
        {
            var midIndex = (startIndex + endIndex) / 2;
            
            if (nums[midIndex] < nums[startIndex])
                endIndex = midIndex;
            else
                startIndex = midIndex;
        }

        return nums[endIndex];
    }
}