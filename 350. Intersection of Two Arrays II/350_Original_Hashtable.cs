public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dict1 = new Dictionary<int, int>();
        var dict2 = new Dictionary<int, int>();
        var list = new List<int>();
        for(var i = 0; i < nums1.Length; i++){
            if(dict1.ContainsKey(nums1[i]))
                dict1[nums1[i]]++;
            else
                dict1[nums1[i]] = 1;
        }
        
        for(var i = 0; i < nums2.Length; i++){
            if(dict1.ContainsKey(nums2[i])){
                if(dict2.ContainsKey(nums2[i])){
                    if(dict2[nums2[i]] < dict1[nums2[i]])
                        dict2[nums2[i]]++;
                }
                else
                    dict2[nums2[i]] = 1;
            }
        }
        foreach(var kvp in dict2){
            var value = kvp.Value;
            while(value > 0){
                list.Add(kvp.Key);
                value--;
            }
        }
        
        return list.ToArray();
    }
}