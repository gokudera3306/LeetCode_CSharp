namespace LeetCode_CSharp.Problems
{
    internal class Q11ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxResult = -1;

            for (var x = 0; x < height.Length; x++)
            {
                var tempMax = -1;

                if (x > 0)
                {
                    for (var y = 0; y < x; y++)
                    {
                        if (height[x] <= height[y])
                        {
                            tempMax = height[x] * (x - y);
                            break;
                        }
                    }
                }

                if (tempMax > maxResult)
                    maxResult = tempMax;

                if (x < height.Length - 1)
                {
                    for (var y = height.Length - 1; y > x; y--)
                    {
                        if (height[x] <= height[y])
                        {
                            tempMax = height[x] * (y - x);
                            break;
                        }
                    }
                }

                if (tempMax > maxResult)
                    maxResult = tempMax;
            }

            return maxResult;
        }
    }
}
