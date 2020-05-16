class Solution {
    public int findCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        //BFS with priority queue 
        var q = new PriorityQueue<int[]>((a,b)->a[1]-b[1]);
        var map = new HashMap<Integer, List<int[]>>();
        for(var f : flights){
            if(!map.containsKey(f[0]))
                map.put(f[0], new ArrayList<int[]>());
            map.get(f[0]).add(new int[]{f[1], f[2]});
        }
        
        q.offer(new int[]{src, 0, -1});
        // var ans = Integer.Max_Value;
        while(q.size() > 0){
            var cur = q.poll();
            //System.out.println(String.format("cur: [%s, %s, %s]", cur[0], cur[1], cur[2]));
            if(cur[2] > K) continue;
            if(cur[0] == dst)
                return cur[1];
            if(!map.containsKey(cur[0])) continue;
            for(var d : map.get(cur[0])){
                q.offer(new int[]{d[0], cur[1]+d[1], cur[2]+1});
            }
        }
        return -1;
    }
}