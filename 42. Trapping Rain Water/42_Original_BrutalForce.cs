public class Solution {
    public int Trap(int[] height) {
        //brutal force approach
        int leftMax, rightMax;
        int result = 0;
        for(var i = 0; i < height.Length; i++){
            //leftMax
            leftMax = height[i];
            for(var j = i - 1; j >= 0; j--)
                leftMax = Math.Max(leftMax, height[j]);
            //rightMax
            rightMax = height[i];
            for(var j = i + 1; j < height.Length; j++)
                rightMax = Math.Max(rightMax, height[j]);
            
            result += Math.Min(leftMax, rightMax) - height[i];
        }
        return result;
    }
}