public class Solution {
    public int CountArrangement(int N) {
        return Helper(N, 1, new HashSet<int>());
    }
    
    private int Helper(int N, int cur, HashSet<int> used){
        if(cur == N + 1) return 1;
        var count = 0;
        
        for(var i = 1; i <= N; i++){
            if(used.Contains(i)) continue;
            if(i % cur != 0 && cur % i != 0) continue;
            used.Add(i);
            count += Helper(N, cur + 1, used);
            used.Remove(i);
        }
        return count;
    }
}