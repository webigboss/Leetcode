using System;
using System.Collections.Generic;
using System.Linq;

// https://www.1point3acres.com/bbs/thread-804265-1-1.html
// given 2 lists of pairs of router id and distance: forwardRouterList/returnRouterList and a maxLength, 
// return all the pairs of router ids with the max distance but not exceeds maxLength

public class AmazonOA_16_MaxRoundTripDistanceNotExceedsMaxLength {
    public void Test(){
        List<int[]> forwardRouterList;
        List<int[]> returnRouterList;
        int maxLength;
        List<int[]> ans;
        Console.WriteLine("-------------------");
        forwardRouterList = new List<int[]>{new []{1, 2000}, new []{2, 4000}, new []{3, 6000}};
        returnRouterList = new List<int[]>{new int[]{1, 2000}};
        maxLength = 7000;
        Console.WriteLine(Get_PrintableRouterList(forwardRouterList));
        Console.WriteLine(Get_PrintableRouterList(returnRouterList));
        ans = MaxRoundTripDistanceNotExceedsMaxLength(forwardRouterList, returnRouterList, maxLength);
        Console.WriteLine($"MaxRoundTripDistanceNotExceedsMaxLength(maxLength:{maxLength}) -> {Get_PrintableRouterList(ans)}");
        Console.WriteLine("-------------------");
        forwardRouterList = new List<int[]>{new []{1, 2000}, new []{2, 4000}, new []{3, 6000}, new []{4, 4000}};
        returnRouterList = new List<int[]>{new int[]{1, 2000}};
        maxLength = 7000;
        Console.WriteLine(Get_PrintableRouterList(forwardRouterList));
        Console.WriteLine(Get_PrintableRouterList(returnRouterList));
        ans = MaxRoundTripDistanceNotExceedsMaxLength(forwardRouterList, returnRouterList, maxLength);
        Console.WriteLine($"MaxRoundTripDistanceNotExceedsMaxLength(maxLength:{maxLength}) -> {Get_PrintableRouterList(ans)}");
        Console.WriteLine("-------------------");
        forwardRouterList = new List<int[]>{new []{1, 2000}, new []{2, 4000}, new []{3, 6000}, new []{4, 4000}};
        returnRouterList = new List<int[]>{new int[]{1, 2000}, new []{4,4000}};
        maxLength = 7000;
        Console.WriteLine(Get_PrintableRouterList(forwardRouterList));
        Console.WriteLine(Get_PrintableRouterList(returnRouterList));
        ans = MaxRoundTripDistanceNotExceedsMaxLength(forwardRouterList, returnRouterList, maxLength);
        Console.WriteLine($"MaxRoundTripDistanceNotExceedsMaxLength(maxLength:{maxLength}) -> {Get_PrintableRouterList(ans)}");
    }

    private string Get_PrintableRouterList(List<int[]> routerList){
        return $"[{string.Join(',', routerList.Select(r=>$"[{string.Join(',', r)}]"))}]";
    }

    public List<int[]> MaxRoundTripDistanceNotExceedsMaxLength(List<int[]> forwardRouterList, List<int[]> returnRouterList, int maxLength){
        forwardRouterList.Sort((a, b) => a[1] - b[1]);
        returnRouterList.Sort((a,b) => a[1] - b[1]);
        int l = 0, r = returnRouterList.Count-1, curMax = 0;
        var ans = new List<int[]>();
        while(l < forwardRouterList.Count && r >= 0) {
            int[] cur_f = forwardRouterList[l], cur_r = returnRouterList[r];
            int cur_dist = cur_f[1] + cur_r[1];
            if(cur_dist <= maxLength) {
                if (cur_dist > curMax)
                    ans.Clear();
                curMax = cur_dist;
                ans.Add(new int[]{cur_f[0], cur_r[0]});
                l++;
            }
            else{
                r--;
            }
        }
        return ans;
    }
}