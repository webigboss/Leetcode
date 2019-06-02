public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if(nums.Length == 0)
            return -1;
        HeapSortStopAt(nums, nums.Length - k);
        return nums[nums.Length - k];
    }
    
    
    private void HeapSortStopAt(int[] nums, int stopAt){
        var length = nums.Length;
        //1. heapify 
        for(int i = nums.Length / 2; i >= 0; i--){
            BubbleDown(nums, i, length);
        }
        
        //2. extraction (sort)
        for(var i = nums.Length - 1; i >= stopAt; i--){
            Swap(nums, 0, length - 1);
            length--;
            BubbleDown(nums, 0, length);
        }
    }
    
    private void BubbleDown(int[] nums, int index, int length){
        var curIndex = index;
        
        while(HasLeftChild(curIndex, length)){
            var biggerValueIndex = GetLeftChildIndex(curIndex);
            if(HasRightChild(curIndex, length)){
                var rightIndex = GetRightChildIndex(curIndex);
                if(nums[biggerValueIndex] < nums[rightIndex])
                    biggerValueIndex = rightIndex;
            }
            if(nums[curIndex] > nums[biggerValueIndex])
                break;
            Swap(nums, curIndex, biggerValueIndex);
            curIndex = biggerValueIndex;
        }
    }
    
    private void Swap(int[] nums, int index1, int index2){
        var temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
    }
    
    private bool HasLeftChild(int parent, int length){
        return GetLeftChildIndex(parent) < length;
    }
    
    private bool HasRightChild(int parent, int length){
        return GetRightChildIndex(parent) < length;
    }
    
    private int GetLeftChildIndex(int parent){
        return parent * 2 + 1;
    }
    
    private int GetRightChildIndex(int parent){
        return parent * 2 + 2;
    }
    
    private int GetParentIndex(int child){
        return (child - 1) / 2;
    }
}