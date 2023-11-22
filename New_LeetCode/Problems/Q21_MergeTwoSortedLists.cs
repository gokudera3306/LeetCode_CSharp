using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q21MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode head;

        if (l1 == null) return l2;
        if (l2 == null) return l1;

        if (l1.val > l2.val)
        {
            head = new ListNode(l2.val);
            l2 = l2.next;
        }
        else
        {
            head = new ListNode(l1.val);
            l1 = l1.next;
        }

        var tempNode = head;

        while (true)
        {
            if (l1 == null)
            {
                tempNode.next = l2;
                break;
            }

            if (l2 == null)
            {
                tempNode.next = l1;
                break;
            }

            if (l1.val > l2.val)
            {
                tempNode.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            else
            {
                tempNode.next = new ListNode(l1.val);
                l1 = l1.next;
            }

            tempNode = tempNode.next;
        }

        return head;
    }
}