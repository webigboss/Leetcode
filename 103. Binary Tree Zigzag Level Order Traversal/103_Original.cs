   //Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
 }
 
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        var tlevel = 1;
        IList<int> levelList = new List<int>{ 0 };
        while(levelList != null){
            
            ZigzagLevelOrderTraversal(root, result, 1, tlevel);
            levelList = result.Count == tlevel ? result[tlevel - 1] : null;
            
            tlevel++;
        }
        
        return result;
    }
    
    private void ZigzagLevelOrderTraversal(TreeNode n, IList<IList<int>> list, int clevel, int tlevel){
        if(n == null)
            return;
        
        if(clevel < tlevel){
            if(tlevel % 2 == 0){
                //even number, from right to left
                ZigzagLevelOrderTraversal(n.right, list, clevel + 1, tlevel);
                ZigzagLevelOrderTraversal(n.left, list, clevel + 1, tlevel);
            }
            else{
                //odd number, from left to right
                ZigzagLevelOrderTraversal(n.left, list, clevel + 1, tlevel);
                ZigzagLevelOrderTraversal(n.right, list, clevel + 1, tlevel);
            }
        }
        
        if(clevel == tlevel){
            if(list.Count == tlevel - 1)
                list.Add(new List<int>());
            list[tlevel - 1].Add(n.val);
        }
    }
}