namespace New_LeetCode.Problems;

internal class Q35_SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        //Console.WriteLine($"Start SearchInsert");
        //Console.WriteLine();

        var startIndex = 0;
        var endIndex = nums.Length - 1;

        while (startIndex <= endIndex)
        {
            var midIndex = (startIndex + endIndex) / 2;

            //Console.WriteLine($"Start: {startIndex}, End: {endIndex}, Mid: {midIndex}");

            if (nums[midIndex] > target)
                endIndex = midIndex - 1;

            if (nums[midIndex] < target)
                startIndex = midIndex + 1;

            if (nums[midIndex] == target)
                return midIndex;
        }

        return startIndex;
    }
}