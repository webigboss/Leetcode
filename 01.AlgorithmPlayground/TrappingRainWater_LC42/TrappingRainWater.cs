using System;

namespace AlgorithmPlayground{
    public class TrappingRainWater {

        public TrappingRainWater(){
            var height = new []{0,1,0,2,1,0,1,3,2,1,2,1};
            var dpResult = TrapDP(height);
        }
        public int TrapDP(int[] height) {
            //DP solution optimized from brutal force
            var dpLeftMax = new int[height.Length];
            var dpRightMax = new int[height.Length];
            int result = 0;
            //right max
            int tempMax = 0;
            for(var i = height.Length - 1; i >= 0; i--)
                dpRightMax[i] = Math.Max(tempMax, height[i]);
            
            tempMax = 0;
            //left max
            for(var i = 0; i < height.Length; i++)
                dpLeftMax[i] = Math.Max(tempMax, height[i]);
            
            
            //calculate result
            for(var i = 0; i < height.Length; i++){
                result += Math.Min(dpLeftMax[i], dpRightMax[i]) - height[i];
            }
            return result;
        }

        public int TrapBrutalForce(int[] height) {
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
}