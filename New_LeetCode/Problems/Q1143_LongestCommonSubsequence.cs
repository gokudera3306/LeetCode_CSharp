namespace New_LeetCode.Problems;

public class Q1143_LongestCommonSubsequence
{
    public int BottomUp(string text1, string text2)
    {
        var text1Length = text1.Length;
        var text2Length = text2.Length;

        var dp = new int[text1Length + 1, text2Length + 1];

        for (var i = 1; i <= text1Length; i++)
        {
            for (var j = 1; j <= text2Length; j++)
            {
                var char1 = text1[i - 1];
                var char2 = text2[j - 1];

                if (char1 == char2)
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[text1Length, text2Length];
    }

    // TODO: TopDown Version
}