public class Solution {
    public void Rotate(int[] nums, int k) {
        var q = new Queue();
        var start = nums.Length - k % nums.Length;
        for(var i = 0; i < nums.Length; i++){
            q.Enqueue(nums[(start + i) % nums.Length]);
        }
        for(var j = 0; j < nums.Length; j++){
            nums[j] = (int)q.Dequeue();
        }
    }
}