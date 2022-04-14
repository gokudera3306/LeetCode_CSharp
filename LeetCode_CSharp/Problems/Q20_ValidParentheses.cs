using System.Collections.Generic;

namespace LeetCode_CSharp.Problems
{
    internal class Q20ValidParentheses
    {
        private readonly Dictionary<char, bool> pushPullDic = new Dictionary<char, bool>
        {
            {'(', true},
            {'{', true},
            {'[', true},
            {')', false},
            {'}', false},
            {']', false},
        };

        private readonly Dictionary<char, char> pairDic = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['},
        };

        public bool IsValid(string s)
        {
            var stringStack = new Stack<char>();

            for (var x = 0; x < s.Length; x++)
            {
                if (pushPullDic[s[x]])
                    stringStack.Push(s[x]);
                else
                {
                    if (stringStack.Count == 0) return false;

                    var tempChar = stringStack.Peek();

                    if (pairDic[s[x]] == tempChar)
                        stringStack.Pop();
                    else
                        return false;
                }
            }

            if (stringStack.Count > 0) return false;

            return true;
        }
    }
}
