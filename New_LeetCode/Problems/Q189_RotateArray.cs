namespace New_LeetCode.Problems;

public class Q189_RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        var rotateCount = k % nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, rotateCount);
        Array.Reverse(nums, rotateCount, nums.Length - rotateCount);
    }
}