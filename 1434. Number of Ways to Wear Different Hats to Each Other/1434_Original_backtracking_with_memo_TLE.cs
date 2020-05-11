public class Solution {
    private int ans;
    private int mod = (int)(1e9+7);
    public int NumberWays(IList<IList<int>> hats) {
        //backtraking
        //sort the hats
        
        ((List<IList<int>>)hats).Sort((a,b)=>a.Count - b.Count);
        
        for(var i = 0; i < hats.Count; ++i){
            ((List<int>)hats[i]).Sort();
            //Array.Sort(hats[i]);
        }
        
        ans = 0;
        var hatUsed = new bool[40];
        var peopleWeared = new int[hats.Count];
        Helper(hats, hatUsed, peopleWeared, hats.Count, 0, new HashSet<string>());
        return ans;
    }
    
    private bool Helper(IList<IList<int>> hats, bool[] hatUsed, int[] peopleWeared, int peopleCnt, int pplindex,
                       HashSet<string> failedMemo){
        var key = String.Join(',', peopleWeared);
        if(failedMemo.Contains(key))
            return false;
        if(peopleCnt == 0){
            ans = (ans + 1) % mod;
            return true;
        }
        var result = false;
        for(var i = pplindex; i < hats.Count; ++i){
            if(peopleWeared[i] > 0) continue;
            for(var j = 0; j < hats[i].Count; ++j){
                if(hatUsed[hats[i][j]]) continue;
                hatUsed[hats[i][j]] = true;
                peopleWeared[i] = hats[i][j];
                if(Helper(hats, hatUsed, peopleWeared, peopleCnt - 1, i, failedMemo))
                    result = true;
                hatUsed[hats[i][j]] = false;
                peopleWeared[i] = 0;
            }
        }
        if(!result){
            failedMemo.Add(key);
        }
        return result;
    }
}
