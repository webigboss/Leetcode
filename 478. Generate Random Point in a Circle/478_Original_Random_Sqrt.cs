public class Solution {

    private double r;
    private double xc;
    private double yc;
    private Random rdn;
    public Solution(double radius, double x_center, double y_center) {
        r = radius;
        xc = x_center;
        yc = y_center;
        rdn = new Random();
    }
    
    public double[] RandPoint() {
        var rNew = Math.Sqrt(rdn.NextDouble()) * r;
        var rAngle = rdn.NextDouble() * 2 * Math.PI;
        var y = yc + rNew * Math.Sin(rAngle);
        var x = xc + rNew * Math.Cos(rAngle);
        return new []{x, y};
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(radius, x_center, y_center);
 * double[] param_1 = obj.RandPoint();
 */