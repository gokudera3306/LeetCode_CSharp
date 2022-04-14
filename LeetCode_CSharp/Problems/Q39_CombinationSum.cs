using System;
using System.Collections.Generic;

namespace LeetCode_CSharp.Problems
{
    internal class Q39CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            if (candidates.Length == 0) return new List<IList<int>>();

            Array.Sort(candidates);

            var result = FindCombinations(target, 0, ref candidates);

            return result;
        }

        public List<IList<int>> FindCombinations(int target, int startIndex, ref int[] candidates)
        {
            var result = new List<IList<int>>();

            for (var x = startIndex; x < candidates.Length; x++)
            {
                if (candidates[x] < target)
                {
                    var temp = FindCombinations(target - candidates[x], x, ref candidates);

                    foreach (var l in temp)
                    {
                        var t = new List<int>() { candidates[x] };
                        t.AddRange(l);
                        result.Add(t);
                    }
                }
                else if (candidates[x] == target)
                    result.Add(new List<int>() { candidates[x] });
            }

            return result;
        }
    }
}
