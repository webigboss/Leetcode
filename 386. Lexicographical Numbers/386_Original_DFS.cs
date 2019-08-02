public class Solution {
    public IList<int> LexicalOrder(int n) {
        //DFS solution
        var result = new List<int>();
        for(var i = 1; i <= 9; i++){
            DfsHelper(i, n, result);
        }
        return result;
    }
    
    private void DfsHelper(int cur, int n, IList<int> result){
        if(cur > n)
            return;
        result.Add(cur);
        for(var i = 0; i <= 9; i++)
            DfsHelper(cur * 10 + i, n, result);
    }
}