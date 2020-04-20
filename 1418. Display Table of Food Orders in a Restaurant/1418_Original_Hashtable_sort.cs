public class Solution {
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders) {
        var dict = new Dictionary<string, Dictionary<string, int>>();
        var foods = new HashSet<string>();
        
        for(var i = 0; i < orders.Count; ++i){
            var t = orders[i][1];
            var f = orders[i][2];
            if(!foods.Contains(f))
                foods.Add(f);
            if(!dict.ContainsKey(t)){
                dict[t] = new Dictionary<string, int>();
            }
            if(!dict[t].ContainsKey(f)){
                dict[t][f] = 1;
            }
            else
                dict[t][f]++;
        }
        var flist = foods.ToList();
        flist.Sort(StringComparer.Ordinal);
        var result = new List<IList<string>>();
        var firstRow = new List<string>{"Table"};
        firstRow.AddRange(flist);
        //result.Add(firstRow);
        
        foreach(var kvp in dict){
            var row = new List<string>();
            row.Add(kvp.Key);
            var v = kvp.Value;
            foreach(var f in flist){
                if(v.ContainsKey(f))
                    row.Add(v[f].ToString());
                else
                    row.Add("0");
            }
            result.Add(row);
        }
        result.Sort((a, b) => int.Parse(a[0]) - int.Parse(b[0]));
        result.Insert(0, firstRow);
        return result;
    }
}