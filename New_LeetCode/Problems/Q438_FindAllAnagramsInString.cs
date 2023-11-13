using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q438_FindAllAnagramsInString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            if (s.Length < p.Length) return new List<int>();

            var ans = new List<int>();

            var windowSize = p.Length;
            var pDic = new Dictionary<char, int>();

            foreach (var c in p)
            {
                if (pDic.ContainsKey(c))
                    pDic[c]++;
                else
                    pDic[c] = 1;
            }

            for (var i = 0; i <= s.Length - windowSize; i++)
            {
                var isAnagram = true;
                var tempDic = new Dictionary<char, int>();

                for (var j = 0; j < windowSize; j++)
                {
                    var currentChar = s[i + j];

                    if (!pDic.ContainsKey(currentChar))
                    {
                        i += j;
                        isAnagram = false;
                        break;
                    }

                    if (tempDic.ContainsKey(currentChar))
                        tempDic[currentChar]++;
                    else
                        tempDic[currentChar] = 1;

                    if (tempDic[currentChar] > pDic[currentChar])
                    {
                        isAnagram = false;
                        break;
                    }
                }

                if (isAnagram)
                    ans.Add(i);
            }

            return ans;
        }

        //TODO: Better solution
        /*
         *public class Solution {
       public IList<int> FindAnagrams(string s, string p)
        {
            if (p.Length > s.Length)
                return new List<int>();
            List<int> result = new List<int>();
            int[] mapP = new int[26];
            foreach (var symbol in p)
                mapP[symbol - 'a']++;
            for (int i = 0; i < p.Length; i++)
                mapP[s[i] - 'a']--;
            for (int i = p.Length; i < s.Length; i++)
            {
                if (IsAnagram(mapP))
                    result.Add(i - p.Length);
                mapP[s[i - p.Length] - 'a']++;
                mapP[s[i] - 'a']--;
            }
            if (IsAnagram(mapP))
                result.Add(s.Length - p.Length);
            return result;
        }
        bool IsAnagram(int[] map)
        {
            for (int i = 0; i < 26; i++)
                if (map[i] != 0)
                    return false;
            return true;
        }
}
         */
    }
}
