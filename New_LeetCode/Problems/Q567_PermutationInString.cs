using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_LeetCode.Problems
{
    internal class Q567_PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var s1Dic = new Dictionary<char, int>();

            foreach (var c in s1)
            {
                if (s1Dic.ContainsKey(c))
                    s1Dic[c]++;
                else
                    s1Dic[c] = 1;
            }

            var window = s1.Length;
            for (var i = 0; i <= s2.Length - window; i++)
            {
                var checkDic = new Dictionary<char, int>();

                for (var j = 0; j < window; j++)
                {
                    var c = s2[i + j];

                    if (!s1Dic.ContainsKey(c))
                        break;

                    if (checkDic.ContainsKey(c))
                        checkDic[c]++;
                    else
                        checkDic[c] = 1;

                    if (checkDic[c] > s1Dic[c])
                        break;
                }

                if (s1Dic.Keys.All(key => checkDic.ContainsKey(key) && checkDic[key] == s1Dic[key]))
                    return true;
            }

            return false;
        }
    }
}
