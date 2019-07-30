public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var st = new Stack<int>();
        var maxArea = 0;
        
        for(var i = 0; i <= heights.Length; i++){
            int ht = i < heights.Length ? heights[i] : 0;
            if(st.Count == 0 || ht >= heights[st.Peek()])
                st.Push(i);
            else{
                var itop = st.Pop();
                var topHeight = heights[itop];
                maxArea = Math.Max(maxArea, topHeight * ((st.Count == 0) ? i : (i - st.Peek() - 1)));
                i--;
            }
        }
        return maxArea;
    }
}