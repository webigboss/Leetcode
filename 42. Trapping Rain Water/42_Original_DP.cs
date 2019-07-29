public class Solution {
    public int Trap(int[] height) {
        //DP solution optimized from brutal force
        var dpLeftMax = new int[height.Length];
        var dpRightMax = new int[height.Length];
        int result = 0;
        //right max
        int tempMax = 0;
        for(var i = height.Length - 1; i >= 0; i--){
            tempMax = Math.Max(tempMax, height[i]);
            dpRightMax[i] = tempMax;
        }
        
        tempMax = 0;
        //left max
        for(var i = 0; i < height.Length; i++){
            tempMax = Math.Max(tempMax, height[i]);
            dpLeftMax[i] = tempMax;
        }
        
        //calculate result
        for(var i = 0; i < height.Length; i++){
            result += Math.Min(dpLeftMax[i], dpRightMax[i]) - height[i];
        }
        return result;
    }
}