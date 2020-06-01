public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        int mod = (int)1e9+7;
        long hmax = 0, vmax = 0;
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        for(var i = 0; i <= horizontalCuts.Length; ++i){
            if(i == 0) hmax = horizontalCuts[i];
            else if(i == horizontalCuts.Length) hmax = Math.Max(hmax, h-horizontalCuts[i-1]);
            else hmax = Math.Max(hmax, horizontalCuts[i]-horizontalCuts[i-1]);
        }
        
        for(var i = 0; i <= verticalCuts.Length; ++i){
            if(i == 0) vmax = verticalCuts[i];
            else if(i == verticalCuts.Length) vmax = Math.Max(vmax, w-verticalCuts[i-1]);
            else vmax = Math.Max(vmax, verticalCuts[i]-verticalCuts[i-1]);
        }
        //Console.WriteLine($"{hmax}, {vmax}");
        return (int)(hmax * vmax % mod);
    }
}