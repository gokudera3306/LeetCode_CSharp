namespace New_LeetCode.Problems;

internal class Q33SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {

        if (nums.Length == 0) return -1;

        var startPoint = nums[0];

        if (nums[0] > target)
        {
            for (var x = nums.Length - 1; x >= 0; x--)
            {
                if (nums[x] == target) return x;

                if (nums[x] > startPoint) break;
            }
        }
        else
        {
            for (var x = 0; x < nums.Length; x++)
            {
                if (nums[x] == target) return x;

                if (nums[x] < startPoint) break;
            }
        }

        return -1;
    }
}