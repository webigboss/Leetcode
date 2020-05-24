public class Solution {
    public IList<IList<int>> LargeGroupPositions(string S) {
        //two pointers
        int s = 0;
        var ans = new List<IList<int>>();
        for(var e = 0; e < S.Length; ++e){
            if(e == S.Length - 1 || S[e] != S[e+1]){
                if(e-s > 1)
                    ans.Add(new List<int>(){s, e});
                s = e+1;
            }
        }
        return ans;
    }
}