public class Solution {
    public int TotalHammingDistance(int[] nums) {
        //count XOR in every bit of int32
        var countOfBit1 = new int[32];
        var l = nums.Length;
        for(var i = 0; i < l; i++){
            for(var j = 0; j < countOfBit1.Length; j++){
                if((nums[i] >> j & 1) == 1) //or (nums[i] >> j) % 2 == 1, to check if the right most bit is 1;
                    countOfBit1[j]++;
            }
        }
        var result = 0;
        for(var i = 0; i < countOfBit1.Length; i++){
            result += countOfBit1[i] * (l - countOfBit1[i]);
        }
        return result;
    }
}