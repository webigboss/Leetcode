public class Solution {
    public int LongestConsecutive(int[] nums) {
        //Hashtable solution
        if(nums.Length == 0)
            return 0;
        var ht = new Hashtable();
        var counter = 0;
        var result = 0;
        int cur;
        foreach(var i in nums){
            if(!ht.Contains(i))
                ht.Add(i, null);
        }
            
        
        for(var i = 0; i < nums.Length; i++){
            if(!ht.Contains(nums[i] - 1)){
                cur = nums[i];
                counter = 0;
                while(ht.Contains(cur)){
                    counter++;
                    cur++;
                }
                result = Math.Max(counter, result);
            }
        }
        return result;
    }
}