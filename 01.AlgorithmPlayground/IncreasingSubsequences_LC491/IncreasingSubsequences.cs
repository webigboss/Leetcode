using System.Collections.Generic;

public class IncreasingSubsequences
{
    public IncreasingSubsequences()
    {
        var nums = new[] { 4, 6, 7, 7 };
        var result = FindSubsequences(nums);
    }
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        var memo = new HashSet<string>();
        var result = new List<IList<int>>();
        DfsHelper(nums, 0, new List<int> { nums[0] }, memo, result);
        return result;
    }

    private void DfsHelper(int[] nums, int index, IList<int> list, HashSet<string> memo, IList<IList<int>> result)
    {
        if (list.Count > 1)
        {
            var str = string.Join(string.Empty, list);
            if (!memo.Contains(str))
            {
                result.Add(new List<int>(list));
                memo.Add(str);
            }
        }

        if (index == nums.Length - 1) return;

        for (var i = index + 1; i < nums.Length; i++)
        {
            DfsHelper(nums, i, new List<int>{ nums[i] }, memo, result);
            if (nums[i] < list[list.Count - 1]) continue;
            list.Add(nums[i]);
            DfsHelper(nums, i, list, memo, result);
            list.Remove(nums[i]);
        }
    }
}