namespace LeetCode_CSharp.Problems
{
    internal class Q42TrappingRainWater
    {
        public int Trap(int[] height)
        {
            var waterCount = 0;

            var maxHeight = 0;
            var maxHeightIndex = 0;
            for (var x = 0; x < height.Length; x++)
                if (height[x] >= maxHeight)
                {
                    maxHeight = height[x];
                    maxHeightIndex = x;
                }
            
            var currentHeight = 0;
            for (var x = 0; x < maxHeightIndex; x++)
            {
                if (currentHeight <= height[x])
                    currentHeight = height[x];
                else
                    waterCount += currentHeight - height[x];
            }
            
            currentHeight = 0;
            for (var x = height.Length - 1; x > maxHeightIndex; x--)
            {
                if (currentHeight <= height[x])
                    currentHeight = height[x];
                else
                    waterCount += currentHeight - height[x];
            }

            return waterCount;
        }
    }
}
