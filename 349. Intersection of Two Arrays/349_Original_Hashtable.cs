public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var hs = new HashSet<int>();
        var result = new List<int>();
        for(var i = 0; i < nums1.Length; i++){
            if(!hs.Contains(nums1[i])) hs.Add(nums1[i]);
        }
        
        for(var i = 0; i < nums2.Length; i++){
            if(hs.Count == 0)
                break;
            if(hs.Contains(nums2[i])){
                result.Add(nums2[i]);
                hs.Remove(nums2[i]);
            }
        }
        return result.ToArray();
    }
}