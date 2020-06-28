public class Solution {
    public bool IsPathCrossing(string path) {
        var hs = new HashSet<int>();
        var x = 0;
        var y = 0;
        hs.Add(0);
        foreach(var p in path){
            if(p == 'N')
                x++;
            else if(p == 'S')          
                x--;
            else if(p == 'W')    
                y--;
            else if(p == 'E')
                y++;
            
            int cur = x*10000+y;
            if(hs.Contains(cur)) return true;
            else hs.Add(cur);
        }
        return false;
    }
}