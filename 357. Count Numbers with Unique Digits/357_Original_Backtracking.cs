public class Solution {
    public int CountNumbersWithUniqueDigits(int n) {
        //backtracking solution
        if(n == 0)
            return 1;
        var result = new int[1];
        var visited = new bool[10];
        for(var i = 1; i <= n; i++){
            for(var j = 0; j <= 9; j++){
                if(i > 1 && j == 0) continue; 
                visited[j] = true;
                BacktrackingHelper(1, i, visited, result);
                visited[j] = false;
            }
        }
        return result[0];
    }
    
    private void BacktrackingHelper(int curLength, int targetLength, bool[] visited, int[] result){
        if(curLength == targetLength){
            result[0]++;
            return;
        }
        
        for(var i = 0; i <= 9; i++){
            if(visited[i] == true) continue;
            visited[i] = true;
            BacktrackingHelper(curLength + 1, targetLength, visited, result);
            visited[i] = false;
        }
    }
}