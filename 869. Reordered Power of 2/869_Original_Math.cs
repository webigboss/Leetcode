public class Solution {
    public bool ReorderedPowerOf2(int N) {
        var cnt = new int[10];
        var s = N.ToString();
        foreach(var c in s)
            cnt[c-'0'] += 1;
        
        for(var i = 0; i <= 29; ++i){
            if(IsSame(Math.Pow(2, i).ToString(), cnt)) return true;    
        }
        return false;
    }
    
    bool IsSame(string a, int[] cnt){
        var arr = new int[10];
        foreach(var c in a)
            arr[c-'0']++;
        
        for(var i = 0; i < 10; ++i){
            if(arr[i] != cnt[i]) return false;
        }
        return true;
    }
}