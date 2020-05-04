import java.util.*;

class Solution {
    public int kthSmallest(int[][] mat, int k) {
        // BFS with priority queue, TC: O(r^2*k*log(k*r), SC: O(r^2*k)
        int r = mat.length;
        int c = mat[0].length;
        PriorityQueue<AbstractMap.SimpleEntry<Integer, int[]>> pq = new PriorityQueue<>((a,b) -> a.getKey() - b.getKey());
        HashSet<String> visited = new HashSet<>();
        int sum = 0;
        for(int i = 0; i < r; ++i)
            sum += mat[i][0];
        int[] item = new int[r];
        pq.offer(new AbstractMap.SimpleEntry<Integer, int[]>(sum, item));
        visited.add(join(item));
        int cnt = 1;
        while(pq.size() > 0 && cnt < k){
            var cur = pq.poll();
            var curarr = cur.getValue();
            //var strcurarr = join(curarr);
            //System.out.println(String.format("^polled: Key: %s, Value.join: %s, cnt: %s",cur.getKey(), strcurarr, cnt));
            
            for(int i = 0; i < r; ++i){
                int[] newitem = new int[r];
                for(int j = 0; j < r; ++j){
                    if(j == i){
                        newitem[j] = curarr[j] + 1;
                    }
                    else{
                        newitem[j] = curarr[j];
                    }
                }
                var strnewitem = join(newitem);
                if(curarr[i] + 1 == c || visited.contains(strnewitem)) continue;
                visited.add(strnewitem);
                var newEntry = new AbstractMap.SimpleEntry<Integer, int[]>(cur.getKey() - mat[i][curarr[i]] + mat[i][curarr[i]+1], newitem);
                //System.out.println(String.format("pushed: Key: %s, Value.join: %s",newEntry.getKey(), join(newEntry.getValue())));
                pq.offer(newEntry);
            }
            cnt++;
        }
        return pq.peek().getKey();
    }
    
    private String join(int[] nums){
        StringJoiner sj = new StringJoiner(",");
        IntStream.of(nums).forEach(x -> sj.add(String.valueOf(x)));
        return sj.toString();
    }
}