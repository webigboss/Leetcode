
namespace AlgorithmPlayground
{
    public class DisjointSet
    {
        private int[] parent;
        private int[] rank;
        private int[] size;
        public DisjointSet(int length)
        {
            parent = new int[length + 1];
            rank = new int[length + 1];
            size = new int[length + 1];
            for (var i = 0; i <= parent.Length; ++i)
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

            if(px == py) return false;
            
            //Union by Rank
            if(rank[px] > rank[py])
                parent[py] = px;
            else if(rank[px] < rank[py])
                parent[px] = py;
            else{
                parent[py] = px;
                rank[px]++;
            }

            return true;
        }
    }

}