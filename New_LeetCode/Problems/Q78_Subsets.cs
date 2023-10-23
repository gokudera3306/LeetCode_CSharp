﻿namespace New_LeetCode.Problems;

public class Q78_Subsets
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>() {new List<int>()};

        foreach (var num in nums)
        {
            var resultCount = result.Count;

            for (var index = 0; index < resultCount; index++)
            {
                var newList = result[index].ToList();
                newList.Add(num);

                result.Add(newList);
            }
        }

        return result;
    }
}