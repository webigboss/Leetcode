public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var j = new bool[100];
        foreach(var c in J){
            j[c-'A'] = true;
        }
        
        var ans = 0;
        foreach(var c in S){
            if(j[c-'A'])
                ans++;
        }
        return ans;
    }
}