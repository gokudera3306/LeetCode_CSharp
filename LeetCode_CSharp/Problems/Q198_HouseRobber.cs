using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q198_HouseRobber
    {
        public int Rob(int[] nums)
        {
            switch (nums.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return nums[0];
                case 2:
                    return Math.Max(nums[0], nums[1]);
            }
            
            var canTakeNumber = nums[0];
            var canNotTakeNumber = nums[1];

            for (var x = 2; x < nums.Length; x++)
            {
                var temp = canTakeNumber + nums[x];
                canTakeNumber = Math.Max(canTakeNumber, canNotTakeNumber);
                canNotTakeNumber = temp;
            }

            return Math.Max(canTakeNumber, canNotTakeNumber);
        }
    }
}
