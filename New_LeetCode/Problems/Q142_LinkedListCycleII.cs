using New_LeetCode.Structure;

namespace New_LeetCode.Problems;

public class Q142_LinkedListCycleII
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null) return null;
        
        var slow = head;
        var fast = head;

        while (slow != null && fast != null)
        {
            slow = slow.next;
            
            if (fast.next == null) break;
            fast = fast.next.next;

            if (slow == fast)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                return slow;
            }
        }

        return null;
    }
}