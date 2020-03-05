public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var st = new Stack<int>();
        var result = new int[nums1.Length];
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums2.Length; i++){
            while(st.Count > 0 && st.Peek() < nums2[i]){
                dict[st.Pop()] = nums2[i];
            }
            st.Push(nums2[i]);
        }
        while(st.Count > 0){
            dict[st.Pop()] = -1;
        }
        
        for(var i = 0; i < nums1.Length; i++){
            result[i] = dict[nums1[i]];
        }
        
        return result;
    }
}