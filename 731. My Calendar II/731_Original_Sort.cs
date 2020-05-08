public class MyCalendarTwo {

    private List<int[]> sb; // single booked intervals
    private List<int[]> db; // dobule booked interbals
    public MyCalendarTwo() {
        sb = new List<int[]>();
        db = new List<int[]>();
    }
    
    public bool Book(int start, int end) {
        for(var i = 0; i < db.Count; ++i){
            var d = db[i];
            if(start < d[1] && end > d[0]){
                return false;
            }
        }
        
        var temp = new List<int[]>();
        var isOverlap = false;
        for(var i = 0; i < sb.Count; ++i){
            var s = sb[i];
            if(start < s[1] && end > s[0]){
                isOverlap = true;
                var dfrom = Math.Max(start, s[0]);
                var dto = Math.Min(end, s[1]);
                var ifrom = Math.Min(start, s[0]);
                var ito = Math.Max(end, s[1]);
                Console.WriteLine($"db.Add: [{dfrom},{dto}]");
                db.Add(new []{dfrom, dto});
                if(ifrom != dfrom)
                    temp.Add(new []{ifrom, dfrom});
                if(ito != dto){
                    temp.Add(new []{dto, ito});
                }
            }
            else
                temp.Add(s);
        }
        if(isOverlap)
            sb = temp;
        else
            sb.Add(new []{start, end});
        sb.Sort((a, b) => a[1] - b[1]);
        db.Sort((a, b) => a[1] - b[1]);
        return true;
    }
}

/**
 * Your MyCalendarTwo object will be instantiated and called as such:
 * MyCalendarTwo obj = new MyCalendarTwo();
 * bool param_1 = obj.Book(start,end);
 */