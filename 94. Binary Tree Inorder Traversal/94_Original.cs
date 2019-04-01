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
    public IList<int> InorderTraversal(TreeNode root) {
        //Iterative solution
        var st = new Stack();
        var result = new List<int>();
        while(true){
            //push all left node all the way down to the leaf node
            while(root != null){
                st.Push(root);
                root = root.left;
            }
            
            if(st.Count == 0)
                break;
            //no more left nodes, pop the top node from the stack which is the bottom node without a left child, add node value;
            root = (TreeNode)st.Pop();
            result.Add(root.val);
            //restart the whole interation from the bottom node's right child
            root = root.right;
        }
        return result;
    }
}