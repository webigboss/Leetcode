public class Solution {
    public int MaximumGap(int[] nums) {
        //Radix Sort Solution 
        if(nums.Length < 2)
            return 0;
        //1. Radix sort
        RadixSort(nums);
        
        //2. find max gap in the sorted array
        var maxGap = 0;
        for(var i = 1; i < nums.Length; i++){
            maxGap = Math.Max(maxGap, nums[i] - nums[i - 1]);
        }
        return maxGap;
    }
    
    private void RadixSort(int[] nums){
        var max = 0;
        foreach(var i in nums)
            max = Math.Max(max, i);
        var step = max.ToString().Length;
        var curStep = 0;
        while(curStep < step){
            CountingSort(nums, curStep++);
        }
    }
    
    private void CountingSort(int[] nums, int step){
        var arrCount = new int[10];
        var arrSorted = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++){
            arrCount[(nums[i] / (int)Math.Pow(10, step)) % 10]++;
        }
        
        for(var i = 1; i < 10; i++){
            arrCount[i] += arrCount[i - 1];
        }
        
        //reverse iterating the array to make sure the sort is stable
        for(var i = nums.Length - 1; i >= 0; i--){
            arrSorted[--arrCount[(nums[i] / (int)Math.Pow(10, step)) % 10]] = nums[i];
        }
        
        //update the values in nums, cannot assign arrSorted to nums, because nums in the caller of RadixSort still reference the old address of nums
        for(var i = 0; i < nums.Length; i++)
            nums[i] = arrSorted[i];
    }
}