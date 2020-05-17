public class Solution {
    public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies) {
        foreach(var c in favoriteCompanies){
            ((List<string>)c).Sort();
        }
        
        var ans = new List<int>();
        var l = favoriteCompanies.Count;
        for(var i = 0; i < l; ++i){
            var flag = true;
            for(var j = 0; j < l && flag; ++j){
                if(j == i) continue;
                int curi = 0, li = favoriteCompanies[i].Count;
                for(var k = 0; k < favoriteCompanies[j].Count && curi < li; ++k){
                    if(favoriteCompanies[i][curi] == favoriteCompanies[j][k]) curi++;
                }
                if(curi >= li) flag = false;
            }
            if(flag) // is subset of one of other list
                ans.Add(i);
        }
        return ans;
    }
}