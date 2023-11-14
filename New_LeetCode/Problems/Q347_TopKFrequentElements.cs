using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q347_TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var frequencyDic = new Dictionary<int, int>();
            var heap = new PriorityQueue<int, int>(new FrequentComparer());

            foreach (var num in nums)
            {
                if (frequencyDic.ContainsKey(num))
                    frequencyDic[num]++;
                else
                    frequencyDic[num] = 1;
            }

            foreach (var key in frequencyDic.Keys) heap.Enqueue(key, frequencyDic[key]);

            var result = new List<int>();

            for (var i = 0; i < k; i++) result.Add(heap.Dequeue());

            return result.ToArray();
        }

        private class FrequentComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
