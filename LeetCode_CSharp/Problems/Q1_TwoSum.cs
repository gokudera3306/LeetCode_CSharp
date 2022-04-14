namespace LeetCode_CSharp.Problems
{
    internal class Q1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {

            for (var x = 0; x < nums.Length; x++)
            {
                for (var y = x + 1; y < nums.Length; y++)
                {
                    if (nums[x] + nums[y] == target)
                    {
                        return new[] { x, y };
                    }
                }
            }

            return new[] { 0 };
        }
    }
}
