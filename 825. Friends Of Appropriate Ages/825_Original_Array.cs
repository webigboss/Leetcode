public class Solution {
    public int NumFriendRequests(int[] ages) {
        Console.WriteLine(ages.Length);
        var ans = 0;
        var cnts = new int[121];
        foreach(var a in ages)
            cnts[a]++;
        
        
        for(var i = 1; i < cnts.Length; ++i){
            for(var j = 1; j < cnts.Length; ++j){
                if(CanFR(i, j))
                    ans += i == j ?cnts[i]*(cnts[i]-1) : cnts[i]*cnts[j];
            }
        }
        return ans;
    }
    
    bool CanFR(int a, int b){
        if(b <= 0.5*a+7 || b > a || b > 100 && a < 100) return false;
        return true;
    }
}