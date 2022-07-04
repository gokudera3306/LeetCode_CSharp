using System.Collections.Generic;
using LeetCode_CSharp.Problems;
using LeetCode_CSharp.Structure;

namespace LeetCode_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var question = new Q148_SortList();

            var head = new ListNode(4);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(1);
            head.Next.Next.Next = new ListNode(3);

            var result = question.SortList(head);
        }
    }
}
