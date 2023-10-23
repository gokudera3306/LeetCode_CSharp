namespace New_LeetCode.Problems;

public class Sorting
{
    public void QuickSort(int[] nums, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= endIndex || endIndex > nums.Length - 1) return;

        var midIndex = (endIndex + startIndex) / 2;
        var pivot = nums[midIndex];

        var front = startIndex - 1;
        var back = endIndex + 1;

        if (startIndex == 6 && endIndex == 12)
            Console.WriteLine("");

        while (true)
        {
            while (nums[++front] < pivot) ;
            while (nums[--back] > pivot) ;

            if (front >= back) break;

            (nums[front], nums[back]) = (nums[back], nums[front]);
        }

        QuickSort(nums, startIndex, front - 1);
        QuickSort(nums, back + 1, endIndex);
    }

    public void QuickSort2(int[] nums, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= endIndex || endIndex > nums.Length - 1) return;

        var midIndex = (endIndex + startIndex) / 2;
        var pivot = nums[midIndex];

        (nums[midIndex], nums[endIndex]) = (nums[endIndex], nums[midIndex]);

        var swapIndex = startIndex;

        for (var index = startIndex; index < endIndex; index++)
        {
            if (nums[index] > pivot) continue;

            (nums[swapIndex], nums[index]) = (nums[index], nums[swapIndex]);
            swapIndex++;
        }

        (nums[swapIndex], nums[endIndex]) = (nums[endIndex], nums[swapIndex]);

        QuickSort2(nums, startIndex, swapIndex - 1);
        QuickSort2(nums, swapIndex + 1, endIndex);
    }


}