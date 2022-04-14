using LeetCode_CSharp.Structure;

namespace LeetCode_CSharp.Problems
{
    internal class Q2AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var currentL1 = l1;
            var currentL2 = l2;

            var nextInt = 0;

            var result = "";

            do
            {
                var tempSum = (currentL1?.Val ?? 0)
                              + (currentL2?.Val ?? 0)
                              + nextInt;

                result += (tempSum % 10).ToString();
                nextInt = tempSum / 10;

                currentL1 = currentL1?.Next;
                currentL2 = currentL2?.Next;
            } while (currentL1 != null || currentL2 != null || nextInt != 0);

            ListNode final = null;

            for (var x = result.Length - 1; x >= 0; x--)
            {
                var current = new ListNode(result[x] - 48);

                if (final is null)
                    final = current;
                else
                {
                    current.Next = final;
                    final = current;
                }
            }

            return final;
        }
    }
}
