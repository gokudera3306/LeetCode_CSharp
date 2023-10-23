using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q21MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode head;

        if (l1 == null) return l2;
        if (l2 == null) return l1;

        if (l1.Val > l2.Val)
        {
            head = new ListNode(l2.Val);
            l2 = l2.Next;
        }
        else
        {
            head = new ListNode(l1.Val);
            l1 = l1.Next;
        }

        var tempNode = head;

        while (true)
        {
            if (l1 == null)
            {
                tempNode.Next = l2;
                break;
            }

            if (l2 == null)
            {
                tempNode.Next = l1;
                break;
            }

            if (l1.Val > l2.Val)
            {
                tempNode.Next = new ListNode(l2.Val);
                l2 = l2.Next;
            }
            else
            {
                tempNode.Next = new ListNode(l1.Val);
                l1 = l1.Next;
            }

            tempNode = tempNode.Next;
        }

        return head;
    }
}