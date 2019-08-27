public class Solution {
    private int first = int.MinValue;
    private int second = int.MinValue;
    private int third = int.MinValue;
    private int thirdChangeCount = 0;
    private bool hasIntMinValue = false;
    public int ThirdMax(int[] nums) {
        for(var i = 0; i < nums.Length; i++){
            AddNumber(nums[i]);
        }
        
        return thirdChangeCount < 3 ? first : third;
    }
    
    private void AddNumber(int num){
        if(num > first){
            third = second;
            second = first;
            first = num;
            thirdChangeCount++;
        }
        else if(num > second && num < first){
            third = second;
            second = num;
            thirdChangeCount++;
        }
        else if(num > third && num < second){
            third = num;
            thirdChangeCount++;
        }
        if(num == int.MinValue && !hasIntMinValue) {
            thirdChangeCount++;
            hasIntMinValue = true;
        }
        
    }
}