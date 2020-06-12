public class Solution {
    public int[][] SpiralMatrixIII(int R, int C, int r0, int c0) {
        int curd = 0, cnt = R*C - 1;
        var cur = new [] {r0, c0};
        var bound = new []{c0, r0, c0, r0};
        var ans = new List<int[]>{new []{r0, c0}};
        
        while(cnt > 0){
            if(curd == 0){
                bound[0]++;
                for(var i = cur[1]+1; i <= bound[0]; ++i){
                    if(IsInGrid(cur[0], i, R, C)) {
                        ans.Add(new []{cur[0], i});
                        cnt--;
                        // Console.WriteLine($"curd={curd}, Add({cur[0]}, {i}), cnt:{cnt}");
                    }
                }
                cur[1] = bound[0];
                // Console.WriteLine($"curd:{curd}, cur:({cur[0]}, {cur[1]})");
                curd = (curd+1) % 4;
            }
            else if(curd == 1){
                bound[1]++;
                for(var i = cur[0]+1; i <= bound[1]; ++i){
                    if(IsInGrid(i, cur[1], R, C)) {
                        ans.Add(new []{i, cur[1]});
                        cnt--;
                        // Console.WriteLine($"curd={curd}, Add({i}, {cur[1]}), cnt:{cnt}");
                    }
                }
                cur[0] = bound[1];
                // Console.WriteLine($"curd:{curd}, cur:({cur[0]}, {cur[1]})");
                curd = (curd+1) % 4;
            }
            else if(curd == 2){
                bound[2]--;
                for(var i = cur[1]-1; i >= bound[2]; --i){
                    if(IsInGrid(cur[0], i, R, C)) {
                        ans.Add(new []{cur[0], i});
                        cnt--;
                        // Console.WriteLine($"curd={curd}, Add({cur[0]}, {i}), cnt:{cnt}");
                    }
                }
                cur[1] = bound[2];
                // Console.WriteLine($"curd:{curd}, cur:({cur[0]}, {cur[1]})");
                curd = (curd+1) % 4;
            }
            else if(curd == 3){
                bound[3]--;
                for(var i = cur[0]-1; i >= bound[3]; --i){
                    if(IsInGrid(i, cur[1], R, C)) {
                        ans.Add(new []{i, cur[1]});
                        cnt--;
                        // Console.WriteLine($"curd={curd}, Add({i}, {cur[1]}), cnt:{cnt}");
                    }
                }
                cur[0] = bound[3];
                // Console.WriteLine($"curd:{curd}, cur:({cur[0]}, {cur[1]})");
                curd = (curd+1) % 4;
            }
        }
        return ans.ToArray();
    }
    
    
    bool IsInGrid(int curR, int curC, int R, int C){
        if(curR < R && curR >= 0 && curC < C && curC >= 0)
            return true;
        return false;
    }
}