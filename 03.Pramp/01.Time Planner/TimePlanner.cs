using System;

class Solution
{
    //Node: inspired by LeetCode 223. Rectangle Area
    //TC: linear O(n+m): n: length of slotsA, m: Length of slotsB
    //SC: O(1)

    public static int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
    {
      var ia = 0;
      var ib = 0;
      while(ia < slotsA.GetLength(0) && ib < slotsB.GetLength(0)){
        var start = Math.Max(slotsA[ia, 0], slotsB[ib, 0]);
        var end = Math.Min(slotsA[ia, 1], slotsB[ib, 1]);
        if(end - start >= dur)
          return new[]{start, start + dur};
        else {
          if(slotsA[ia, 1] < slotsB[ib, 1])
            ia++;
          else
            ib++;
        } 
      }
      return new int[]{};
    }

    static void Main(string[] args)
    {

    }
}

