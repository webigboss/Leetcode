public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        //based on the solution of Lastest rectangle in histogram LC84 (stack)
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return 0;
        var heights = new int[matrix[0].Length];
        var maxRectangle = 0;
        for(var y = 0; y < matrix.Length; y++){
            for(var x = 0; x < matrix[0].Length; x++){
                if(matrix[y][x] == '1')
                    heights[x]++;
                else
                    heights[x] = 0;
            }
            var maxArea = LargestRectangleInHistogram(heights);
            maxRectangle = Math.Max(maxRectangle, maxArea);
        }
        return maxRectangle;
    }
    
    
    public int LargestRectangleInHistogram(int[] heights){
        var maxArea = 0;
        var st = new Stack<int>();
        
        for(var i = 0; i <= heights.Length; i++){
            var curHeight = i < heights.Length ? heights[i] : 0;
            
            if(st.Count == 0 || curHeight >= heights[st.Peek()])
                st.Push(i);
            else{
                var lowestHeight = heights[st.Pop()];
                maxArea = Math.Max(maxArea, lowestHeight * ((st.Count == 0) ? i : i - st.Peek() - 1));
                i--;
            }
        }
        return maxArea;
    }
}