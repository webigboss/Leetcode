public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        SolveNQueensBacktracking(new List<string>(), n, result);
        
        return result;
    }
    
    
    private void SolveNQueensBacktracking(IList<string> list, int n, List<IList<string>> result){
        if(list.Count == n){
            result.Add(new List<string>(list));
        }
        
        for(var x = 0; x < n; x++){
            var isValid = true;
            int x1, y1;
            var sb = new StringBuilder();
            //y: list.Count
            
            //1. check straight up
            for(var y = list.Count - 1; y >= 0; y--){
                if(list[y][x] == 'Q'){
                    isValid = false;
                    break;
                }
            }
            if(!isValid)
                continue; 
            //2. check top left
            x1 = x - 1;
            y1 = list.Count - 1;
            while(true){
                if(x1 < 0 || y1 < 0)
                    break;
                if(list[y1--][x1--] == 'Q'){
                    isValid = false;
                    break;
                }
            }
            if(!isValid)
                continue; 
            //3. check top right
            x1 = x + 1;
            y1 = list.Count - 1;
            while(true){
                if(x1 >= n || y1 < 0)
                    break;
                if(list[y1--][x1++] == 'Q'){
                    isValid = false;
                    break;
                }
            }
            if(!isValid)
                continue; 
            
            //valid position to place a Q
            for(var i = 0; i < n; i++){
                if(i == x)
                    sb.Append('Q');
                else
                    sb.Append('.');
            }
            list.Add(sb.ToString());
            SolveNQueensBacktracking(list, n, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}