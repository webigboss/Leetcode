public class Solution {
    public IList<int> PartitionLabels(string S) {
        var l = S.Length;
        var ranges = new Dictionary<char, int[]>();
        
        for(var i = 0; i < l; ++i){
            if(!ranges.ContainsKey(S[i]))
                ranges[S[i]] = new []{i,i};
            if(ranges[S[i]][1] < i)
                ranges[S[i]][1] = i;
        }
        
        int lo, hi, istart;
        lo = istart = hi = 0;
        var ans = new List<int>();

        while(lo < l){
            hi = ranges[S[lo]][1];
            while(lo < hi){
                hi = Math.Max(hi, ranges[S[lo]][1]);
                lo++;
            }
            ans.Add(hi - istart + 1);
            Console.WriteLine($"ans.Add->{hi - istart + 1}");
            lo++;
            istart = lo;
        }
        return ans;
    }
}