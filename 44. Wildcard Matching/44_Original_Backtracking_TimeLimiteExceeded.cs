public class Solution {
    public bool IsMatch(string s, string p) {
        //backtacking approach
        return BacktrackingHelper(s, p, 0, 0);
    }
    
    
    private bool BacktrackingHelper(string s, string p, int si, int pi){
        //exit condition
        if(si > s.Length) return false;
        if(pi > p.Length) return false;
        if(si == s.Length && pi == p.Length) return true;
        
        if(pi == p.Length && si < s.Length) return false;
        
        if(p[pi] == '*'){
            if(BacktrackingHelper(s, p, si + 1, pi)) // match current and stay
                return true;
            if(BacktrackingHelper(s, p, si + 1, pi + 1)) //match current and move on, equals to ?
                return true;
            if(BacktrackingHelper(s, p, si, pi + 1)) // match empty and move on
                return true;
        }
        else if(p[pi] == '?'){
            if(BacktrackingHelper(s, p, si + 1, pi + 1))
                return true;
        }
        else{
            if(pi >= p.Length || si >= s.Length) return false;
            if(p[pi] != s[si]) return false;
            
            if(BacktrackingHelper(s, p, si + 1, pi + 1))
                return true;
        }
        return false;
    }
}