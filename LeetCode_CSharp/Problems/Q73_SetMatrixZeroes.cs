using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q73_SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            var xZeroSet = new HashSet<int>();
            var yZeroSet = new HashSet<int>();

            for (var y = 0; y < matrix.Length; y++)
            {
                var array = matrix[y];

                for (var x = 0; x < array.Length; x++)
                {
                    var num = array[x];

                    if (num == 0)
                    {
                        xZeroSet.Add(x);
                        yZeroSet.Add(y);
                    }
                }
            }

            for (var y = 0; y < matrix.Length; y++)
            {
                var array = matrix[y];

                var isYZero = yZeroSet.Contains(y);

                for (var x = 0; x < array.Length; x++)
                {
                    if (isYZero)
                    {
                        array[x] = 0;
                        continue;
                    }
                    
                    if (xZeroSet.Contains(x)) array[x] = 0;
                }
            }
        }
    }
}
