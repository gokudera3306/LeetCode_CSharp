using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

internal class Q148_SortList
{
    public ListNode SortList(ListNode head)
    {
        return MergeSort(head);
    }

    private ListNode MergeSort(ListNode head)
    {
        if (head == null) return null;
        if (head.next == null) return head;

        ListNode temp = null;
        var midNode = head;
        var tailNode = head;

        while (midNode != null && tailNode?.next != null)
        {
            temp = midNode;
            midNode = midNode.next;
            tailNode = tailNode.next.next;
        }

        if (temp != null) temp.next = null;

        var firstList = MergeSort(head);
        var secondList = MergeSort(midNode);

        return MergeSort(firstList, secondList);
    }

    private ListNode MergeSort(ListNode firstList, ListNode secondList)
    {
        if (firstList == null) return secondList;
        if (secondList == null) return firstList;

        ListNode head;

        if (firstList.val < secondList.val)
        {
            head = firstList;
            firstList = firstList.next;
        }
        else
        {
            head = secondList;
            secondList = secondList.next;
        }

        var current = head;

        while (firstList != null || secondList != null)
        {
            if (firstList == null)
            {
                current.next = secondList;
                secondList = secondList.next;
            }
            else if (secondList == null || firstList.val < secondList.val)
            {
                current.next = firstList;
                firstList = firstList.next;
            }
            else
            {
                current.next = secondList;
                secondList = secondList.next;
            }

            current = current.next;
        }

        return head;
    }
}