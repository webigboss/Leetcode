public class Solution {
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        //https://leetcode.com/problems/accounts-merge/discuss/109157/JavaC++-Union-Find/241144
        //Union find solution
        var uf = new UnionFind(accounts.Count);
        
        //1. collect email address to parent index map using union find class
        var accToParent = new Dictionary<string, int>();
        for(var i = 0; i < accounts.Count; ++i){
            for(var j = 1; j < accounts[i].Count; ++j){
                var email = accounts[i][j];
                if(accToParent.ContainsKey(email))
                    uf.Union(accToParent[email], i);
                else
                    accToParent[email] = i;
            }
        }
        
        //2. collect email addresses with same parent to list
        var parentToEmails = new Dictionary<int, HashSet<string>>();
        for(var i = 0; i < accounts.Count; ++i){
            var iParent = uf.Find(i);
            if(!parentToEmails.ContainsKey(iParent)){
                parentToEmails[iParent] = new HashSet<string>();
            }
            for(var j = 1; j < accounts[i].Count; ++j)
                parentToEmails[iParent].Add(accounts[i][j]);
        }
        
        //3. build the result by sorting the list in parentToEmails
        var ans = new List<IList<string>>();
        foreach(var kvp in parentToEmails){
            var list = new List<string>();
            list.Add(accounts[kvp.Key][0]);
            var emails = new List<string>();
            foreach(var e in kvp.Value)
                emails.Add(e);
            emails.Sort(StringComparer.Ordinal);
            list.AddRange(emails);
            ans.Add(list);
        }
        
        return ans;
    }
    
    public class UnionFind{
        private int[] parent;
        public UnionFind(int size){
            parent = new int[size];
            for(var i = 0; i < size; ++i)
                parent[i] = i;
        }
        
        //Path compression / collapse find
        public int Find(int a){
            if(parent[a] != a){
                parent[a] = Find(parent[a]);
            }
            return parent[a];
        }
        
        public void Union(int a, int b){
            var pa = Find(a);
            var pb = Find(b);
            if(pa == pb) return;
            parent[pb] = pa;
        }
    }
}