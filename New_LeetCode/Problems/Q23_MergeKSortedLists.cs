using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q23MergeKSortedLists
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        //init head
        var smallestIndex = -1;
        for (var x = 0; x < lists.Length; x++)
        {
            if (lists[x] is null) continue;

            if (smallestIndex == -1 || lists[smallestIndex].Val > lists[x].Val)
                smallestIndex = x;
        }

        if (smallestIndex == -1) return null;

        var head = new ListNode(lists[smallestIndex].Val);
        var tempNode = head;
        lists[smallestIndex] = lists[smallestIndex].Next;

        //start combine lists
        while (HasValue(ref lists))
        {
            smallestIndex = -1;
            for (var x = 0; x < lists.Length; x++)
            {
                if (lists[x] is null) continue;

                if (smallestIndex == -1 || lists[smallestIndex].Val > lists[x].Val)
                    smallestIndex = x;
            }

            tempNode.Next = new ListNode(lists[smallestIndex].Val);
            tempNode = tempNode.Next;
            lists[smallestIndex] = lists[smallestIndex].Next;
        }

        return head;
    }

    private bool HasValue(ref ListNode[] lists)
    {
        foreach (var l in lists)
            if (l != null) return true;

        return false;
    }
}