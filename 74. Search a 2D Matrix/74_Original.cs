public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int start = 0;
        int end = matrix.Length - 1;
        int midy = 0;
        int mid = 0;
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return false;
        
        while(start <= end){
            midy = (start + end) / 2;
            if(start == end)
                break;
            if(matrix[midy][0] > target){
                end = midy - 1;
            }
            else{
                //matrix[midy][0] <= target
                start = midy;
                if(matrix[midy][matrix[midy].Length - 1] >= target)
                    end = midy;
                else
                    start = midy + 1;
            }
        }
        start = 0;
        end = matrix[midy].Length - 1;
        while(start <= end){
            mid = (start + end) / 2;
            if(matrix[midy][mid] == target)
                return true;
            else if(matrix[midy][mid] > target){
                end = mid - 1;
            }
            else{
                //matrix[midy][mid] < target
                start = mid + 1;
            }
        }
        return false;
        
    }
}