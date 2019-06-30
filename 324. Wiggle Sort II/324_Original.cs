public class Solution {
    public void WiggleSort(int[] nums) {
        if(nums.Length == 0) return;
        var median = FindKthLargest(nums, (int)((nums.Length + 1) / 2));
        var result = new int[nums.Length];
        var ibig = 1;
        var ismall = nums.Length % 2 == 0 ? nums.Length - 2 : nums.Length - 1;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] > median){
                result[ibig] = nums[i];
                ibig += 2;
                continue;
            }
            
            if(nums[i] < median){
                result[ismall] = nums[i];
                ismall -= 2;
                continue;
            }
        }
        
        while(ibig <= nums.Length - 1){
            result[ibig] = median;
            ibig += 2;
        }
        
        while(ismall >= 0){
            result[ismall] = median;
            ismall -= 2;
        }
        
        for(var i = 0; i < nums.Length; i++)
            nums[i] = result[i];
    }
    
    // different implemntations can refer to https://leetcode.com/problems/kth-largest-element-in-an-array/discuss/60294/Solution-explained
    // can have quickselect solution with T: O(n), S: O(1), here I'm just use the trivial sort solution
    private int FindKthLargest(int[] nums, int k){
        Array.Sort(nums);
        return nums[nums.Length - k];
    }
}