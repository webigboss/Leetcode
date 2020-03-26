public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var counts = new int[26];
        foreach(var c in tasks)
            counts[c - 'A']++;
        
        Array.Sort(counts);
        var intervals = 0;
        var curCount = 0;
        var iterationSize = Math.Min(n, 25);
        while(counts[25] > 0){
            curCount = 0;
            for(var i = 0; i <= iterationSize; i++){
                if(counts[25 - i] > 0){
                    counts[25 - i]--;
                    curCount++;
                }
            }
            Array.Sort(counts);
            if(counts[25] == 0){
                intervals += curCount;
            }
            else
                intervals += (n + 1);
        }
        return intervals;
    }
}