public class Solution {
    public int CountTriplets(int[] arr) {
        // c=a^b => a=c^b and b=c^a
        var ans = 0;
        for(var i = 0; i < arr.Length; ++i){
            for(var j = 0; j < i; ++j){
                int left, right;
                left = right = 0;
                for(var k = j; k <= i; ++k){
                    right ^= arr[k];
                }
                
                for(var k = j; k < i; ++k){
                    left ^= arr[k];
                    right ^= arr[k];
                    if(left == right)
                        ans++;
                }
            }
        }
        return ans;
    }
}