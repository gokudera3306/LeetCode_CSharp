namespace LeetCode_CSharp.Problems
{
    internal class Q5LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 1) return s;

            var result = "";

            for (var x = 0; x < s.Length - 1; x++)
            {
                var expandWidth = 1;
                var newResult = "";

                if (s[x] == s[x + 1])
                {
                    if (result.Length == 0) result = s.Substring(x, 2);

                    expandWidth = 1;

                    while (x - expandWidth >= 0 && x + 1 + expandWidth < s.Length)
                    {
                        if (s[x - expandWidth] == s[x + 1 + expandWidth])
                            expandWidth++;
                        else
                            break;
                    }

                    expandWidth--;

                    newResult = s.Substring(x - expandWidth, expandWidth * 2 + 2);

                    if (newResult.Length > result.Length)
                        result = newResult;
                }

                expandWidth = 1;

                while (x - expandWidth >= 0 && x + expandWidth < s.Length)
                {
                    if (s[x - expandWidth] == s[x + expandWidth])
                        expandWidth++;
                    else
                        break;
                }

                expandWidth--;

                newResult = s.Substring(x - expandWidth, expandWidth * 2 + 1);

                if (newResult.Length > result.Length)
                    result = newResult;
            }

            return result;
        }
    }
}
