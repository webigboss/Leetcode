public class Solution {
    public void Rotate(int[] nums, int k) {
        var a = new int[nums.Length];
        
        for(var i = 0; i < nums.Length; i++){
            a[(k + i) % nums.Length] = nums[i];
        }
        
        for(var i = 0; i < nums.Length; i++){
            nums[i] = a[i];
        }
    }
}