class Solution {
    public int networkDelayTime(int[][] times, int N, int K) {
        //priority queue approach
        var q = new PriorityQueue<int[]>((a,b) -> a[1]-b[1]);
        var visited = new boolean[N];
        var edges = new HashMap<Integer, List<int[]>>();
        
        for(var i = 0; i < times.length; ++i){
            var e = times[i];
            if(!edges.containsKey(e[0]))
                edges.put(e[0], new ArrayList<int[]>());
            var list = edges.get(e[0]);
            list.add(new int[] {e[1], e[2]});
        }
        
        var listk = edges.getOrDefault(K, new ArrayList<int[]>());
        visited[K-1] = true;
        for(var t: listk){
            //System.out.println(String.format("t[0]->%s; t[1]->%s", t[0], t[1]));
            q.offer(t);  
        }
        
        var ans = 0;
        while(q.size() > 0){
            var item = q.poll();
            var target = item[0];
            var time = item[1];
            if(visited[target-1])
                continue;
            visited[target-1] = true;
            ans = Math.max(ans, time);
            var targets = edges.getOrDefault(target, new ArrayList<int[]>());
            for(var t : targets){
                q.offer(new int[]{t[0], time+t[1]});
            }
        }
        
        for(var v : visited){
            if(!v) return -1;
        }
        return ans;
    }
}