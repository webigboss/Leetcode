public class Solution {
    public string LargestNumber(int[] nums) {
        //heap sort solution (min heap)
        //1. heapify
        var length = nums.Length;
        for(var i = nums.Length / 2; i >= 0; i--){
            BubbleDown(nums, i, length);
        }
        
        //2. extraction
        while(length > 1){
            Swap(nums, 0, length - 1);
            length--;
            BubbleDown(nums, 0, length);
        }
        
        
        //3.for the sorted array to string
        var sb = new StringBuilder();
        if(nums[0] == 0)
            return "0";
        for(var i = 0; i < nums.Length; i++){
            sb.Append(nums[i]);
        }
        return sb.ToString();
    }
    
    private void BubbleDown(int[] nums, int index, int length){
        var curIndex = index;
        while(HasLeftChild(curIndex, length)){
            var smallerChildIndex = GetLeftChildIndex(curIndex);
            if(HasRightChild(curIndex, length)){
                var rightChildIndex = GetRightChildIndex(curIndex);
                smallerChildIndex = Compare(nums[smallerChildIndex], nums[rightChildIndex]) 
                    ? smallerChildIndex : rightChildIndex;
            }
            if(Compare(nums[curIndex], nums[smallerChildIndex]))
                break;
            Swap(nums, smallerChildIndex, curIndex);
            curIndex = smallerChildIndex;
        }
    }
    
    // custom compare logic to determine which integer will be sorted at behind (equivalent to bigger in regular compare)
    // return ture if left is 'smaller' than right (because the the largest number requires a descending order sort)
    private bool Compare(int left, int right){
        var strLeft = left.ToString();
        var strRight = right.ToString();
        
        return (strLeft + strRight).CompareTo(strRight + strLeft) == -1;
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
        return (child - 1 ) / 2;
    }
    
    private void Swap(int[] nums, int index1, int index2){
        int temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
    }
}