public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        // Boyer-Moore Majority Vote Algorithm
        // https://leetcode.com/problems/majority-element-ii/discuss/63520/Boyer-Moore-Majority-Vote-algorithm-and-my-elaboration
        var counter1 = 0;
        var counter2 = 0;
        var num1 = 0;
        var num2 = 0;
        
        //1. Pass 1, get the 2 potential majority element
        for(var i = 0; i < nums.Length; i++) {
            if(num1 == nums[i])
                counter1++;
            else if(num2 == nums[i])
                counter2++;
            else if(counter1 == 0){
                num1 = nums[i];
                counter1 = 1;
            }
            else if(counter2 == 0){
                num2 = nums[i];
                counter2 = 1;
            }
            else{
                counter1--;
                counter2--;
            }
        }
        //return new List<int>{num1, counter1, num2, counter2};
        
        var result = new List<int>();
        counter1 = 0;
        counter2 = 0;
        int target = nums.Length / 3;
        //2. Pass 2, validate the 2 selected element. see if they are majority.
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] == num1)
                counter1++;
            else if(nums[i] == num2)
                counter2++;
        }
        if(counter1 > target)
            result.Add(num1);
        if(counter2 > target)
            result.Add(num2);
        return result;
    }
}