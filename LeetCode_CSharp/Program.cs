using System.Collections.Generic;
using LeetCode_CSharp.Problems;

namespace LeetCode_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var question = new Q79_WordSearch();

            var board = new char[3][];
            board[0] = new[] { 'A', 'B', 'C', 'E' };
            board[1] = new[] { 'S', 'F', 'E', 'S' };
            board[2] = new[] { 'A', 'D', 'E', 'E' };

            var result = question.Exist(board, "ABCESEEEFS");
        }
    }
}
