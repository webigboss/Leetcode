using System;
using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/discuss/interview-question/1495982/Amazon-OA
public class AmazonOA_12_MergeConsecutiveIntervals
{

    public void Test()
    {
        List<int[]> chunks;
        List<List<int[]>> ans;
        chunks = new List<int[]> { new[] { 7, 9 }, new[] { 1, 3 }, new[] { 8, 15 }, new[] { 6, 9 }, new[] { 2, 4 } };
        ans = MergeConsecutiveIntervals(chunks);
        PrintAns(ans);
        chunks = new List<int[]> { new[] { 1, 3 }, new[] { 8, 15 }, new[] { 6, 9 }, new[] { 2, 5 }, new[] { 1, 9 } };
        ans = MergeConsecutiveIntervals(chunks);
        PrintAns(ans);
    }

    private void PrintAns(List<List<int[]>> ans)
    {
        Console.WriteLine("Ans:");
        foreach (var a in ans)
        {
            Console.WriteLine($"[{string.Join(',', a.Select(e => $"[{e[0]},{e[1]}]"))}]");
        }
    }

    public List<List<int[]>> MergeConsecutiveIntervals(List<int[]> chunks)
    {
        int n = chunks.Count;
        var ans = new List<List<int[]>>();
        List<int[]> intervals = new List<int[]>();
        for (var i = 0; i < n; ++i)
        {
            intervals = InsertIntervals(intervals, chunks[i]);
            ans.Add(intervals);
        }
        return ans;
    }

    List<int[]> InsertIntervals(List<int[]> chunks, int[] newChunk)
    {
        var ans = new List<int[]>();
        int n = chunks.Count, l = newChunk[0], r = newChunk[1];
        bool inserted = false;

        for (var i = 0; i < n; i++)
        {
            var cur = chunks[i];
            if (inserted)
            {
                ans.Add(cur);
                continue;
            }
            if (r < cur[0])
            { // on the left side
                ans.Add(new[] { l, r });
                ans.Add(cur);
                inserted = true;
            }
            else if (l > cur[1])
            { // on the right side
                ans.Add(cur);
            }
            else
            { // overlapped
                l = Math.Min(l, cur[0]);
                r = Math.Max(r, cur[1]);
            }
        }

        if (!inserted)
            ans.Add(new[] { l, r });
        return ans;
    }
}