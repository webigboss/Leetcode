public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        // DP Solution
        var result = new List<int>();
        var n = nums.Length;
        if(n == 0) return result;
        // this problem need 2 dp array
        var count = new int[n];
        var preIndex = new int[n];
        
        Array.Sort(nums);
        
        //base case
        
        var maxIndex = 0;
        var maxLength = 1;
        for(var i = 0; i < n; i++){
            count[i] = 1;
            preIndex[i] = -1;
            for(var j = i - 1; j >= 0; j--){
                if(nums[i] % nums[j] == 0){
                    if(count[j] + 1 > count[i]) {
                        count[i] = count[j] + 1;
                        preIndex[i] = j;
                    }
                }
            }
            if(count[i] > maxLength){
                maxLength = count[i];
                maxIndex = i;
            }
        }
        
        while(maxIndex >= 0){
            result.Add(nums[maxIndex]);
            maxIndex = preIndex[maxIndex];
        }
        
        return result;
    }
}