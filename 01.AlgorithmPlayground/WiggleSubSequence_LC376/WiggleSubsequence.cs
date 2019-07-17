using System;


namespace AlgorithmPlayground{
    
    public class WiggleSubsequenceClass {
        public WiggleSubsequenceClass(){
            var nums = new []{1,17,5,10,13,15,10,5,16,8};
            var result = WiggleMaxLength(nums);
        }
        public int WiggleMaxLength(int[] nums) {
            //DP solution
            if(nums.Length == 0) return 0;
            if(nums.Length == 1) return 1;
            //dp array, dp[i] means the maxLength of Wiggle sequence that ends with nums[i]
            var dp = new int[nums.Length];
            //int array to tell if current i element is duplicated to it's previous, and if so, the index of the starting point 
            var iDupStartPoint = new int[nums.Length + 1];
            //base case
            dp[0] = 1;
            iDupStartPoint[1] = 0;
            //dp[1] = nums[0] != nums[1] ? 2 : 1;
            
            for(var i = 1; i < nums.Length; i++){
                if(nums[i] == nums[i - 1]){
                    iDupStartPoint[i + 1] = iDupStartPoint[i] == 0 ? i : iDupStartPoint[i];
                    dp[i] = dp[i - 1];
                    continue;
                }
                var itemp = i - 1;
                if(iDupStartPoint[i] > 0){
                    if(iDupStartPoint[i] == 1){
                        dp[i] = dp[i - 1] + 1;
                        continue;
                    }
                    itemp = iDupStartPoint[i] - 1;
                }
                    
                if(itemp > 0 && (nums[i] - nums[itemp]) * (nums[itemp] - nums[itemp - 1]) >= 0)
                    dp[i] = dp[i - 1];
                else
                    dp[i] = dp[i - 1] + 1;
            }
            
            var result = 0;
            for(var i = 0; i < dp.Length; i++)
                result = Math.Max(result, dp[i]);
            return result;
        }
    }
}