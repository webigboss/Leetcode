public class Solution {
    public bool PossibleBipartition(int N, int[][] dislikes) {
        //BFS with queue
        var colors = new int[N]; //1 for red, -1 for blue;
        var q = new Queue<int>();
        var dict = new Dictionary<int, List<int>>();
        for(var i = 0; i < dislikes.Length; ++i){
            if(!dict.ContainsKey(dislikes[i][0]))
                dict[dislikes[i][0]] = new List<int>();
            dict[dislikes[i][0]].Add(dislikes[i][1]);
            if(!dict.ContainsKey(dislikes[i][1]))
                dict[dislikes[i][1]] = new List<int>();
            dict[dislikes[i][1]].Add(dislikes[i][0]);
        }
        
        var arr = dict.Keys.ToArray();
        int cnt = 0, curColor = 0;
        for(var i = 0; i < arr.Length; ++i){
            if(colors[arr[i]-1] != 0) continue;
            curColor = 1;
            q.Enqueue(arr[i]);
            cnt = q.Count;
            while(q.Count > 0){
                for(var j = 0; j < cnt; ++j){
                    var cur = q.Dequeue();
                    if(colors[cur-1] == -1*curColor) return false;
                    if(colors[cur-1] == 0){
                        colors[cur-1] = curColor;
                        if(!dict.ContainsKey(cur)) continue;
                        foreach(var n in dict[cur]){
                            q.Enqueue(n);
                        }
                    }
                }
                curColor *= -1;
                cnt = q.Count;
            }
            
        }
        return true;
    }
}