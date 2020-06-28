public class Solution {
    public bool CanArrange(int[] arr, int k) {
        if(k == 1) return true;
        var dict = new Dictionary<int, int>();
        for(var i = 1-k; i < k; ++i)
            dict[i] = 0;
        foreach(var num in arr){
            var mod = num%k;
            dict[mod]++;
        }
        
        if(dict[0]%2 != 0) return false;
        
        for(var i = 1; i < k; ++i){
            if(dict[i] - dict[k-i] != dict[-i] - dict[i-k]) return false;
        }
        return true;
    }
}