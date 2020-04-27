class Solution {
    public int constrainedSubsetSum(int[] nums, int k) {
        //dp with priority queue optimization, TC improved from O(n^2) to O(nlogn)
        var dp = new int[nums.length];
        //base case
        dp[0] = nums[0];
        
        var ans = dp[0];
        var q = new PriorityQueue<int[]>((a, b) -> b[0] - a[0]);
        q.add(new int[]{dp[0], 0});
        for(int i = 1; i < nums.length; ++i){
            dp[i] = nums[i];
            while(q.size() > 0 && q.peek()[1] < i-k)
                q.poll();
            
            if(q.size() > 0)
                dp[i] = Math.max(dp[i], q.peek()[0] + nums[i]);
            var item = new int[2];
            item[0] = dp[i];
            item[1] = i;
            q.offer(item);
            ans = Math.max(ans, dp[i]);
        }
        return ans;
    }
}