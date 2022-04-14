using System.Collections.Generic;

namespace LeetCode_CSharp.Problems
{
    internal class Q17LetterCombinationsOfAPhoneNumber
    {
        private readonly List<string[]> digitsToString = new List<string[]> {
            new[]{""},
            new[]{""},
            new[]{"a", "b", "c"},
            new[]{"d", "e", "f"},
            new[]{"g", "h", "i"},
            new[]{"j", "k", "l"},
            new[]{"m", "n", "o"},
            new[]{"p", "q", "r", "s"},
            new[]{"t", "u", "v"},
            new[]{"w", "x", "y", "z"}
        };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();

            if (digits.Equals("")) return result;

            foreach (var d in digitsToString[digits[0] - 48]) result.Add(d);

            for (var x = 1; x < digits.Length; x++)
            {
                var tempResult = new List<string>();
                var digitToInt = digits[x] - 48;

                foreach (var s in result)
                {
                    foreach (var d in digitsToString[digitToInt])
                    {
                        tempResult.Add(s + d);
                    }
                }

                result = tempResult;
            }

            return result;
        }
    }
}
