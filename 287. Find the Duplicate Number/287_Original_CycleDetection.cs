public class Solution {
    public int FindDuplicate(int[] nums) {
        var p1 = nums[nums[0]];
        var p2 = nums[p1];
        //1. find the meeting point
        while(p1 != p2){
            p1 = nums[p1];
            p2 = nums[nums[p2]];
        }
        //2. reset one of the point to the starting point, to find the start element of the cycle, which happens to be the duplicated element
        p1 = nums[0];
        while(p1 != p2){
            p1 = nums[p1];
            p2 = nums[p2];
        }
        return p1;
    }
}