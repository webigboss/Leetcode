/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        //level order traversal
        var list = new List<int>{ 0 };
        var result = new List<int>();
        var tlevel = 1;
        while(list.Count != 0){
            list = new List<int>();
            LevelOrderTraversal(root, 1, tlevel, list);
            if(list.Count != 0)
                result.Add(list[list.Count - 1]);
            tlevel++;
        }
        return result;
    }
    
    public void LevelOrderTraversal(TreeNode n, int clevel, int tlevel, List<int> list){
        if(n == null)
            return;
        
        if(clevel == tlevel){
            list.Add(n.val);   
        }
        if(clevel < tlevel){
            clevel++;
            LevelOrderTraversal(n.left, clevel, tlevel, list);
            LevelOrderTraversal(n.right, clevel, tlevel, list);
        }
    }
}