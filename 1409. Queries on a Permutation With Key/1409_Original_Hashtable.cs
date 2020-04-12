public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        var indexMap = new int[m + 1];
        for(var i = 1; i <= m; ++i)
            indexMap[i] = i - 1;
        var result = new List<int>();
        for(var i = 0; i < queries.Length; ++i){
            var curIndex = indexMap[queries[i]];
            result.Add(curIndex);
            for(var j = 1; j <= m; ++j){
                if(indexMap[j] <= curIndex){
                    indexMap[j] = (indexMap[j] + 1) % (curIndex + 1);
                }
            }
        }
        
        return result.ToArray();
    }
}