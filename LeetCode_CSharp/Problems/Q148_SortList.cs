using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode_CSharp.Structure;

namespace LeetCode_CSharp.Problems
{
    internal class Q148_SortList
    {
        public ListNode SortList(ListNode head)
        {
            return MergeSort(head);
        }

        private ListNode MergeSort(ListNode head)
        {
            if (head == null) return null;
            if (head.Next == null) return head;

            ListNode temp = null;
            var midNode = head;
            var tailNode = head;

            while (midNode != null && tailNode?.Next != null)
            {
                temp = midNode;
                midNode = midNode.Next;
                tailNode = tailNode.Next.Next;
            }

            if (temp != null) temp.Next = null;

            var firstList = MergeSort(head);
            var secondList = MergeSort(midNode);

            return MergeSort(firstList, secondList);
        }

        private ListNode MergeSort(ListNode firstList, ListNode secondList)
        {
            if (firstList == null) return secondList;
            if (secondList == null) return firstList;

            ListNode head;

            if (firstList.Val < secondList.Val)
            {
                head = firstList;
                firstList = firstList.Next;
            }
            else
            {
                head = secondList;
                secondList = secondList.Next;
            }

            var current = head;

            while (firstList != null || secondList != null)
            {
                if (firstList == null)
                {
                    current.Next = secondList;
                    secondList = secondList.Next;
                }
                else if (secondList == null || firstList.Val < secondList.Val)
                {
                    current.Next = firstList;
                    firstList = firstList.Next;
                }
                else
                {
                    current.Next = secondList;
                    secondList = secondList.Next;
                }

                current = current.Next;
            }

            return head;
        }
    }
}
