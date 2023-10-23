namespace New_LeetCode.Problems;

internal class Q32LongestValidParentheses
{
    public int LongestValidParentheses(string s)
    {
        var maxLength = 0;

        for (var index = 0; index < s.Length; index++)
        {
            if (s.Length - index < maxLength) return maxLength;

            if (s[index] == ')') continue;

            var frontCount = 0;
            var tryLength = 0;

            for (var tryIndex = index; tryIndex < s.Length; tryIndex++)
            {
                if (frontCount == 0 && tryLength > maxLength)
                    maxLength = tryLength;

                if (s[tryIndex] == '(')
                    frontCount++;
                else if (frontCount == 0)
                    break;
                else
                    frontCount--;

                tryLength++;
            }

            if (frontCount == 0 && tryLength > maxLength)
                maxLength = tryLength;
        }

        return maxLength;
    }
}