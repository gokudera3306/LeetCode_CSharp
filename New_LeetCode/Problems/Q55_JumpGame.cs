namespace New_LeetCode.Problems;

internal class Q55JumpGame
{
    public bool CanJump(int[] nums)
    {
        if (nums.Length == 1 && nums[0] == 0) return true;

        var jumpLength = 0;
        var canJump = true;

        for (var x = nums.Length - 1; x >= 0; x--)
        {
            if (!canJump)
            {
                jumpLength++;

                if (nums[x] > jumpLength)
                {
                    canJump = true;
                    jumpLength = 0;
                }
            }

            if (nums[x] == 0 && canJump && x == nums.Length - 1)
            {
                canJump = false;
                jumpLength--;
            }
            if (nums[x] == 0 && canJump)
                canJump = false;
        }

        return canJump;
    }
}