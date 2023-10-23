namespace New_LeetCode.Problems;

internal class Q7ReverseInteger
{
    public int Reverse(int x)
    {
        var isNeg = x < 0;

        try
        {
            var xString = Math.Abs(x).ToString();
            var finalString = "";

            for (var y = xString.Length - 1; y >= 0; y--)
            {
                finalString += xString[y];
            }

            if (isNeg)
                finalString = "-" + finalString;

            var result = int.Parse(finalString);

            return result;
        }
        catch (Exception e)
        {
            return 0;
        }
    }
}