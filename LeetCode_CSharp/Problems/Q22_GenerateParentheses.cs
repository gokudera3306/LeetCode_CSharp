using System;
using System.Collections.Generic;

namespace LeetCode_CSharp.Problems
{
    internal class Q22GenerateParentheses
    {
        internal class Parenthesis
        {
            public int FrontCount;
            public int EndCount;

            public string parenthesis;

            public Parenthesis(int fCount, int eCount, string pString)
            {
                FrontCount = fCount;
                EndCount = eCount;

                parenthesis = pString;
            }

            public bool HasTwoOption()
            {
                return EndCount > FrontCount && FrontCount != 0;
            }

            public Parenthesis Copy()
            {
                return new Parenthesis(FrontCount, EndCount, parenthesis);
            }

            public void AddFront()
            {
                FrontCount--;
                parenthesis += "(";
            }

            public void AddEnd()
            {
                EndCount--;
                parenthesis += ")";
            }

            public void AddOne()
            {
                if (FrontCount == EndCount || FrontCount > 0)
                    AddFront();
                else
                    AddEnd();
            }
        }

        public IList<string> GenerateParenthesis(int n)
        {

            var result = new List<string>();

            if (n == 0) return result;

            var pList = new List<Parenthesis> { new Parenthesis(n-1, n, "(") };

            for (var x = 0; x < 2*n - 1; x++)
            {
                var tempP = new List<Parenthesis>();

                foreach (var p in pList)
                {
                    Console.WriteLine("x: " + x + " p: " + p.parenthesis);

                    if (p.HasTwoOption())
                    {
                        var newP = p.Copy();

                        p.AddFront();
                        newP.AddEnd();

                        tempP.Add(newP);
                    }
                    else
                        p.AddOne();
                }

                pList.AddRange(tempP);
            }

            foreach (var p in pList)
                result.Add(p.parenthesis);

            return result;
        }
    }
}
