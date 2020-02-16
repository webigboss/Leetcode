public class Solution {
    private Random _rdn = new Random();
    public int MinMoves2(int[] nums) {
        //Quickselect approach (recursion)
        var moves = 0;
        int iMedian = nums.Length / 2;
        var median  = QuickSelect(nums, 0, nums.Length - 1, iMedian);
        foreach(var n in nums){
            moves += Math.Abs(median - n);
        }
        return moves;
    }
    
    private int QuickSelect(int[] nums, int lo, int hi, int k) {
        var iPivot = lo + _rdn.Next(hi - lo  + 1);
        var i = Partition(nums, lo, hi, iPivot);
        if(i == k) return nums[k];
        if(i > k)
            return QuickSelect(nums, lo, i - 1, k);
        else
            return QuickSelect(nums, i + 1, hi, k);
    }
    
    private int Partition(int[] nums, int lo, int hi, int iPivot) {
        if(lo == hi) return lo;
        var partitionIndex = lo;
        Swap(nums, iPivot, hi);
        for(var i = lo; i < hi; i++) {
            if(nums[i] < nums[hi]) {
                Swap(nums, i, partitionIndex);
                partitionIndex++;
            }
        }
        Swap(nums, hi, partitionIndex);
        return partitionIndex;
    }
    
    private void Swap(int[] nums, int i, int j) { 
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}