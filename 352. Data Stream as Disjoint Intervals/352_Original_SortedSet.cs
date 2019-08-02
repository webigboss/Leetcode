public class SummaryRanges {

    /** Initialize your data structure here. */
    
    private SortedSet<int> intervals; 
    
    public SummaryRanges() {
        intervals = new SortedSet<int>();
    }
    
    public void AddNum(int val) {
        if(intervals.Contains(val)) return;
        intervals.Add(val);
    }
    
    public int[][] GetIntervals() {
       var arrIntervals = new List<int[]>();
        int pre = -2;
        int start = -2;
        foreach(var num in intervals){
            if(start == -2){
                start = num;
            }
            else if(num > pre + 1){
                arrIntervals.Add(new []{start, pre});
                start = num;
            }
            pre = num;
        }
        arrIntervals.Add(new []{start, pre});

        return arrIntervals.ToArray();
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(val);
 * int[][] param_2 = obj.GetIntervals();
 */