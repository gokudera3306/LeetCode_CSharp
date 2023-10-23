namespace New_LeetCode.Problems;

internal class Interview_Base7Converter
{
    private const int baseNum = 7;
    public string Convert(int num)
    {
        var isNegative = num < 0;

        var result = string.Empty;
        var absNum = Math.Abs(num);

        while (absNum >= baseNum)
        {
            var remainder = absNum % baseNum;
            result = remainder + result;

            absNum /= baseNum;
        }

        result = absNum + result;

        return (isNegative ? "-" : string.Empty) + result;
    }
}