public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        //two pointers
        var n = difficulty.Length;
        var arr = new int[n][];
        for(var i = 0; i < n; ++i){
            arr[i] = new []{difficulty[i], profit[i]};
        }
        Array.Sort(arr, (a, b)=>a[0]-b[0]);
        
        for(var i = 0; i < n; ++i){
            if(i > 0) {
                arr[i][1] = Math.Max(arr[i-1][1], arr[i][1]);
            }
        }
        Array.Sort(worker);

        int ans = 0, j = 0;
        for(var i = 0; i < worker.Length; ++i){
            
            while(j < arr.Length-1 && arr[j+1][0] <= worker[i])
                j++;
            if(arr[j][0] > worker[i]) continue;
            ans += arr[j][1];
        }
        
        return ans;
    }
}