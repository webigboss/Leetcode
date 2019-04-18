public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var result = new int[]{-1,- 1};
        int start = 0;
        int end = nums.Length - 1;
        int mid = 0;
        while(start <= end){
            mid = (start + end) / 2;
            if(nums[mid] == target){
            	int fstart = 0; 
            	int fend, lstart; 
                fend = lstart = mid; 
            	int lend = nums.Length - 1;
            	while(fstart <= fend){
            		var fmid = (fstart + fend) / 2;
            		if(nums[fmid] == target){
            			result[0] = fmid;
            			fend = fmid - 1;
            		}
            		else{
            			//nums[fmid] < target
            			fstart = fmid + 1;
            		}
            	}
            	
            	while(lstart <= lend){
            		var lmid = (lstart + lend) / 2;
            		if(nums[lmid] == target){
            			result[1] = lmid;
            			lstart = lmid + 1;
            		}
            		else{
            			//nums[lmid] > target
            			lend = lmid - 1; 
            		}
            	}
                break;
            }
            else if(nums[mid] > target)
                end = mid - 1;
            else
                start = mid + 1;
        }
        return result;
    }
}