public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        //BFS with queue
        var n = rooms.Count;
        var visited = new bool[n];
        var cnt = 1;
        visited[0] = true;
        var q = new Queue<int>();
        foreach(var k in rooms[0])
            q.Enqueue(k);
        
        while(q.Count > 0){
            var k = q.Dequeue();
            if(visited[k]) continue;
            visited[k] = true;
            cnt++;
            foreach(var nk in rooms[k])
                q.Enqueue(nk);
        }
        return cnt == n;
    }
}