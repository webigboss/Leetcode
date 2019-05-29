public class Solution {
    public int NumSquares(int n) {
        var sqrList = new List<int>();
        var s = 1;
        //1. get all possible square numbers
        while(Math.Pow(s, 2) <= n){
            if((int)Math.Pow(s, 2) == n)
                return 1;
            sqrList.Add((int)Math.Pow(s, 2));
            s++;
        }
        
        //2. BFS
        // queue stores cumulative sum and length
        var q = new Queue<int[]>();
        var minCount = 0;
        foreach(var sqr in sqrList){
            q.Enqueue(new int[]{sqr , 1});
        }
        
        
        while(q.Count > 0){
            var pair = q.Dequeue();
            foreach(var sqr in sqrList){
                if(pair[0] + sqr == n){
                    return pair[1] + 1;
                }
                if(pair[0] + sqr < n){
                    q.Enqueue(new int[]{pair[0] + sqr, pair[1] + 1});
                }
            }
        }
        
        return n;
    }
}