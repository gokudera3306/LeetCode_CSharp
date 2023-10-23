namespace New_LeetCode.Problems;

internal class Q3LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s == "") return 0;

        var resultLength = 0;

        for (var x = 0; x < s.Length; x++)
        {
            var currentLength = 0;
            var checkUsed = new bool[128];

            for (var y = x; y < s.Length; y++)
            {
                var useIndex = (int)s[y];

                if (checkUsed[useIndex])
                    break;

                currentLength++;
                checkUsed[useIndex] = true;
            }

            if (resultLength < currentLength)
                resultLength = currentLength;
        }

        return resultLength;
    }
}