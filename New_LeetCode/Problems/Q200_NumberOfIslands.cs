namespace New_LeetCode.Problems;

public class Q200_NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;

        var rowCount = grid.Length;
        var colCount = grid[0].Length;

        var hasBeen = new bool[rowCount, colCount];
        var islandCount = 0;

        for (var row = 0; row < rowCount; row++)
        {
            for (var col = 0; col < colCount; col++)
            {
                if (grid[row][col] == '0') continue;
                if (hasBeen[row, col]) continue;

                WalkIsland(grid, row, col, hasBeen);
                islandCount++;
            }
        }

        return islandCount;
    }

    private static void WalkIsland(char[][] grid, int row, int col, bool[,] hasBeen)
    {
        if (row < 0 || col < 0 || row > grid.Length - 1 || col > grid[0].Length - 1) return;
        if (hasBeen[row, col]) return;
        if (grid[row][col] == '0') return;

        hasBeen[row, col] = true;

        WalkIsland(grid, row, col + 1, hasBeen);
        WalkIsland(grid, row + 1, col, hasBeen);
        WalkIsland(grid, row, col - 1, hasBeen);
        WalkIsland(grid, row - 1, col, hasBeen);
    }
}