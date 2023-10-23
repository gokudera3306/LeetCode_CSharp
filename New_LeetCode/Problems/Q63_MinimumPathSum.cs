namespace New_LeetCode.Problems;

public class Q63_MinimumPathSum
{
    public int MinPathSum(int[][] grid)
    {
        if (grid.Length == 0) return 0;
        if (grid.First().Length == 0) return 0;

        var sumTable = new int[grid.Length, grid[0].Length];

        for (var row = 0; row < grid.Length; row++)
        {
            for (var col = 0; col < grid[0].Length; col++)
            {
                int previousSum;

                if (row == 0 && col == 0)
                {
                    previousSum = 0;
                }
                else if (row == 0)
                {
                    previousSum = sumTable[row, col - 1];
                }
                else if (col == 0)
                {
                    previousSum = sumTable[row - 1, col];
                }
                else
                {
                    var leftValue = sumTable[row, col - 1];
                    var topValue = sumTable[row - 1, col];
                    previousSum = Math.Min(leftValue, topValue);
                }
                    
                sumTable[row, col] = previousSum + grid[row][col];
            }
        }
            
        return sumTable[grid.Length - 1, grid.First().Length - 1];
    }
}