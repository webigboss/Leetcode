using System;
using System.Collections.Generic;
using System.Collections;

public class AmazonOA_TopKCombinationSum {

    public void Test() {
        int[] nums;
        List<int> ans;
        nums = new int[]{3,1,-2,5};
        ans = TopKCombinationSum(nums, 3);
        PrintIEnumerable(ans);
    }

    private void PrintIEnumerable(IEnumerable<int> e){
        Console.WriteLine($"[{string.Join(',',e)}]");
    }

    public List<int> TopKCombinationSum(int[] nums, int k){
        //Array.Sort(nums);
        var sums = new List<int>();
        BacktrackingHelper(nums, 0, 0, sums);
        sums.Sort((a,b)=>b-a);
        PrintIEnumerable(sums);
        var ans = new List<int>();
        for(var i = 0; i < k; ++i)
            ans.Add(sums[i]);
        return ans;
    }

    private void BacktrackingHelper(int[] nums, int k, int curSum, List<int> sums){
        if(k == nums.Length){
            sums.Add(curSum);
            return;
        }

        for(var i = k; i < nums.Length; ++i){
            BacktrackingHelper(nums, i+1, curSum+nums[i], sums);
            // this is unnecessary if using for loop
            // BacktrackingHelper(nums, i+1, curSum, sums); 
        }
    }
}