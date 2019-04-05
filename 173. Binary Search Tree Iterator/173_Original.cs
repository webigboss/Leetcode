/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator {

    private TreeNode n;
    private Stack st;
    public BSTIterator(TreeNode root) {
        st = new Stack();
        n = root;
        while(n != null){
            st.Push(n);
            n = n.left;
        }   
    }
    
    /** @return the next smallest number */
    public int Next() {
        var cur = (TreeNode)st.Pop();
        n = cur.right;
        while(n != null){
            st.Push(n);
            n = n.left;
        }
        return cur.val;
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return st.Count != 0;   
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */