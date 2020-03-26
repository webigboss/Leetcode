public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var counts = new int[26];
        foreach(var c in tasks)
            counts[c - 'A']++;
        
        Array.Sort(counts);
        var intervals = 0;
        var idleCount = 0;
        while(counts[25] > 0){
            idleCount = 0;
            for(var i = 0; i <= n; i++){
                if(25 - i < 0 || counts[25 - i] == 0)
                    idleCount++;
                else
                    counts[25 - i]--;
                intervals++;
            }
            Array.Sort(counts);
        }
        return intervals - idleCount;
    }
}