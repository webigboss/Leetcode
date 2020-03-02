public class Solution {

    private Random _rnd;
    private int[][] _rects; 
    private int _sum;
    private int[] _points;
    public Solution(int[][] rects) {
        _rnd = new Random();
        _rects = rects;
        _points = new int[rects.Length];
        for(var i = 0; i < rects.Length; i++){
            _points[i] = (rects[i][2] - rects[i][0] + 1) * (rects[i][3] - rects[i][1] + 1);
            _sum += _points[i];
        }
    }
    
    public int[] Pick() {
        var i = WeightedRandom();
        var x1 = _rects[i][0];
        var y1 = _rects[i][1];
        var x2 = _rects[i][2];
        var y2 = _rects[i][3];
        
        //another inspiration is, for 2D random pick, apply random on both dimension is equal to apply the sqrt to radius for uniformily picking from a circle (LC478), because pi get's squared when getting the area of a circle, if applying a random directly on radius, will make the random factor of the area be the square of random factor of the radius, make it not uniformily random on the 2D plain. 
        return new []{x1 + _rnd.Next(x2 - x1 + 1), y1 + _rnd.Next(y2 - y1 + 1)};
    }
    
    private int WeightedRandom(){
        var r = _rnd.Next(_sum) + 1;
        for(var i = 0; i < _points.Length; i++){
            //cannot swap the order of below 2 line, because the other way round, the first element will never be picked, make it not a uniformily random pick
            r -= _points[i];
            if(r < 0) return i;
        }
        return 0;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */