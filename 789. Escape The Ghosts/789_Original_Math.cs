public class Solution {
    public bool EscapeGhosts(int[][] ghosts, int[] target) {
        var pac = Math.Abs(target[0]) + Math.Abs(target[1]);
        
        foreach(var g in ghosts){
            if(Math.Abs(g[0] - target[0]) + Math.Abs(g[1] - target[1]) <= pac)
                return false;
        }
        
        return true;
    }
}