public class Solution {
    public int Candy(int[] ratings) {
        if(ratings.Length == 0) return 0;
        //2 arrays solution
        var left2Right = new int[ratings.Length];
        var right2Left = new int[ratings.Length];
        
        //1. populate left2Right
        left2Right[0] = 1;
        for(var i = 1; i < ratings.Length; i++){
            if(ratings[i] > ratings[i - 1])
                left2Right[i] = left2Right[i - 1] + 1;
            else
                left2Right[i] = 1;
        }
        
        //2. populate right2Left
        right2Left[ratings.Length - 1] = 1;
        for(var i = ratings.Length - 2; i >= 0; i--){
            if(ratings[i] > ratings[i + 1])
                right2Left[i] = right2Left[i + 1] + 1;
            else
                right2Left[i] = 1;
        }
        
        var minCandy = 0;
        //3. sum the result from Math(right2Left[i], left2Right[i])
        for(var i = 0; i < left2Right.Length; i++){
            minCandy += Math.Max(left2Right[i], right2Left[i]);
        }
        return minCandy;
    }
}