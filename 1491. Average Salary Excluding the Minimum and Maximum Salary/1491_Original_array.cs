public class Solution {
    public double Average(int[] salary) {
        double min = 10e6, max = 0, ans = 0;
        int maxcnt = 0, mincnt = 0;
        foreach(var s in salary){
            if(s < min){
                mincnt = 1;
                min = s;
            }
            else if(s == min) 
                mincnt++;
            
            if(s > max){
                maxcnt = 1;
                max = s;
            }
            else if(s == max)
                maxcnt++;
            ans += s;
        }
        //Console.WriteLine($"{max}, {maxcnt}, {min}, {mincnt}, {ans}");
        return (ans - max*maxcnt - min*mincnt)/(salary.Length-maxcnt-mincnt);
    }
}