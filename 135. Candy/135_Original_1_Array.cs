public class Solution {
    public int Candy(int[] ratings) {
        //1 array approach, optimized from 2 arrays approach
        if(ratings.Length == 0) return 0;
        var candies = new int[ratings.Length];
        var minCandy = 0;
        //1. left to right pass
        candies[0] = 1;
        for(var i = 1; i < ratings.Length; i++){
            if(ratings[i] > ratings[i - 1])
                candies[i] = candies[i - 1] + 1;
            else
                candies[i] = 1;
        }
        minCandy = candies[ratings.Length - 1];
        //2. right to left pass on the same array
        for(var i = ratings.Length - 2; i >= 0; i--){
            if(ratings[i] > ratings[i + 1])
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            minCandy += candies[i];
        }
        
        return minCandy;
    }
}