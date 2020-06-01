public class ExamRoom {

    List<int> occupied;
    int n;
    public ExamRoom(int N) {
        occupied = new List<int>();
        n = N;
    }
    
    public int Seat() {
        if(occupied.Count == 0){
            occupied.Add(0);
            return 0;
        }
        int maxLength = 0, ans = 0;
        for(var i = 0; i < occupied.Count; ++i){
            if(i == 0 && maxLength < occupied[i]){
                maxLength = occupied[i];
                ans = 0;
            }
            else if(i > 0 && maxLength < (occupied[i]-occupied[i-1])/2){
                maxLength = (occupied[i]-occupied[i-1])/2;
                ans = (occupied[i]+occupied[i-1])/2;
            }
            if(i == occupied.Count-1 && maxLength < n-1-occupied[i]){
                ans = n - 1;
            }
        }
        occupied.Add(ans);
        occupied.Sort();
        //Console.WriteLine($"Seat()->{ans}; occupied:[{string.Join(',',occupied)}]");
        return ans;
    }
    
    public void Leave(int p) {
        occupied.Remove(p);
    }
}

/**
 * Your ExamRoom object will be instantiated and called as such:
 * ExamRoom obj = new ExamRoom(N);
 * int param_1 = obj.Seat();
 * obj.Leave(p);
 */