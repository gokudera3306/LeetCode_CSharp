using System.Collections.Generic;
using LeetCode_CSharp.Problems;
using LeetCode_CSharp.Structure;

namespace LeetCode_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var question = new Q215_KthLargestElementInAnArray();

            var result = question.FindKthLargest(new[] { 3, 2, 1, 5, 6, 4 }, 2);
        }
    }
}
