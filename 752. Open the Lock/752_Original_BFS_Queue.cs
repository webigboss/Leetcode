public class Solution {
    public int OpenLock(string[] deadends, string target) {
        //BFS with queue
        var visited = new HashSet<string>();
        var q = new Queue<string>();
        foreach(var d in deadends)
            visited.Add(d);
        
        q.Enqueue("0000");
        var cnt = q.Count;
        var turns = 0;
        while(q.Count > 0){

            for(var i=0; i<cnt; ++i){
                var cur = q.Dequeue();
                if(cur == target)
                    return turns;
                if(visited.Contains(cur)) continue;
                visited.Add(cur);

                for(var j=0; j < 4; ++j){
                    var sPos = cur.ToCharArray();
                    var sNeg = cur.ToCharArray();
                    if(cur[j] == '0'){
                        sPos[j]++;
                        sNeg[j]='9';
                    }
                    else if(cur[j] == '9'){
                        sPos[j] = '0';
                        sNeg[j]--;
                    }
                    else{
                        sPos[j]++;
                        sNeg[j]--;
                    }
                    q.Enqueue(new string(sPos));
                    q.Enqueue(new string(sNeg));
                }
            }
            cnt = q.Count;
            turns++;
        }
        return -1;
    }
}