namespace New_LeetCode.Problems;

internal class Q70ClimbingStairs
{
    public int ClimbStairs(int n)
    {

        if (n <= 0) return 1;

        var total = 0;

        var maxTwoCount = n / 2;

        for (var x = 0; x <= maxTwoCount; x++)
        {
            total += GetPosibilities(x, n - 2 * x);
        }

        return total;
    }

    public int GetPosibilities(int twoCount, int oneCount)
    {
        if (twoCount == 0 || oneCount == 0) return 1;

        int maxC, minC;

        if (twoCount > oneCount)
        {
            maxC = twoCount;
            minC = oneCount;
        }
        else
        {
            maxC = oneCount;
            minC = twoCount;
        }

        decimal posibilitiesCount = 1;
        for (var x = twoCount + oneCount; x > maxC; x--)
            posibilitiesCount *= x;

        for (var x = minC; x > 1; x--)
            posibilitiesCount /= x;

        return (int)posibilitiesCount;
    }
}