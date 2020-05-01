public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        //disjoint set implementation (rely on array)
        var dsu = new DSU(edges.Length);
        for(var i = 0; i < edges.Length; ++i){
            if(!dsu.Union(edges[i][0], edges[i][1]))
                return edges[i];
        }
        return null;
    }
    
    
    public class DSU{
        public int[] parent;
        public int[] rank;
        //public int[] size;
        
        public DSU(int size){
            parent = new int[size+1];
            rank = new int[size+1];
            for(var i = 0; i < parent.Length; ++i)
                parent[i] = i;
        }
        
        //Path compression (collapse find): starting from the sencond find for the same element, the time will be O(1)
        public int Find(int x){
            if(parent[x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }
        
        public bool Union(int x, int y){
            var px = Find(x);
            var py = Find(y);
            
            //same parent, means in the same set
            if(px == py) return false;
            
            if(rank[px] >= rank[py]){
                parent[py] = x;
                if(rank[px] == rank[py])
                    rank[px]++;
            }
            else{
                parent[px] = y;
            }
            return true;
        }
        
    }
}