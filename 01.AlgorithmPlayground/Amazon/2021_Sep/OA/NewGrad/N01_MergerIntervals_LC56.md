```
public int[][] Merge(int[][] intervals) {
    Array.Sort(intervals, (a, b)=>a[0]-b[0]);
    int l = intervals[0][0], r = intervals[0][1];
    var ans = new List<int[]>();
    for(var i = 0; i < intervals.Length; ++i){
        var cur = intervals[i];
        if(r < cur[0]) {
            ans.Add(new []{l, r});
            l = cur[0];
            r = cur[1];
        }
        r = Math.Max(r, cur[1]);
    }
    
    ans.Add(new []{l,r});
    
    
    return ans.ToArray();
}
```
