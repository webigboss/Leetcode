public class Solution {
    public int WidthOfBinaryTree(TreeNode root) {
        var dict = new Dictionary<int, int[]>();
        Helper(root, 1, 0, dict);
        
        var ans = 0;
        foreach(var v in dict.Values){
            ans = Math.Max(ans, v[1]-v[0]+1);
        }
        return ans;
    }
    
    private void Helper(TreeNode node, int lvl, int index, Dictionary<int, int[]> dict){
        if(node == null) return;
        
        if(!dict.ContainsKey(lvl))
            dict[lvl] = new int[]{index, index};
        else{
            if(index < dict[lvl][0])
                dict[lvl][0] = index;
            if(index > dict[lvl][1])
                dict[lvl][1] = index;
        }
        Helper(node.left, lvl+1, index*2, dict);
        Helper(node.right, lvl+1, index*2+1, dict);
    }
}