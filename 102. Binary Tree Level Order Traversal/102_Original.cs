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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        List<int> levelResult = new List<int>{ 1 };
        var level = 0;
        while(levelResult.Count != 0){
            levelResult = GetLevel(root, 0, level);
            level++;
            if(levelResult.Count != 0)
                result.Add(levelResult);
        }
        return result;
        
    }
    
    private List<int> GetLevel(TreeNode n, int currentLevel, int level){
        var list = new List<int>();
        if(n == null)
            return list;
        
        if(currentLevel == level)
            list.Add(n.val);
        else if(currentLevel < level){
            currentLevel++;
            list = GetLevel(n.left, currentLevel, level);
            list.AddRange(GetLevel(n.right, currentLevel, level));
        }
        return list;
    }
}