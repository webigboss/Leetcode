using System;
using System.Collections.Generic;

public class Google_FR_TopKFrequencyElement {

    public void Test() {
        int[] nums;
        int[] ans;
        int k;
        nums = new int[] {1,1,1,2,2,2,3,3,3,3};
        k = 2;
        ans = TopKFrequencyElement(nums, k);
        Console.WriteLine($"nums: {string.Join(',', nums)}, k: {k} -> [{string.Join(',', ans)}]");
        nums = new int[] {1,1,1,2,2,2,3,3,3,3};
        k = 1;
        ans = TopKFrequencyElement(nums, k);
        Console.WriteLine($"nums: {string.Join(',', nums)}, k: {k} -> [{string.Join(',', ans)}]");
        nums = new int[]{1,1,2,2};
        k = 1;
        ans = TopKFrequencyElement(nums, k);
        Console.WriteLine($"nums: {string.Join(',', nums)}, k: {k} -> [{string.Join(',', ans)}]");

    }

    // variant of https://leetcode.com/problems/top-k-frequent-elements/
    // differnt: will have nums has same frequency, if it happens, output all, and keep original order
    public int[] TopKFrequencyElement(int[] nums, int k) {
        int n = nums.Length;
        var dict = new Dictionary<int,int[]>();
        for(var i = 0; i < n; i++) {
            if(!dict.ContainsKey(nums[i]))
                dict[nums[i]] = new int[]{i, 0};
            dict[nums[i]][1]++;
        }
        var frequencies = new List<int[]>[n+1];
        foreach(var kvp in dict) {
            var freq = kvp.Value[1];
            if(frequencies[freq] == null){
                frequencies[freq] = new List<int[]>();
            }
            frequencies[freq].Add(new int[]{kvp.Value[0], kvp.Key});
        }
        var ans = new List<int>();
        for(var i = n; i >=0 && k > 0; --i){
            if(frequencies[i] == null)
                continue;
            var list = frequencies[i];
            list.Sort((a,b) => a[0]-b[0]);
            foreach(var ele in list) {
                ans.Add(ele[1]);
            }
            k--;
        }
        return ans.ToArray();
    }

}