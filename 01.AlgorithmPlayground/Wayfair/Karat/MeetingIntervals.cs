using System;
using System.Collections.Generic;
using System.Linq;

public class MeetingIntervals{
    
    private int[][] intervals = new int[][]{
        new []{800, 900}, new []{1030, 1100}, new []{1300, 1400}, new []{1700, 1800}
    };

    public void Test_IfAvailable(){
        int start = 930, end = 1045;
        var ans = IfAvailable(intervals, start, end);
        PrintResult_IfAvailable(ans, start, end);
        start = 1100; end = 1130;
        ans = IfAvailable(intervals, start, end);
        PrintResult_IfAvailable(ans, start, end);
        start = 1330; end = 1750;
        ans = IfAvailable(intervals, start, end);
        PrintResult_IfAvailable(ans, start, end);
    }
    
    private void PrintResult_IfAvailable(bool ans, int start, int end){
        Console.WriteLine($"IfAvailable({start},{end}) -> {ans}");
    }

    public bool IfAvailable(int[][] intervals, int start, int end){
        Array.Sort(intervals, (a, b)=> a[0]-b[0]);
        int n = intervals.Length;
        int[] test = new int[]{start, end};
        for(var i = 0; i < n; i++) {
            if(IsOverlap(intervals[i], test)){
                return false;
            }
            if(end <= intervals[i][0]){
                break;
            }
        }
        return true;
    }

    private bool IsOverlap(int[] a, int[] b){
        return a[1] > b[0] && a[0] < b[1];
    }

    private int[][] booking1 = new int[][]{
        new int[]{800, 1000}, new int[]{1100, 1400}, new int[]{1700, 1800}
    };
    private int[][] booking2 = new int[][]{
        new int[]{800, 1200}, new int[]{1100, 1400}, new int[]{1700, 1800}
    };
    private int[][] booking3 = new int[][]{
        new int[]{800, 900}, new int[]{1100, 1400}, new int[]{1200, 1300}, new int[]{1700, 1800}
    };
    
    public void Test_FindAllAvailableIntervals(){
        var ans = FindAllAvailableIntervals(booking1);
        PrintResult_FindAllAvailableIntervals(ans);
        ans = FindAllAvailableIntervals(booking2);
        PrintResult_FindAllAvailableIntervals(ans);
        ans = FindAllAvailableIntervals(booking3);
        PrintResult_FindAllAvailableIntervals(ans);
    }

    private void PrintResult_FindAllAvailableIntervals(List<int[]> ans){
        Console.WriteLine($"[{string.Join(',', ans.Select(e=> $"[{e[0]},{e[1]}]"))}]");
    }
    public List<int[]> FindAllAvailableIntervals(int[][] booked){
        var ans = new List<int[]>(); // booked: [[800, 1200], [1100, 1400], [1700, 1800]
        Array.Sort(booked, (a,b)=>a[0]-b[0]);
        int start = 0, n = booked.Length; // ans: [[0,800], [1400, 1700]]
        for(var i = 0; i < n; ++i){ // i = 2, start = 1800
            if(start < booked[i][0]){
                ans.Add(new int[]{start, booked[i][0]});
            }
            start = Math.Max(start, booked[i][1]);
        }

        if(start < 2400){
            ans.Add(new int[]{start, 2400});
        }
        return ans;
    }
}