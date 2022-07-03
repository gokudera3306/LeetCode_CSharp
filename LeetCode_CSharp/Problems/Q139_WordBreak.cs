using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q139_WordBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var dp = new bool[s.Length + 1];
            dp[0] = true;

            var wordSet = new HashSet<string>(wordDict);

            for (var charIndex = 0; charIndex <= s.Length; charIndex++)
            {
                for (var midIndex = 0; midIndex < charIndex; midIndex++)
                {
                    if (dp[midIndex] && wordSet.Contains(s.Substring(midIndex, charIndex - midIndex)))
                    {
                        dp[charIndex] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}
