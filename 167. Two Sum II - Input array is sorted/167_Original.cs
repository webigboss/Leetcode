public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // two pointers solution
        int start = 0;
        int end = numbers.Length - 1;
        var result = new int[2];
        while(start < end){
            if(numbers[start] + numbers[end] > target){
                end--; 
            }
            else if (numbers[start] + numbers[end] < target){
                start++;
            }
            else{
                //numbers[start] + numbers[end] == target
                result[0] = start + 1;
                result[1] = end + 1;
                break;
            }
        }
        return result;
    }
}