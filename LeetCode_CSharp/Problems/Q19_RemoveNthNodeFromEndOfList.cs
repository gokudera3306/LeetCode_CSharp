using System.Collections.Generic;
using LeetCode_CSharp.Structure;

namespace LeetCode_CSharp.Problems
{
    internal class Q19RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var nodes = new List<ListNode>();

            var currentNode = head;

            while (currentNode != null)
            {
                nodes.Add(currentNode);
                currentNode = currentNode.Next;
            }

            if (n == nodes.Count && nodes.Count == 1)
                return null;
            if (n == nodes.Count)
                return nodes[1];

            nodes[nodes.Count - n - 1].Next = nodes[nodes.Count - n].Next;

            return head;
        }
    }
}
