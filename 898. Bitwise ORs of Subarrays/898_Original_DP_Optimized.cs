public class Solution {
    public int SubarrayBitwiseORs(int[] A) {
        //optimized DP, TC:O(30n)
        int n = A.Length;
        HashSet<int> ans = new HashSet<int>(), cur = new HashSet<int>(), cur2;
        
        foreach(var i in A){
            cur2 = new HashSet<int>();
            cur2.Add(i);
            foreach(var j in cur)
                cur2.Add(j | i);
            
            foreach(var j in cur2)
                ans.Add(j);
            
            cur = cur2;
        }
        
        return ans.Count;
    }
}