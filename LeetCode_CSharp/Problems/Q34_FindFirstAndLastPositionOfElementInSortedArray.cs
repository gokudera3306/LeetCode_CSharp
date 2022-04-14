namespace LeetCode_CSharp.Problems
{
    internal class Q34FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };

            var startIndex = -1;
            var endIndex = -1;

            for (var x = 0; x < nums.Length; x++)
            {
                if (nums[x] == target)
                {
                    startIndex = x;
                    break;
                }
            }

            if (startIndex == -1) return new int[] { -1, -1 };

            for (var x = nums.Length - 1; x >= 0; x--)
            {
                if (nums[x] == target)
                {
                    endIndex = x;
                    break;
                }
            }

            return new int[] { startIndex, endIndex };
        }
    }
}
