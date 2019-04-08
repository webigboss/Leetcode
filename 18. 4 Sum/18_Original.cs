public class Solution {
    private Hashtable ht;
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        if(nums.Length < 4)
            return result;
        ht = new Hashtable();
        Array.Sort(nums);
        
        for(var i = 0; i <= nums.Length - 4; i++){
            ThreeSum(nums, i + 1, target - nums[i], nums[i], result);
        }
        return result;
    }
    
    private void ThreeSum(int[] nums, int li, int target, int first, IList<IList<int>> result){
        for(var i = li; i <= nums.Length - 3; i++){        
            TwoSum(nums, i + 1, nums.Length - 1, target - nums[i], first, nums[i], result);
        }
    }
    
    private void TwoSum(int[] nums, int li, int ri, int target, int first, int second, IList<IList<int>> result){
        while(li < ri){
            if(nums[li] + nums[ri] == target && !ht.ContainsKey($"{first}{second}{nums[li]}{nums[ri]}")){
                result.Add(new List<int>{first, second, nums[li], nums[ri]});
                ht.Add($"{first}{second}{nums[li]}{nums[ri]}", null);
                li++;
                ri--;
                
            }
            else if(nums[li] + nums[ri] > target){
                ri--;
            }
            else{//nums[li] + nums[ri] < target  
                li++;
            }
        }
    }
}