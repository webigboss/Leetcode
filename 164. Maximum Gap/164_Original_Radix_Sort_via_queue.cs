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
        var arrQ = new Queue<int>[10];
        for(var i = 0; i < nums.Length; i++){
            var countIndex = (nums[i] / (int)Math.Pow(10, step)) % 10;
            if(arrQ[countIndex] == null)
                arrQ[countIndex] = new Queue<int>();
            arrQ[countIndex].Enqueue(nums[i]);
        }
        var index = 0;
        for(var i = 0; i < 10; i++){
            if(arrQ[i] == null)
                continue;
            while(arrQ[i].Count > 0){
                nums[index++] = arrQ[i].Dequeue();
            }
        }
    }
}