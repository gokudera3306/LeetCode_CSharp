namespace New_LeetCode.Problems;

public class Q704_BinarySearch
{
    public int Search(int[] nums, int target)
    {
        var startIndex = 0;
        var endIndex = nums.Length - 1;
        
        while (startIndex <= endIndex)
        {
            var midIndex = (endIndex + startIndex) / 2;

            if (nums[midIndex] == target)
                return midIndex;

            if (nums[midIndex] > target)
                endIndex = midIndex - 1;
            else
                startIndex = midIndex + 1;
        }

        return -1;
    }
}