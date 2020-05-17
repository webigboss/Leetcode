public class Solution {
    public int NumPoints(int[][] points, int r) {
        var ans = 1;
        for(var i = 0; i < points.Length; ++i){
            for(var j = 0; j < points.Length; ++j){
                int a = points[i][0], b = points[i][1], c = points[j][0], d = points[j][1];
                if(a==c && b==d) continue;
                if(Math.Pow((a-c), 2) + Math.Pow((b-d), 2) > Math.Pow(2*r, 2)) continue;
                double up = Math.Sqrt(4*Math.Pow(r,2)-Math.Pow(a-c,2)-Math.Pow(b-d,2));
                double down = 2*Math.Sqrt(Math.Pow(a-c,2)+Math.Pow(b-d,2));
                double same = up/down;
                double c1x = 1.0*(a+c)/2+(b-d)*same;
                double c1y = 1.0*(b+d)/2+(-a+c)*same;
                ans = Math.Max(ans, Solve(c1x, c1y, points, r));
                
                double c2x = 1.0*(a+c)/2+(-b+d)*same;
                double c2y = 1.0*(b+d)/2+(a-c)*same;
                ans = Math.Max(ans, Solve(c2x, c2y, points, r));
            }
        }
        return ans;
    }
    
    private int Solve(double cx, double cy, int[][] points, int r){
        var ans = 0;
        for(var i = 0; i < points.Length; ++i){
            if(Math.Pow(points[i][0]-cx, 2) + Math.Pow(points[i][1]-cy, 2) <= Math.Pow(r,2)) ans++;
        }
        return ans;
    }
}