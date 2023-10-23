namespace New_LeetCode.Problems;

internal class Q41FirstMissingPositive
{
    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);

        var missingInt = 0;

        foreach (var i in nums)
        {
            if (missingInt + 1 == i)
                missingInt++;
            else if (missingInt >= i)
                continue;
            else
                break;
        }

        return ++missingInt;
    }
}