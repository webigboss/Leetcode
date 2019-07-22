public class Solution {
    //Fisher-Yates Algorithm
    private int[] arr;
    private int[] original;
    private Random rdn;
    public Solution(int[] nums) {
        arr = nums;
        original = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++)
            original[i] = nums[i];
        rdn = new Random();
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        for(var i = 0; i < original.Length; i++)
            arr[i] = original[i];
        return arr;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for(var i = 0; i < arr.Length; i++){
            var rndIndex = i + rdn.Next(arr.Length - i);
            Swap(arr, i, rndIndex);
        }
        return arr;
    }
    
    private void Swap(int[] nums, int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */