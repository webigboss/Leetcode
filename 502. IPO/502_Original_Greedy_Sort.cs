public class Solution {
    public int FindMaximizedCapital(int k, int W, int[] Profits, int[] Capital) {
        var list = new List<int[]>();
        var l = Profits.Length;
        for(var i = 0; i < l; ++i){
            list.Add(new []{Profits[i], Capital[i]});
        }
        //sort by profits descendingly, if tie, sort capital ascendingly
        list.Sort((a, b) => {
            if(a[0] == b[0])
                return a[1] - b[1];
            return b[0] - a[0]; 
        });
        
        var used = new bool[l];
        
        while(k > 0){
            for(var i = 0; i < l; ++i){
                if(used[i] || list[i][1] > W) continue;
                W += list[i][0];
                used[i] = true;
                break;
            }
            k--;
        }
        return W;
    }
}