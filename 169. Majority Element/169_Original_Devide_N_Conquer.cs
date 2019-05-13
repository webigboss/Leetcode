public class Solution {
    public int MajorityElement(int[] nums) {
        //divide and conquer solution
        return MajorityElementRecursive(nums, 0, nums.Length - 1);
    }
    
    private int MajorityElementRecursive(int[] nums, int left, int right){
        if(left == right)
            return nums[left];
        
        int mid = (right - left) / 2 + left;
        
        int leftElem = MajorityElementRecursive(nums, left, mid);
        int rightElem = MajorityElementRecursive(nums, mid + 1, right);
        
        if(leftElem == rightElem)
            return leftElem;
        
        int leftCount = CountElementInRange(nums, leftElem, left, right);
        int rightCount = CountElementInRange(nums, rightElem, left, right);
        
        return leftCount > rightCount ? leftElem : rightElem;
            
    }
    
    private int CountElementInRange(int[] nums, int elem, int left, int right){
        int counter = 0;
        for(var i = left; i <= right; i++){
            if(nums[i] == elem)
                counter++;
        }
        return counter;
    }
}