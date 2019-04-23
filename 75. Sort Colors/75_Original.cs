public class Solution {
    public void SortColors(int[] nums) {
        // counting sort solution
        // time complexity O(n), space complexity O(1)
        
        var countArray = new int[3];
        
        foreach(var i in nums){
            countArray[i]++;
        }
        var index = 0;
        for(var i = 0; i < countArray.Length; i++){
            while(countArray[i] > 0){
                nums[index++] = i;
                countArray[i]--;
            }
        }
    }
}