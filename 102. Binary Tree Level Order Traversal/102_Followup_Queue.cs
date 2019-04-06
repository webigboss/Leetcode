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
        var list = new List<IList<int>>();
        if(root == null)
            return list;
        var q = new Queue<KeyValuePair<TreeNode, int>>();
        var level = 1;
        var pair = new KeyValuePair<TreeNode, int>(root, level);
        q.Enqueue(pair);
        while(q.Count != 0){
            pair = (KeyValuePair<TreeNode, int>)(q.Dequeue());
            level = pair.Value;
            if(list.Count <= level - 1){
                list.Add(new List<int>());
            }
            list[level - 1].Add(pair.Key.val);
            
            if(pair.Key.left != null)
                q.Enqueue(new KeyValuePair<TreeNode, int>(pair.Key.left, level + 1));
            if(pair.Key.right != null)
                q.Enqueue(new KeyValuePair<TreeNode, int>(pair.Key.right, level + 1));
        }
        return list;
    }
}