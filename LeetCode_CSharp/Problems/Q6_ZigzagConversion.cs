namespace LeetCode_CSharp.Problems
{
    internal class Q6ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            var result = "";

            var maxGap = 1 + 2 * (numRows - 2) + 1;

            for (var x = 0; x < numRows; x++)
            {
                for (var y = 0; y < s.Length; y += maxGap)
                {
                    var addCharIndex1 = y + x;
                    var addCharIndex2 = y + maxGap - x;

                    if (addCharIndex1 < s.Length)
                        result += s[addCharIndex1];

                    if (addCharIndex2 < s.Length && x != numRows - 1 && x != 0)
                        result += s[addCharIndex2];
                }
            }

            return result;
        }
    }
}
