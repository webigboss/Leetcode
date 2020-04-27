public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        //in order iterative traveral
        var st = new Stack<TreeNode>();
        var hs = new HashSet<int>();
        while(true){
            while(root != null){
                st.Push(root);
                root = root.left;
            }
            if(st.Count == 0) break;
            root = st.Pop();
            if(hs.Contains(k - root.val)) return true;
            hs.Add(root.val);
            root = root.right;
        }
        
        return false;
    }
}