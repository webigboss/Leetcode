public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var vertices = new Dictionary<string, Dictionary<string, double>>();
        var result = new double[queries.Count];
        var visited = new HashSet<string>();
        Array.Fill(result, -1);
        for(var i = 0; i < equations.Count; i++){
            var from = equations[i][0];
            var to = equations[i][1];
            AddVertices(vertices, from, to, values[i]);
        }
        
        for(var i = 0; i < queries.Count; i++){
            visited.Add(queries[i][0]);
            FindAnswer(queries[i][0], queries[i][1], 1, vertices, i, result, visited);
            visited.Remove(queries[i][0]);
        }
        return result;
    }
    
    
    private void AddVertices(Dictionary<string, Dictionary<string, double>> vertices, string from, string to, double value){
        if(!vertices.ContainsKey(from))
            vertices[from] = new Dictionary<string, double>();
        vertices[from][to] = value;
        
        if(!vertices.ContainsKey(to))
            vertices[to] = new Dictionary<string, double>();
        vertices[to][from] = 1 / value;
    }
    
    
    private bool FindAnswer(string from, string to, double value, Dictionary<string, Dictionary<string, double>> vertices, int queryIndex, double[] result, HashSet<string> visited){
        if(!vertices.ContainsKey(from) || !vertices.ContainsKey(to)) return false;
        if(from == to){
            result[queryIndex] = 1;
            return true;
        }
        if(vertices[from].ContainsKey(to)){
            result[queryIndex] = vertices[from][to] * value;
            return true;
        }
        foreach(var kvp in vertices[from]){
            if(visited.Contains(kvp.Key)) continue;
            visited.Add(kvp.Key);
            if(FindAnswer(kvp.Key, to, value * kvp.Value, vertices, queryIndex, result, visited)){
                visited.Remove(kvp.Key);
                return true;
            }
            visited.Remove(kvp.Key);
        }
        return false;
    }
}