public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        if(target.Length != arr.Length) return false;
        var cnt = new int[1001];
        for(var i = 0; i < target.Length; ++i){
            cnt[target[i]]++;
            cnt[arr[i]]--;
        }
        
        foreach(var c in cnt){
            if(c != 0) return false;
        }
        return true;
    }
}