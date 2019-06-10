public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        // C# doesn't have native deque class, so use list just to complete the solution, it has worse time complexity
        // while inserting and removed from head and tail. O(1) for deque
        // but O(n) for removing at both head and tail, O(n) for adding at head for list
        if(nums.Length == 0 || k == 0)
            return new int[0];
        var deque = new List<int>();
        var result = new int[nums.Length - k + 1];
        for(var i = 0 ; i < nums.Length; i++){
            
            while(deque.Count != 0 && deque[0] < i - k + 1){
                deque.RemoveAt(0);
            }
            
            while(deque.Count != 0 && nums[i] > nums[deque[deque.Count - 1]]){
                deque.RemoveAt(deque.Count - 1);
            }
            
            deque.Add(i);
            if(i >= k - 1)
                result[i - k + 1] = nums[deque[0]];
        }
        
        return result;
    }
}