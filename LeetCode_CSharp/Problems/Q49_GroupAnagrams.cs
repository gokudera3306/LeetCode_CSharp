using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_CSharp.Problems
{
    internal class Q49GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var tempDic = new Dictionary<string, List<string>>();

            if (strs.Length == 0) return result;
            if (strs.Length == 1)
            {
                result.Add(new List<string>() { strs[0] });
                return result;
            }

            for (var x = 0; x < strs.Length; x++)
            {
                var characters = strs[x].ToArray();
                Array.Sort(characters);
                var key = new string(characters);

                List<string> list;
                if (tempDic.TryGetValue(key, out list))
                    list.Add(strs[x]);
                else
                    tempDic[key] = new List<string>() { strs[x] };
            }

            foreach (var k in tempDic.Keys)
                result.Add(tempDic[k]);

            return result;
        }
    }
}
