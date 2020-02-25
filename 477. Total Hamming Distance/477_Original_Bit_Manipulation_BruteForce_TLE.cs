public class Solution {
    public int TotalHammingDistance(int[] nums) {
        var result = 0;
        for(var i = 0; i < nums.Length; i++){
            for(var j = i + 1; j < nums.Length; j++){
                result += HammingDistance(nums[i], nums[j]);
            }
        }
        return result;
    }
    
    private int HammingDistance(int i, int j){
        if(i == j) return 0;
        var n = i ^ j;
        //get bit count which of XOR which is the hamming distance
        var distance = 0;
        while(n != 0){
            n &= n - 1;
            distance++;
        }
        return distance;
    }
}