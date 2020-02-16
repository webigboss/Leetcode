public class Solution {
    private Random _rdn = new Random();
    public int MinMoves2(int[] nums) {
        //Quickselect approach (interation)
        int iMedian = nums.Length / 2;
        var median = Quickselect(nums, iMedian);
        var moves = 0;
        foreach(var n in nums){
            moves += Math.Abs(median - n);
        }
        return moves;
    }
    
    
    private int Quickselect(int[] nums, int k) {
        var lo = 0;
        var hi = nums.Length - 1;
        var iPivot = 0;
        var actualIndex = 0;
        while(true) {
            if(lo == hi) 
                return nums[lo];
            iPivot = lo + _rdn.Next(hi - lo + 1);
            actualIndex = Partition(nums, lo, hi, iPivot);
            if(actualIndex == k) 
                break;
            if(actualIndex < k)
                lo = actualIndex + 1;
            else
                hi = actualIndex - 1;
        }
        return nums[actualIndex];
    }
    
    //Lomuto partition with randomized pivot index
    private int Partition(int[] nums, int lo, int hi, int iPivot) {
        if(hi == lo) return hi;
        var partitionIndex = lo;
        Swap(nums, iPivot, hi);
        for(var i = lo; i < hi; i++) {
            if(nums[i] < nums[hi]){
                Swap(nums, i, partitionIndex);
                partitionIndex++;
            }
        }
        Swap(nums, partitionIndex, hi);
        return partitionIndex;
    }
    
    private void Swap(int[] nums, int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}