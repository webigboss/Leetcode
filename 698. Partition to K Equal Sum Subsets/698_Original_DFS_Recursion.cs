public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        //DFS recursion with optimization by target and sorting same as 473
        
        //sort the array in descending order
        Array.Sort(nums, (a, b) => b - a);
        
        var sum = 0;
        foreach(var n in nums)
            sum += n;
        if(sum % k != 0) return false;
        
        return DfsHelper(nums, 0, new int[k], sum / k);
    }
    
    private bool DfsHelper(int[] nums, int index, int[] sums, int target){
        if(index == nums.Length){
            foreach(var sum in sums){
                if(sum != target) return false;
            }
            return true;
        }
        
        for(var i = 0; i < sums.Length; i++){
            if(sums[i] + nums[index] > target) continue;
            sums[i] += nums[index];
            if(DfsHelper(nums, index + 1, sums, target))
                return true;
            sums[i] -= nums[index];
        }
        return false;
    }
}