public class Solution {
    public bool IsPossible(int[] nums) {
        //https://leetcode.com/problems/split-array-into-consecutive-subsequences/discuss/106496/Java-O(n)-Time-O(n)-Space
        //two pass greedy TC O(n) solution
        var freq = new Dictionary<int, int>();
        var lastEleNeeded = new Dictionary<int, int>();
        
        foreach(var n in nums){
            if(!freq.ContainsKey(n))
                freq[n] = 1;
            else
                freq[n]++;
        }
        
        foreach(var n in nums){
            //greedy if current number can be appended to an existing subsequence, then append it, if no then see if there exist n+1 and n+2 so we can create a new subsequence;
            if(freq[n] == 0) continue;
            if(lastEleNeeded.ContainsKey(n) && lastEleNeeded[n] > 0){
                lastEleNeeded[n]--;
                freq[n]--;
                if(!lastEleNeeded.ContainsKey(n+1))
                    lastEleNeeded[n+1] = 1;
                else
                    lastEleNeeded[n+1]++;
            }
            else if(freq.ContainsKey(n+1) && freq[n+1] > 0 
                   && freq.ContainsKey(n+2) && freq[n+2] > 0){
                freq[n+1]--;
                freq[n+2]--;
                freq[n]--;
                if(!lastEleNeeded.ContainsKey(n+3))
                    lastEleNeeded[n+3] = 1;
                else
                    lastEleNeeded[n+3]++;

            }
            else
                return false;
        }
        return true;
    }
}