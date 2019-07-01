public class Solution {
    private Random rnd;
    public int FindKthLargest(int[] nums, int k) {
        //Quickselect approach
        rnd = new Random();
        return Quickselect(nums, 0, nums.Length - 1, nums.Length - k);
    }
    
    private int Quickselect(int[] nums, int left, int right, int k){
        if(left == right)
            return nums[left];
        //random the pivot element to avoid worse case O(n^2) when nums is already sorted
        var pivotIndex = left + (rnd.Next() % (right - left + 1));
        var correctIndex = Partition(nums, left, right, pivotIndex);
        if(k == correctIndex)
            return nums[k];
        if(k > correctIndex)
            return Quickselect(nums, correctIndex + 1, right, k);
        else
            return Quickselect(nums, left, correctIndex - 1, k);
    }
    
    private int Partition(int[] nums, int left, int right, int pivotIndex){
        //Lomuto partition scheme
        var pivotValue = nums[pivotIndex];
        //swap the pivot element to the last of the given range (Lomuto partition scheme require the pivot to the last element)
        Swap(nums, pivotIndex, right);
        //set pivotIndex to the starting index (left)
        pivotIndex = left;
        for(var i = left; i < right; i++){
            if(nums[i] < pivotValue) 
                Swap(nums, pivotIndex++, i);
        }
        //swap the pivot element at the last to the pivotIndex, now the pivot element is at it's correct index
        Swap(nums, pivotIndex, right);
        return pivotIndex;
    }
    
    private void Swap(int[] nums, int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}