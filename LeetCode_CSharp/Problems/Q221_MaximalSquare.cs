using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q221_MaximalSquare
    {
        public int MaximalSquare(char[][] matrix)
        {
            var rowCount = matrix.Length;
            var colCount = matrix[0].Length;

            var sqareMap = new int[rowCount, colCount];
            var maxSquare = 0;

            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] == '0') continue;

                    var currentSquare = GetCurrentSquare(sqareMap, row, col);
                    sqareMap[row, col] = currentSquare;
                    maxSquare = Math.Max(maxSquare, currentSquare * currentSquare);
                }
            }

            return maxSquare;
        }

        private int GetCurrentSquare(int[,] map, int row, int col)
        {
            if (row == 0 || col == 0) return 1;

            var top = map[row - 1, col];
            var left = map[row, col - 1];
            var leftTop = map[row - 1, col - 1];

            if (top == left && left == leftTop)
                return map[row - 1, col] + 1;

            var min = Math.Min(top, left);
            min = Math.Min(min, leftTop);

            return min + 1;
        }
    }
}
