public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var result = new int[nums.Length];
        //initialize default value to -1;
        Array.Fill(result, -1);
        
        var st = new Stack<int[]>();
    
        //do iteration twice
        for(var i = 0; i < nums.Length * 2; ++i){
            while(st.Count > 0 && st.Peek()[0] < nums[i % nums.Length]){
                var item = st.Pop();
                result[item[1]] = nums[i % nums.Length];
            }
            st.Push(new []{nums[i % nums.Length], i % nums.Length});
        }
        
        return result;
    }
}