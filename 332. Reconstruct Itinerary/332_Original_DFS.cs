public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        //DFS recursive solution
        var results = new List<IList<string>>();
        var dict = new Dictionary<string, SortedSet<string>>();
        var visited = new Dictionary<string, int>();
        for(var i = 0; i < tickets.Count; i++){
            var visitedKey = tickets[i][0] + tickets[i][1];
            if(!visited.ContainsKey(visitedKey))
                visited[visitedKey] = 1;
            else
                visited[visitedKey]++;
            
            if(!dict.ContainsKey(tickets[i][0]))
                dict[tickets[i][0]] = new SortedSet<string>{ tickets[i][1] };
            else{
                if(!dict[tickets[i][0]].Contains(tickets[i][1]))
                    dict[tickets[i][0]].Add(tickets[i][1]);
            }
        }
        
        DfsHelper(new List<string>(){"JFK"}, tickets.Count + 1, "JFK", results, dict, visited);

        return results[0];
    }
    
    private bool DfsHelper(IList<string> list, int targetCount, string curAirPort, IList<IList<string>> results, Dictionary<string, SortedSet<string>> dict, Dictionary<string, int> visited){
        if(list.Count == targetCount){
            results.Add(new List<string>(list));
            return true;
        }
        
        if(!dict.ContainsKey(curAirPort)) return false;
        foreach(var destAirPort in dict[curAirPort]){
            var visitedKey = curAirPort + destAirPort;
            if(visited[visitedKey] == 0) continue;
            visited[visitedKey]--;
            list.Add(destAirPort);
            if(DfsHelper(list, targetCount, destAirPort, results, dict, visited))
                return true;
            list.RemoveAt(list.Count - 1);
            visited[visitedKey]++;
        }
        return false;
    }
}