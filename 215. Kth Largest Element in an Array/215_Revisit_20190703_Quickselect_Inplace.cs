public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int kthSmallest = nums.Length - k;
        int left = 0;
        int right = nums.Length - 1;
        int pivotIndex;
        int pivotValue;
        var rnd = new Random();
        
        while(left <= right){
            if(left == right)
                return nums[left];
            pivotIndex = left + rnd.Next() % (right - left + 1);
            pivotValue = nums[pivotIndex];
            //lomuto partition scheme, always starts from the last element as the pivot, so move the randomized pivot element to last
            Swap(nums, pivotIndex, right);
            
            var iLessThanPivot = left;
            for(var i = left; i <= right - 1; i++){
                if(nums[i] < pivotValue)
                    Swap(nums, i, iLessThanPivot++);
            }
            //Swap pivot element from the last to iLessThanPivot, then it's the correct place where the pivot element should be after sorting
            Swap(nums, right, iLessThanPivot);
            
            if(iLessThanPivot == kthSmallest)
                return nums[iLessThanPivot];
            
            if(kthSmallest > iLessThanPivot)
                left = iLessThanPivot + 1;
            else
                right = iLessThanPivot - 1;
        }
        return 0;
    }
    
    private void Swap(int[] nums, int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}