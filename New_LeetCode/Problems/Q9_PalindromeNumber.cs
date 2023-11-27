namespace New_LeetCode.Problems;

public class Q9_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        var s = x.ToString();
        
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
                return false;
        }
        
        return true;
    }
}