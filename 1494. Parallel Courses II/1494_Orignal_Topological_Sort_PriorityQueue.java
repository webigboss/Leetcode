class Solution {
    public int minNumberOfSemesters(int n, int[][] dependencies, int k) {
        int[] indegree = new int[n], outdegree = new int[n];
        int ans = 0;
        List<Integer>[] edges = new ArrayList[n];
        
        for(var d : dependencies){
            indegree[d[1]-1]++;
            outdegree[d[0]-1]++;
            if(edges[d[0]-1] == null)
                edges[d[0]-1] = new ArrayList<Integer>();
            edges[d[0]-1].add(d[1]-1);
        }
        //sort by outdegree desendingly
        var q = new PriorityQueue<Integer>((a, b) -> outdegree[b]-outdegree[a]);
        for(var i = 1; i <= n; ++i){
            if(indegree[i-1] == 0)
                q.offer(i-1);
        }
        
        while(q.size() > 0) {
            var temp = new LinkedList<Integer>();
            var cnt = q.size() > k ? k : q.size();
            //System.out.println("q.size() = " + q.size() + " cnt:" + cnt);
            ans++;
            for(var i = 0; i < cnt; ++i) {
                temp.offer(q.poll());
            }
            
            while(temp.size() > 0){
                var cur = temp.poll();
                // System.out.println("temp.size() = " + temp.size() + " cur:" + cur);
                if(edges[cur] == null) continue;
                for(var next : edges[cur]){
                    indegree[next]--;
                    if(indegree[next] == 0)
                        q.offer(next);
                }
            }
        }
        
        return ans;
    }
}