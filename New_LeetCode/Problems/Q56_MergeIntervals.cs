namespace New_LeetCode.Problems;

internal class Q56MergeIntervals
{
    static List<int[]> _result;
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, delegate (int[] x, int[] y) { return x[0].CompareTo(y[0]); });
        _result = new List<int[]>();
        foreach (var i in intervals)
        {
            var overLapIndex = GetOverLap(i);

            if (overLapIndex != -1)
            {
                var largerInt = (_result[overLapIndex][1] >= i[1]) ? _result[overLapIndex][1] : i[1];

                _result[overLapIndex] = new int[] { _result[overLapIndex][0], largerInt };
            }
            else
                _result.Add(i);
        }
        return _result.ToArray();
    }

    public int GetOverLap(int[] target)
    {
        for (var x = 0; x < _result.Count; x++)
        {
            if (_result[x][0] <= target[0] && target[0] <= _result[x][1])
                return x;
        }

        return -1;
    }
}