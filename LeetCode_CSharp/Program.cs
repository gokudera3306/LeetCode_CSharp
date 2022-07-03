using System.Collections.Generic;
using LeetCode_CSharp.Problems;

namespace LeetCode_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var question = new Q139_WordBreak();

            var result = question.WordBreak("leetcode", new List<string>() { "leet", "code" });
        }
    }
}
