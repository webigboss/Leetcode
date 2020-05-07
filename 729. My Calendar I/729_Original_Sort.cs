public class MyCalendar {

    private List<int[]> calendar;
    public MyCalendar() {
        calendar = new List<int[]>();
    }
    
    public bool Book(int start, int end) {
        calendar.Sort((a,b) => a[1]-b[1]);
        for(var i = 0; i < calendar.Count; ++i){
            var c = calendar[i];
            if(c[1] <= start)
                continue;
            else{
                if(c[0] < end) 
                    return false;
            }
        }
        calendar.Add(new []{start, end});
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */