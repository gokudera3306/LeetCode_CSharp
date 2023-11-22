using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q19RemoveNthNodeFromEndOfList
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var nodes = new List<ListNode>();

        var currentNode = head;

        while (currentNode != null)
        {
            nodes.Add(currentNode);
            currentNode = currentNode.next;
        }

        if (n == nodes.Count && nodes.Count == 1)
            return null;
        if (n == nodes.Count)
            return nodes[1];

        nodes[nodes.Count - n - 1].next = nodes[nodes.Count - n].next;

        return head;
    }
}