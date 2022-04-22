using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    /// <summary>
    /// Time Complexity O(n)?
    /// 
    /// </summary>
    internal class Interview_TwoSumLessThanK
    {
        public readonly struct NumPair
        {
            public readonly int NumOne;
            public readonly int NumTwo;

            public NumPair(int numOne, int numTwo)
            {
                NumOne = numOne;
                NumTwo = numTwo;
            }
        }

        public HashSet<NumPair> Calculate(List<int> nums, int k)
        {
            var result = new HashSet<NumPair>();
            var currentMax = int.MinValue;

            nums.Sort();
            
            for (var frontIndex = 0; frontIndex < nums.Count; frontIndex++)
            {
                for (var baskIndex = nums.Count - 1; baskIndex > frontIndex; baskIndex--)
                {
                    var sum = nums[frontIndex] + nums[baskIndex];

                    if (sum < k && sum > currentMax)
                    {
                        currentMax = sum;

                        result.Clear();
                        result.Add(new NumPair( nums[frontIndex], nums[baskIndex] ));
                        break;
                    }
                    
                    if (sum < k && sum == currentMax)
                    {
                        result.Add(new NumPair( nums[frontIndex], nums[baskIndex] ));
                        break;
                    }
                }
            }
            
            return result;
        }
    }
}
