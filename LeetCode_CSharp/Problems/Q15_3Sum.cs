using System.Collections.Generic;

namespace LeetCode_CSharp.Problems
{
    internal class Q153Sum
    {
        private List<IList<int>> result;

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            result = new List<IList<int>>();
            var dic = new Dictionary<int, int>();
            var numList = new List<int>();
            var resDic = new Dictionary<string, bool>();

            foreach (var i in nums)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 1);
                    numList.Add(i);
                }
                else
                {
                    var t = dic[i];
                    dic[i] = t + 1;
                }
            }

            for (var x = 0; x <= numList.Count - 1; x++)
            {
                for (var y = 0; y <= numList.Count - 1; y++)
                {
                    if (numList[x] == numList[y] && dic[numList[x]] == 1) continue;

                    var thirdInt = -(numList[x] + numList[y]);

                    var count = 0;
                    if (dic.TryGetValue(thirdInt, out count))
                    {
                        if (count == 1 && (numList[x] == thirdInt || numList[y] == thirdInt)) continue;
                        if (count == 2 && numList[x] == thirdInt && numList[y] == thirdInt) continue;

                        var temp = new List<int> { numList[x], numList[y], thirdInt };
                        temp.Sort();

                        var rKey = temp[0] + "" + temp[1];

                        if (resDic.ContainsKey(rKey)) continue;

                        result.Add(temp);
                        resDic.Add(rKey, true);
                    }
                }
            }

            return result;
        }
    }
}
