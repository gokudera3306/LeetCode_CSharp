using System.Collections.Generic;
using LeetCode_CSharp.Problems;

namespace LeetCode_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var question = new Q198_HouseRobber();

            var result = question.Rob(new[] { 2, 7, 9, 3, 1, 15, 1, 25, 10, 45, 3 });
        }
    }
}
