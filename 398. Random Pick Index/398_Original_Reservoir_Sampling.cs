public class Solution {
    //reservoir sampling approach
    private int[] arr;
    private Random rdn;
    public Solution(int[] nums) {
        arr = nums;
        rdn = new Random();
    }
    
    public int Pick(int target) {
        var result = 0;
        var count = 0;
        for(var i = 0; i < arr.Length; i++){
            if(arr[i] == target){
                count++;
                result = rdn.Next(count) == 0 ? i : result;
            }
        }
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */