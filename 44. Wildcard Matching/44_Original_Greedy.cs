public class Solution {
    public bool IsMatch(string s, string p) {
        //greedy approach
        //https://leetcode.com/problems/wildcard-matching/discuss/17810/Linear-runtime-and-constant-space-solution
        int si = 0, pi = 0, lastStar = -1, lastAfterMatch = -1;
        
        while(si < s.Length){
            if(pi < p.Length && (s[si] == p[pi] || p[pi] == '?')){
                si++; 
                pi++;
            }
            else if(pi < p.Length && p[pi] == '*'){
                lastStar = pi;
                //starting with make * match empty, so pi advance by 1 but lastAfterMatch remains at si 
                pi++;
                lastAfterMatch = si;
            }
            else if(lastStar != -1){
                //wrong answer case, reset pi back to lastStar, pi still advance by 1, but si advance from lastAfterMatch by 1, since we know current lastAfterMatch led to a wrong answer.
                pi = lastStar;
                pi++;
                lastAfterMatch++;
                si = lastAfterMatch;
            }
            else return false;
        }
        
        while(pi < p.Length){
            if(p[pi++] != '*') return false;
        }
        return true;
    }
}