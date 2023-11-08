namespace New_LeetCode.Problems;

public class Q994_RottingOranges
{
    private const int Empty = 0;
    private const int Orange = 1;
    private const int Rotten = 2;
    
    public int OrangesRotting(int[][] grid)
    {
        var minutes = 0;

        while (true)
        {
            var rottenQueue = new Queue<ValueTuple<int, int>>();

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != Rotten) continue;
                
                    if (i - 1 >= 0 && grid[i - 1][j] == Orange) rottenQueue.Enqueue((i - 1, j));
                    if (j - 1 >= 0 && grid[i][j - 1] == Orange) rottenQueue.Enqueue((i, j - 1));
                    if (i + 1 < grid.Length && grid[i + 1][j] == Orange) rottenQueue.Enqueue((i + 1, j));
                    if (j + 1 < grid[i].Length && grid[i][j + 1] == Orange) rottenQueue.Enqueue((i, j + 1));
                }
            }

            if (!rottenQueue.Any())
                break;
        
            while (rottenQueue.Any())
            {
                var (i, j) = rottenQueue.Dequeue();

                grid[i][j] = Rotten;
            }

            minutes++;
        }

        var orangeCount = grid.SelectMany(_ => _).Count(_ => _ == Orange);

        return (orangeCount != 0) ? -1 : minutes;
    }
}