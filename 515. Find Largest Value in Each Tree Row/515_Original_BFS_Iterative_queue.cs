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
    public IList<int> LargestValues(TreeNode root) {
        //BFS iteration by a queue
        var result = new List<int>();
        if(root == null) return result;
        var q = new Queue<KeyValuePair<TreeNode, int>>();

        var prevLevel = 1;
        var max = int.MinValue;
        q.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));
        while(q.Count > 0) {
            var kvp = q.Dequeue();
            if(prevLevel < kvp.Value){
                result.Add(max);
                max = kvp.Key.val;
                prevLevel = kvp.Value;
            }
            max = Math.Max(max, kvp.Key.val);
            if(kvp.Key.left != null)
                q.Enqueue(new KeyValuePair<TreeNode, int>(kvp.Key.left, prevLevel + 1));
            if(kvp.Key.right != null)
                q.Enqueue(new KeyValuePair<TreeNode, int>(kvp.Key.right, prevLevel + 1));
        }
        result.Add(max);
        return result;
    }
}