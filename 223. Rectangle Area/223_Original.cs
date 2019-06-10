public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        // calculate the overlapping area
        // length of overllaping aread on X-Axis
        var x = Math.Min(C, G) > Math.Max(A, E) ? Math.Min(C, G) - Math.Max(A, E) : 0;
        // length of overllaping aread on Y-Axis
        var y = Math.Min(D, H) > Math.Max(B, F) ? Math.Min(D, H) - Math.Max(B, F) : 0;
        
        return (C - A) * (D - B) + (G - E) * (H - F) - x * y;
    }
}